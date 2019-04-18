// GENERATED AUTOMATICALLY FROM 'Assets/Others/MAJIKAInput.inputactions'

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
        m_Initialized = false;
    }
    public void SetAsset(InputActionAsset newAsset)
    {
        if (newAsset == asset) return;
        var GamePlayCallbacks = m_GamePlayActionsCallbackInterface;
        if (m_Initialized) Uninitialize();
        asset = newAsset;
        GamePlay.SetCallbacks(GamePlayCallbacks);
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
