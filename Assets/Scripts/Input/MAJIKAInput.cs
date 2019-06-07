// GENERATED AUTOMATICALLY FROM 'Assets/Input/MAJIKAInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class MAJIKAInput : IInputActionCollection
{
    private InputActionAsset asset;
    public MAJIKAInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MAJIKAInput"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""6f10c320-b22a-45a9-bf73-aab63e03b425"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""id"": ""dae96b02-b97f-4f4b-89f8-24f12c6c322c"",
                    ""expectedControlLayout"": """",
                    ""continuous"": true,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Jump"",
                    ""id"": ""a6dfbb9b-4192-4352-8c88-5bb6cb8abfb3"",
                    ""expectedControlLayout"": """",
                    ""continuous"": true,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Climb"",
                    ""id"": ""afa79d8c-b9bc-4af7-84b8-d7d49e31d59e"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Skill1"",
                    ""id"": ""3d39d5e4-aa51-49ad-bb92-071060061403"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Skill2"",
                    ""id"": ""b1e3df68-b226-412f-a8b9-f0aa5ad60d59"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Skill3"",
                    ""id"": ""728e8880-8695-4ff1-afa7-4e6724b43f3e"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Skill4"",
                    ""id"": ""1a6a92d6-7f38-484f-8e0f-be42ee6fc5e6"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""049c9eda-98d3-42c5-994b-426ae5e19a2c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""994164b8-1836-4cf0-83ce-a5a38fb8f388"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""9971552e-fb76-4f58-8ac5-832e414091c2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""4e62db60-e3bd-4e1b-be2f-5587dd56b858"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""7e72f984-4a94-4958-a2a3-6ea830d2e96b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""8aaf9f63-512b-41b5-b821-237b989f5347"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""7c5e0a55-75d7-4055-8c70-41911604c09a"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""b1143c18-7209-418f-92d2-235bb1769687"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""64492e5e-7949-48a0-8931-d03476b42853"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Climb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""668301b8-147e-468d-bb39-c49cfbf77e92"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""43cf41d7-9694-4c59-ab33-18fcebdbbec7"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""ac9e1d67-9863-4d66-901f-ddaf46797f0c"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""5c901149-a300-418f-bd93-2695a33fde92"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""8b434aa0-0415-43a5-b7bc-5420a3fa6e92"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""d8457e5a-2f6e-4c54-b8d6-7e51211cf17f"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        },
        {
            ""name"": ""Actions"",
            ""id"": ""979648fe-b14b-49a0-88a0-f265d902f365"",
            ""actions"": [
                {
                    ""name"": ""Accept"",
                    ""id"": ""65446e76-5303-445e-9a14-aa3d76f04e8c"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Back"",
                    ""id"": ""24aa8211-93cc-4d8c-895f-850829cb1c26"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Interact"",
                    ""id"": ""2d4bb328-46c7-4bd7-bab7-da0d5569037d"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""bindings"": []
                },
                {
                    ""name"": ""Inventory"",
                    ""id"": ""64ff6447-e02d-4e4e-9652-5340597bf192"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""bindings"": []
                },
                {
                    ""name"": ""AnyKey"",
                    ""id"": ""b3a34c68-9479-44eb-bdec-4e10285db884"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Test"",
                    ""id"": ""f0b2ee71-4669-4ffb-b850-1d10eab9466f"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Touch"",
                    ""id"": ""6e192c60-8edc-4d0f-b132-807bbb64e9cf"",
                    ""expectedControlLayout"": """",
                    ""continuous"": true,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""82421fd4-364e-4298-9643-4dd696eb3aeb"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""10919dd5-588f-419f-ba03-f634468eb920"",
                    ""path"": ""<Touchscreen>/button"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""e6b8b731-605d-4fa3-835b-c17f88799324"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""4795fe0d-dc46-4aba-a72c-e3d8dd3d934f"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""9fabf9ac-1821-4341-9cbc-e0ef52f6bdff"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""06dcc9dd-570e-4a76-b3e0-5974076bb3da"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""77c6a977-aa60-4913-912c-f731cd6bde11"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""622ab64d-f7bf-4658-a13d-856576c8b0ac"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""8e1f3916-70e4-4911-8d1e-8131286c2558"",
                    ""path"": ""<Touchscreen>/phase"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Test"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""ff160c95-6bea-4767-84c8-a7af675ac1c3"",
                    ""path"": ""<Touchscreen>/touch"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Test"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""4c70f1a3-b6eb-4cb2-86d9-790c5586ffcd"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""da1d8495-f5f2-4d7d-808c-28b79975d3a7"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GamePlay
        m_GamePlay = asset.GetActionMap("GamePlay");
        m_GamePlay_Movement = m_GamePlay.GetAction("Movement");
        m_GamePlay_Jump = m_GamePlay.GetAction("Jump");
        m_GamePlay_Climb = m_GamePlay.GetAction("Climb");
        m_GamePlay_Skill1 = m_GamePlay.GetAction("Skill1");
        m_GamePlay_Skill2 = m_GamePlay.GetAction("Skill2");
        m_GamePlay_Skill3 = m_GamePlay.GetAction("Skill3");
        m_GamePlay_Skill4 = m_GamePlay.GetAction("Skill4");
        // Actions
        m_Actions = asset.GetActionMap("Actions");
        m_Actions_Accept = m_Actions.GetAction("Accept");
        m_Actions_Back = m_Actions.GetAction("Back");
        m_Actions_Interact = m_Actions.GetAction("Interact");
        m_Actions_Inventory = m_Actions.GetAction("Inventory");
        m_Actions_AnyKey = m_Actions.GetAction("AnyKey");
        m_Actions_Test = m_Actions.GetAction("Test");
        m_Actions_Touch = m_Actions.GetAction("Touch");
    }

    ~MAJIKAInput()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes
    {
        get => asset.controlSchemes;
    }

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // GamePlay
    private InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private InputAction m_GamePlay_Movement;
    private InputAction m_GamePlay_Jump;
    private InputAction m_GamePlay_Climb;
    private InputAction m_GamePlay_Skill1;
    private InputAction m_GamePlay_Skill2;
    private InputAction m_GamePlay_Skill3;
    private InputAction m_GamePlay_Skill4;
    public struct GamePlayActions
    {
        private MAJIKAInput m_Wrapper;
        public GamePlayActions(MAJIKAInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement { get { return m_Wrapper.m_GamePlay_Movement; } }
        public InputAction @Jump { get { return m_Wrapper.m_GamePlay_Jump; } }
        public InputAction @Climb { get { return m_Wrapper.m_GamePlay_Climb; } }
        public InputAction @Skill1 { get { return m_Wrapper.m_GamePlay_Skill1; } }
        public InputAction @Skill2 { get { return m_Wrapper.m_GamePlay_Skill2; } }
        public InputAction @Skill3 { get { return m_Wrapper.m_GamePlay_Skill3; } }
        public InputAction @Skill4 { get { return m_Wrapper.m_GamePlay_Skill4; } }
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                Movement.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMovement;
                Movement.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMovement;
                Movement.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMovement;
                Jump.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJump;
                Jump.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJump;
                Jump.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJump;
                Climb.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnClimb;
                Climb.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnClimb;
                Climb.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnClimb;
                Skill1.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill1;
                Skill1.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill1;
                Skill1.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill1;
                Skill2.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill2;
                Skill2.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill2;
                Skill2.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill2;
                Skill3.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill3;
                Skill3.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill3;
                Skill3.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill3;
                Skill4.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill4;
                Skill4.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill4;
                Skill4.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill4;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                Movement.started += instance.OnMovement;
                Movement.performed += instance.OnMovement;
                Movement.canceled += instance.OnMovement;
                Jump.started += instance.OnJump;
                Jump.performed += instance.OnJump;
                Jump.canceled += instance.OnJump;
                Climb.started += instance.OnClimb;
                Climb.performed += instance.OnClimb;
                Climb.canceled += instance.OnClimb;
                Skill1.started += instance.OnSkill1;
                Skill1.performed += instance.OnSkill1;
                Skill1.canceled += instance.OnSkill1;
                Skill2.started += instance.OnSkill2;
                Skill2.performed += instance.OnSkill2;
                Skill2.canceled += instance.OnSkill2;
                Skill3.started += instance.OnSkill3;
                Skill3.performed += instance.OnSkill3;
                Skill3.canceled += instance.OnSkill3;
                Skill4.started += instance.OnSkill4;
                Skill4.performed += instance.OnSkill4;
                Skill4.canceled += instance.OnSkill4;
            }
        }
    }
    public GamePlayActions @GamePlay
    {
        get
        {
            return new GamePlayActions(this);
        }
    }

    // Actions
    private InputActionMap m_Actions;
    private IActionsActions m_ActionsActionsCallbackInterface;
    private InputAction m_Actions_Accept;
    private InputAction m_Actions_Back;
    private InputAction m_Actions_Interact;
    private InputAction m_Actions_Inventory;
    private InputAction m_Actions_AnyKey;
    private InputAction m_Actions_Test;
    private InputAction m_Actions_Touch;
    public struct ActionsActions
    {
        private MAJIKAInput m_Wrapper;
        public ActionsActions(MAJIKAInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accept { get { return m_Wrapper.m_Actions_Accept; } }
        public InputAction @Back { get { return m_Wrapper.m_Actions_Back; } }
        public InputAction @Interact { get { return m_Wrapper.m_Actions_Interact; } }
        public InputAction @Inventory { get { return m_Wrapper.m_Actions_Inventory; } }
        public InputAction @AnyKey { get { return m_Wrapper.m_Actions_AnyKey; } }
        public InputAction @Test { get { return m_Wrapper.m_Actions_Test; } }
        public InputAction @Touch { get { return m_Wrapper.m_Actions_Touch; } }
        public InputActionMap Get() { return m_Wrapper.m_Actions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(ActionsActions set) { return set.Get(); }
        public void SetCallbacks(IActionsActions instance)
        {
            if (m_Wrapper.m_ActionsActionsCallbackInterface != null)
            {
                Accept.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnAccept;
                Accept.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnAccept;
                Accept.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnAccept;
                Back.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnBack;
                Back.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnBack;
                Back.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnBack;
                Interact.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnInteract;
                Interact.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnInteract;
                Interact.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnInteract;
                Inventory.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnInventory;
                Inventory.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnInventory;
                Inventory.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnInventory;
                AnyKey.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnAnyKey;
                AnyKey.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnAnyKey;
                AnyKey.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnAnyKey;
                Test.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnTest;
                Test.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnTest;
                Test.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnTest;
                Touch.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnTouch;
                Touch.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnTouch;
                Touch.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnTouch;
            }
            m_Wrapper.m_ActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                Accept.started += instance.OnAccept;
                Accept.performed += instance.OnAccept;
                Accept.canceled += instance.OnAccept;
                Back.started += instance.OnBack;
                Back.performed += instance.OnBack;
                Back.canceled += instance.OnBack;
                Interact.started += instance.OnInteract;
                Interact.performed += instance.OnInteract;
                Interact.canceled += instance.OnInteract;
                Inventory.started += instance.OnInventory;
                Inventory.performed += instance.OnInventory;
                Inventory.canceled += instance.OnInventory;
                AnyKey.started += instance.OnAnyKey;
                AnyKey.performed += instance.OnAnyKey;
                AnyKey.canceled += instance.OnAnyKey;
                Test.started += instance.OnTest;
                Test.performed += instance.OnTest;
                Test.canceled += instance.OnTest;
                Touch.started += instance.OnTouch;
                Touch.performed += instance.OnTouch;
                Touch.canceled += instance.OnTouch;
            }
        }
    }
    public ActionsActions @Actions
    {
        get
        {
            return new ActionsActions(this);
        }
    }
    public interface IGamePlayActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnClimb(InputAction.CallbackContext context);
        void OnSkill1(InputAction.CallbackContext context);
        void OnSkill2(InputAction.CallbackContext context);
        void OnSkill3(InputAction.CallbackContext context);
        void OnSkill4(InputAction.CallbackContext context);
    }
    public interface IActionsActions
    {
        void OnAccept(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnAnyKey(InputAction.CallbackContext context);
        void OnTest(InputAction.CallbackContext context);
        void OnTouch(InputAction.CallbackContext context);
    }
}
