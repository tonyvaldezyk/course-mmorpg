//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/Demos/Pong/Input/PongInput.inputactions
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

public partial class @PongInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PongInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PongInput"",
    ""maps"": [
        {
            ""name"": ""Pong"",
            ""id"": ""2853b04f-7024-4814-be62-a7ef11b8c788"",
            ""actions"": [
                {
                    ""name"": ""Player1"",
                    ""type"": ""Value"",
                    ""id"": ""dd23fde7-0eaf-43aa-b607-f11683ce08fe"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Player2"",
                    ""type"": ""Value"",
                    ""id"": ""7c41fe3a-4dac-42e0-b176-d49cb46b7750"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""035cb7d4-2afe-4581-bc41-f5b73ee5a544"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e640ae55-ab20-4bd3-90d8-1124f55a54bc"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""12f85581-cbe3-4005-b1e7-64bbe5440c8b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""dd763d6c-4175-4382-8fdf-ecc6215a7a73"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ebf65d96-52fc-470c-b98a-dc9d65911499"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9d29f5a2-eae7-47b9-b2bc-dd20c8be92e1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Pong
        m_Pong = asset.FindActionMap("Pong", throwIfNotFound: true);
        m_Pong_Player1 = m_Pong.FindAction("Player1", throwIfNotFound: true);
        m_Pong_Player2 = m_Pong.FindAction("Player2", throwIfNotFound: true);
    }

    ~@PongInput()
    {
        UnityEngine.Debug.Assert(!m_Pong.enabled, "This will cause a leak and performance issues, PongInput.Pong.Disable() has not been called.");
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

    // Pong
    private readonly InputActionMap m_Pong;
    private List<IPongActions> m_PongActionsCallbackInterfaces = new List<IPongActions>();
    private readonly InputAction m_Pong_Player1;
    private readonly InputAction m_Pong_Player2;
    public struct PongActions
    {
        private @PongInput m_Wrapper;
        public PongActions(@PongInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Player1 => m_Wrapper.m_Pong_Player1;
        public InputAction @Player2 => m_Wrapper.m_Pong_Player2;
        public InputActionMap Get() { return m_Wrapper.m_Pong; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PongActions set) { return set.Get(); }
        public void AddCallbacks(IPongActions instance)
        {
            if (instance == null || m_Wrapper.m_PongActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PongActionsCallbackInterfaces.Add(instance);
            @Player1.started += instance.OnPlayer1;
            @Player1.performed += instance.OnPlayer1;
            @Player1.canceled += instance.OnPlayer1;
            @Player2.started += instance.OnPlayer2;
            @Player2.performed += instance.OnPlayer2;
            @Player2.canceled += instance.OnPlayer2;
        }

        private void UnregisterCallbacks(IPongActions instance)
        {
            @Player1.started -= instance.OnPlayer1;
            @Player1.performed -= instance.OnPlayer1;
            @Player1.canceled -= instance.OnPlayer1;
            @Player2.started -= instance.OnPlayer2;
            @Player2.performed -= instance.OnPlayer2;
            @Player2.canceled -= instance.OnPlayer2;
        }

        public void RemoveCallbacks(IPongActions instance)
        {
            if (m_Wrapper.m_PongActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPongActions instance)
        {
            foreach (var item in m_Wrapper.m_PongActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PongActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PongActions @Pong => new PongActions(this);
    public interface IPongActions
    {
        void OnPlayer1(InputAction.CallbackContext context);
        void OnPlayer2(InputAction.CallbackContext context);
    }
}
