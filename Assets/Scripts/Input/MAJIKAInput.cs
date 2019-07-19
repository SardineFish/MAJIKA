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
                    ""id"": ""2e3528e4-7480-4819-994f-bb9986c5d2a8"",
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
                    ""id"": ""0640f412-c6e7-4f17-8342-f36966d39a6b"",
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
                    ""id"": ""ab782796-dd25-4b27-ab07-570cf51b7f00"",
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
                    ""id"": ""55524d30-bd31-4fa1-9389-d4be74bee9c4"",
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
                    ""id"": ""5725044f-4dfb-46f8-8a2b-25793c54e0e2"",
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
                    ""id"": ""3a399910-d70f-4e5d-af0d-2a6ddc853c02"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone(min=0.5,max=1)"",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""d978ba87-a212-4193-831d-21aafc922fb3"",
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
                    ""id"": ""79815092-d927-44a5-be97-c65193585031"",
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
                    ""id"": ""f66d461d-f7ef-4c40-afb7-173ff4ff67ad"",
                    ""path"": ""<Keyboard>/space"",
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
                    ""id"": ""6d71dbe4-5272-4343-bcad-d703c2bbfa6f"",
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
                    ""id"": ""e3138b61-42e7-4335-b5fd-47750b3a228c"",
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
                    ""id"": ""66bbbdbe-c1c3-4e27-83f4-d4441c7d145e"",
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
                    ""id"": ""e0da2007-5bca-4db7-94a0-b8c10e1c73b0"",
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
                    ""id"": ""0b269029-1faf-4c18-828b-75b28d11fbb2"",
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
                    ""id"": ""0f0361d9-01f9-42f1-ac41-88e98eb7c1d7"",
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
                    ""id"": ""cc7f6a3f-12c9-4bd8-a404-3ebfd97bb98c"",
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
                    ""id"": ""7aa4266d-fe6a-4891-8e9d-d7c323769543"",
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
                    ""id"": ""e9770bb1-fcae-44b5-a7b0-913a082c9b47"",
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
                    ""id"": ""860eb604-ed87-4ec5-9e63-1ccdd940ee2a"",
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
                    ""id"": ""d312e7ef-acec-419c-9520-1f9d2daf6b31"",
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
                    ""id"": ""acae354a-681a-43b6-9b46-934bbe217c03"",
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
                    ""id"": ""e5fa6ee9-720f-4cfe-9784-de54656a8877"",
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
                    ""id"": ""8c210dfb-5b51-4246-80b3-8a9f1319d310"",
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
                    ""id"": ""0440fd89-383f-4a9a-b1e0-3343db116e8f"",
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
                    ""id"": ""97fc71ed-fa57-438a-bb59-cb7f701c0c24"",
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
                    ""id"": ""9bc51cbd-162c-4542-b773-6b1cfea331da"",
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
                    ""id"": ""82739df9-a668-4d6e-bd87-fec79c74bdd1"",
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
                    ""id"": ""a5254ce6-ff70-4204-bb66-dbd90110fdfd"",
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