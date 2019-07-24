using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.InputSystem;
using System.Linq;
using System.Text.RegularExpressions;
using YamlDotNet.Serialization;

namespace MAJIKA.TextManager
{
    [CreateAssetMenu(fileName = "InputControlTextDefinition", menuName = "TextDefinition/InputControl")]
    public class InputControlTextDefinition : TextDefinitionAsset
    {
        MAJIKAInput input;

        public TextAsset TextDefinitionAsset;

        public List<string> InputActions = new List<string>();

        Dictionary<string, string> TextDefinitions = new Dictionary<string, string>();

        public Dictionary<string, string> GamepadKeyText = new Dictionary<string, string>();
        public Dictionary<string, string> KeyboardKeyText = new Dictionary<string, string>();
        public Dictionary<string, string> TouchScreenText = new Dictionary<string, string>();
        public Dictionary<string, Func<string>> DefinitionTranslate = new Dictionary<string, Func<string>>()
        {
            ["input-action"] = () => InputManager.Instance.CurrentActiveDeviceType == DeviceClass.Gamepad
                ? "<Gamepad>/action"
                : InputManager.Instance.CurrentActiveDeviceType == DeviceClass.Keyboard
                    ? "<Keyboard>/action"
                    : "<Touch>/Action"
        };
        public override string this[string id]
        {
            get
            {
                if (DefinitionTranslate.ContainsKey(id))
                    id = DefinitionTranslate[id]();
                if(InputActions.Contains(id))
                {
                    if (InputManager.Instance.CurrentActiveDeviceType == DeviceClass.Gamepad)
                        return GamepadKeyText[id];
                    else if (InputManager.Instance.CurrentActiveDeviceType == DeviceClass.Keyboard)
                        return KeyboardKeyText[id];
                    else if (InputManager.Instance.CurrentActiveDeviceType == DeviceClass.TouchScreen)
                        return TouchScreenText[id];
                }
                return null;
            }
        }

        public override bool Has(string id)
        {
            return InputActions.Contains(id) || DefinitionTranslate.ContainsKey(id);
        }

        [EditorButton]
        public override void Reload()
        {
            if(TextDefinitionAsset)
            {
                var deserializer = new YamlDotNet.Serialization.Deserializer();
                TextDefinitions = deserializer.Deserialize<Dictionary<string, string>>(TextDefinitionAsset.text);
            }
            KeyboardKeyText = new Dictionary<string, string>();
            GamepadKeyText = new Dictionary<string, string>();
            input?.Disable();
            input = new MAJIKAInput();
            var regGamePad = new Regex(@"<Gamepad>/(\S+)", RegexOptions.IgnoreCase | RegexOptions.ECMAScript);
            var regKeyboard = new Regex(@"<Keyboard>/(\S+)", RegexOptions.IgnoreCase | RegexOptions.ECMAScript);
            var regTouchScreen = new Regex(@"<AndroidGamepad>/(\S+)", RegexOptions.IgnoreCase | RegexOptions.ECMAScript);
            input.ForEach(action =>
            {
                var actionName = action.name.ToLower();
                InputActions.Add(actionName);
                action.bindings.Where(binding => !binding.isComposite)
                    .ForEach(binding =>
                    {
                        Debug.Log(binding.path);
                        // Gamepad
                        var match = regGamePad.Match(binding.path);
                        if (match.Success)
                        {
                            if (!GamepadKeyText.ContainsKey(actionName))
                                GamepadKeyText[actionName] = TextDefinitions[binding.path];
                            else
                                GamepadKeyText[actionName] = Utility.StringJoin(",", GamepadKeyText[actionName], TextDefinitions[binding.path]);
                        }

                        // Keyboard
                        match = regKeyboard.Match(binding.path);
                        if (match.Success)
                        {
                            if (!KeyboardKeyText.ContainsKey(actionName))
                                KeyboardKeyText[actionName] = TextDefinitions[binding.path];
                            else
                                KeyboardKeyText[actionName] = Utility.StringJoin(",", KeyboardKeyText[actionName], TextDefinitions[binding.path]);
                        }

                        // Touch
                        match = regTouchScreen.Match(binding.path);
                        if (match.Success)
                        {
                            if (!TouchScreenText.ContainsKey(actionName))
                                TouchScreenText[actionName] = TextDefinitions[$"<Touch>/{match.Groups[1]}"];
                            else 
                                TouchScreenText[actionName] = Utility.StringJoin(",", KeyboardKeyText[actionName], TextDefinitions[$"<Touch>/{match.Groups[1]}"]);
                        }
                    });
            });
        }
    }

    [Serializable]
    public class InputActionTextMap : SerializableDictionary<string, string>
    {

    }

}
