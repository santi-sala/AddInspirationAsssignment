//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/PlayerInputs/PlayerInputs.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""a08d9760-32ea-45b8-b870-0bf484dc0b79"",
            ""actions"": [
                {
                    ""name"": ""TouchInput"",
                    ""type"": ""PassThrough"",
                    ""id"": ""56ed611e-5b9c-483f-a3ea-78e0a886d2e0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TouchTap"",
                    ""type"": ""Button"",
                    ""id"": ""f53cd958-d8a3-4c7b-b4eb-55aab8dafda6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TouchPress"",
                    ""type"": ""Button"",
                    ""id"": ""e59b319e-19eb-4cbf-bf7d-15bf5101726b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TouchHold"",
                    ""type"": ""Button"",
                    ""id"": ""40e9c8bc-8b82-4035-b105-d04c23d15dc9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TouchPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ee8f3c3b-9c71-410a-95ae-47bd9b68d830"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1c9786bc-f130-4f4e-86a6-54eb039590ab"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d99bbdf1-e050-4d5e-856a-b9207cf6ff37"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchTap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5cd21da-c2cf-4ecb-83b7-1fd1c6c8b043"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""737ff110-9e2f-41de-9f22-1daa37c814ff"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchHold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d47aa83-7477-478a-babf-5cd9ed7da04c"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_TouchInput = m_Player.FindAction("TouchInput", throwIfNotFound: true);
        m_Player_TouchTap = m_Player.FindAction("TouchTap", throwIfNotFound: true);
        m_Player_TouchPress = m_Player.FindAction("TouchPress", throwIfNotFound: true);
        m_Player_TouchHold = m_Player.FindAction("TouchHold", throwIfNotFound: true);
        m_Player_TouchPosition = m_Player.FindAction("TouchPosition", throwIfNotFound: true);
    }

    public void Dispose()
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

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_TouchInput;
    private readonly InputAction m_Player_TouchTap;
    private readonly InputAction m_Player_TouchPress;
    private readonly InputAction m_Player_TouchHold;
    private readonly InputAction m_Player_TouchPosition;
    public struct PlayerActions
    {
        private @PlayerInputs m_Wrapper;
        public PlayerActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @TouchInput => m_Wrapper.m_Player_TouchInput;
        public InputAction @TouchTap => m_Wrapper.m_Player_TouchTap;
        public InputAction @TouchPress => m_Wrapper.m_Player_TouchPress;
        public InputAction @TouchHold => m_Wrapper.m_Player_TouchHold;
        public InputAction @TouchPosition => m_Wrapper.m_Player_TouchPosition;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @TouchInput.started += instance.OnTouchInput;
            @TouchInput.performed += instance.OnTouchInput;
            @TouchInput.canceled += instance.OnTouchInput;
            @TouchTap.started += instance.OnTouchTap;
            @TouchTap.performed += instance.OnTouchTap;
            @TouchTap.canceled += instance.OnTouchTap;
            @TouchPress.started += instance.OnTouchPress;
            @TouchPress.performed += instance.OnTouchPress;
            @TouchPress.canceled += instance.OnTouchPress;
            @TouchHold.started += instance.OnTouchHold;
            @TouchHold.performed += instance.OnTouchHold;
            @TouchHold.canceled += instance.OnTouchHold;
            @TouchPosition.started += instance.OnTouchPosition;
            @TouchPosition.performed += instance.OnTouchPosition;
            @TouchPosition.canceled += instance.OnTouchPosition;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @TouchInput.started -= instance.OnTouchInput;
            @TouchInput.performed -= instance.OnTouchInput;
            @TouchInput.canceled -= instance.OnTouchInput;
            @TouchTap.started -= instance.OnTouchTap;
            @TouchTap.performed -= instance.OnTouchTap;
            @TouchTap.canceled -= instance.OnTouchTap;
            @TouchPress.started -= instance.OnTouchPress;
            @TouchPress.performed -= instance.OnTouchPress;
            @TouchPress.canceled -= instance.OnTouchPress;
            @TouchHold.started -= instance.OnTouchHold;
            @TouchHold.performed -= instance.OnTouchHold;
            @TouchHold.canceled -= instance.OnTouchHold;
            @TouchPosition.started -= instance.OnTouchPosition;
            @TouchPosition.performed -= instance.OnTouchPosition;
            @TouchPosition.canceled -= instance.OnTouchPosition;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnTouchInput(InputAction.CallbackContext context);
        void OnTouchTap(InputAction.CallbackContext context);
        void OnTouchPress(InputAction.CallbackContext context);
        void OnTouchHold(InputAction.CallbackContext context);
        void OnTouchPosition(InputAction.CallbackContext context);
    }
}
