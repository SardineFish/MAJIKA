// GENERATED AUTOMATICALLY FROM 'Assets/Input 1/MAJIKAInput.inputactions'

using System;
using UnityEngine;
using UnityEngine.Experimental.Input;


[Serializable]
public class MAJIKAInput : InputActionAssetReference
{
    public MAJIKAInput()
    {
    }
    public MAJIKAInput(InputActionAsset asset)
        : base(asset)
    {
    }
    private bool m_Initialized;
    private void Initialize()
    {
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
        m_Actions_Newaction = m_Actions.GetAction("New action");
        m_Initialized = true;
    }
    private void Uninitialize()
    {
        if (m_GamePlayActionsCallbackInterface != null)
        {
            GamePlay.SetCallbacks(null);
        }
        m_GamePlay = null;
        m_GamePlay_Movement = null;
        m_GamePlay_Jump = null;
        m_GamePlay_Climb = null;
        m_GamePlay_Skill1 = null;
        m_GamePlay_Skill2 = null;
        m_GamePlay_Skill3 = null;
        m_GamePlay_Skill4 = null;
        if (m_ActionsActionsCallbackInterface != null)
        {
            Actions.SetCallbacks(null);
        }
        m_Actions = null;
        m_Actions_Accept = null;
        m_Actions_Back = null;
        m_Actions_Interact = null;
        m_Actions_Inventory = null;
        m_Actions_AnyKey = null;
        m_Actions_Newaction = null;
        m_Initialized = false;
    }
    public void SetAsset(InputActionAsset newAsset)
    {
        if (newAsset == asset) return;
        var GamePlayCallbacks = m_GamePlayActionsCallbackInterface;
        var ActionsCallbacks = m_ActionsActionsCallbackInterface;
        if (m_Initialized) Uninitialize();
        asset = newAsset;
        GamePlay.SetCallbacks(GamePlayCallbacks);
        Actions.SetCallbacks(ActionsCallbacks);
    }
    public override void MakePrivateCopyOfActions()
    {
        SetAsset(ScriptableObject.Instantiate(asset));
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
                Movement.cancelled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMovement;
                Jump.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJump;
                Jump.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJump;
                Jump.cancelled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJump;
                Climb.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnClimb;
                Climb.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnClimb;
                Climb.cancelled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnClimb;
                Skill1.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill1;
                Skill1.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill1;
                Skill1.cancelled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill1;
                Skill2.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill2;
                Skill2.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill2;
                Skill2.cancelled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill2;
                Skill3.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill3;
                Skill3.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill3;
                Skill3.cancelled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill3;
                Skill4.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill4;
                Skill4.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill4;
                Skill4.cancelled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSkill4;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                Movement.started += instance.OnMovement;
                Movement.performed += instance.OnMovement;
                Movement.cancelled += instance.OnMovement;
                Jump.started += instance.OnJump;
                Jump.performed += instance.OnJump;
                Jump.cancelled += instance.OnJump;
                Climb.started += instance.OnClimb;
                Climb.performed += instance.OnClimb;
                Climb.cancelled += instance.OnClimb;
                Skill1.started += instance.OnSkill1;
                Skill1.performed += instance.OnSkill1;
                Skill1.cancelled += instance.OnSkill1;
                Skill2.started += instance.OnSkill2;
                Skill2.performed += instance.OnSkill2;
                Skill2.cancelled += instance.OnSkill2;
                Skill3.started += instance.OnSkill3;
                Skill3.performed += instance.OnSkill3;
                Skill3.cancelled += instance.OnSkill3;
                Skill4.started += instance.OnSkill4;
                Skill4.performed += instance.OnSkill4;
                Skill4.cancelled += instance.OnSkill4;
            }
        }
    }
    public GamePlayActions @GamePlay
    {
        get
        {
            if (!m_Initialized) Initialize();
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
    private InputAction m_Actions_Newaction;
    public struct ActionsActions
    {
        private MAJIKAInput m_Wrapper;
        public ActionsActions(MAJIKAInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accept { get { return m_Wrapper.m_Actions_Accept; } }
        public InputAction @Back { get { return m_Wrapper.m_Actions_Back; } }
        public InputAction @Interact { get { return m_Wrapper.m_Actions_Interact; } }
        public InputAction @Inventory { get { return m_Wrapper.m_Actions_Inventory; } }
        public InputAction @AnyKey { get { return m_Wrapper.m_Actions_AnyKey; } }
        public InputAction @Newaction { get { return m_Wrapper.m_Actions_Newaction; } }
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
                Accept.cancelled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnAccept;
                Back.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnBack;
                Back.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnBack;
                Back.cancelled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnBack;
                Interact.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnInteract;
                Interact.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnInteract;
                Interact.cancelled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnInteract;
                Inventory.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnInventory;
                Inventory.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnInventory;
                Inventory.cancelled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnInventory;
                AnyKey.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnAnyKey;
                AnyKey.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnAnyKey;
                AnyKey.cancelled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnAnyKey;
                Newaction.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnNewaction;
                Newaction.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnNewaction;
                Newaction.cancelled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_ActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                Accept.started += instance.OnAccept;
                Accept.performed += instance.OnAccept;
                Accept.cancelled += instance.OnAccept;
                Back.started += instance.OnBack;
                Back.performed += instance.OnBack;
                Back.cancelled += instance.OnBack;
                Interact.started += instance.OnInteract;
                Interact.performed += instance.OnInteract;
                Interact.cancelled += instance.OnInteract;
                Inventory.started += instance.OnInventory;
                Inventory.performed += instance.OnInventory;
                Inventory.cancelled += instance.OnInventory;
                AnyKey.started += instance.OnAnyKey;
                AnyKey.performed += instance.OnAnyKey;
                AnyKey.cancelled += instance.OnAnyKey;
                Newaction.started += instance.OnNewaction;
                Newaction.performed += instance.OnNewaction;
                Newaction.cancelled += instance.OnNewaction;
            }
        }
    }
    public ActionsActions @Actions
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new ActionsActions(this);
        }
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
    void OnNewaction(InputAction.CallbackContext context);
}
