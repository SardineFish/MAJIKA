using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;
using System.IO;

namespace Assets.Editor
{
    [CustomEditor(typeof(StateAsset), true)]
    [CanEditMultipleObjects]
    class StateAssetEditor: UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if(GUILayout.Button("Auto Set States"))
            {
                var path = AssetDatabase.GetAssetPath(target);
                var folder = Path.GetDirectoryName(path).Replace("\\", "/");
                var stateAssets = AssetDatabase.FindAssets("", new string[] { folder })
                    .Select(guid => AssetDatabase.GUIDToAssetPath(guid))
                    .Select(p => AssetDatabase.LoadAssetAtPath<StateAsset>(p));
                AutoSetStates(stateAssets);
            }
        }

        void AutoSetStates(IEnumerable<StateAsset> stateAssets)
        {
            foreach(var state in stateAssets)
            {
                state.GetType().GetFields()
                    .Where(field => field.FieldType.IsSubclassOf(typeof(StateAsset)))
                    .ForEach(field => {
                        var value = stateAssets.Where(s => s.GetType() == field.FieldType).FirstOrDefault();
                        field.SetValue(state, value);
                        Debug.Log($"Set {(value is null? "null" : value.name)} to {state.name}.{field.Name}");
                    });
            }
        }
    }
}
