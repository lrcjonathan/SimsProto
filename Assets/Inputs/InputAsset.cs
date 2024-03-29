//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Inputs/InputAsset.inputactions
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

public partial class @InputAsset: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputAsset()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputAsset"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""570bed27-c7d0-4b7f-b447-076dd31bb8fc"",
            ""actions"": [
                {
                    ""name"": ""MouseLeftButton"",
                    ""type"": ""Button"",
                    ""id"": ""2e82e19f-0667-4e16-9ec3-3db449cf6563"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseRightButton"",
                    ""type"": ""Button"",
                    ""id"": ""ae54d909-5282-4325-bbf8-4f500f487ab8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseDeltaX"",
                    ""type"": ""Value"",
                    ""id"": ""8252d482-7289-4cc9-b295-f41991bbb47d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MouseDeltaY"",
                    ""type"": ""Value"",
                    ""id"": ""34362869-9b56-4d05-b1a3-d47b8c8c9eb7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""45f20cee-7d0b-4bda-bcf4-87b3b754dbc3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""OpenShop"",
                    ""type"": ""Button"",
                    ""id"": ""b6f2e580-d5ff-4d36-92a6-e516c5904f76"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""fa951ed2-32e2-4f32-a722-eb23bea8dbcd"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""9893a508-30d1-486f-af22-e29ec1feaa44"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bffdf564-4623-4273-8dac-41651351f38a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseLeftButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4283703-0fae-4cda-8312-47f1229556d3"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseRightButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""933fdab2-ff5d-492e-b405-63a617bf9f27"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseDeltaX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21797f55-8f56-49fe-bb82-b077a143d6d1"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseDeltaY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8777162-3d39-4478-8ae4-c73a0826c4fc"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e15c6e59-b54b-4c85-a7a9-1f5cc678cad2"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenShop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82a1ef2f-a500-4499-8698-eecb2f051674"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2d5921b-98f2-42f4-b133-32506c0a323c"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_MouseLeftButton = m_Main.FindAction("MouseLeftButton", throwIfNotFound: true);
        m_Main_MouseRightButton = m_Main.FindAction("MouseRightButton", throwIfNotFound: true);
        m_Main_MouseDeltaX = m_Main.FindAction("MouseDeltaX", throwIfNotFound: true);
        m_Main_MouseDeltaY = m_Main.FindAction("MouseDeltaY", throwIfNotFound: true);
        m_Main_MousePosition = m_Main.FindAction("MousePosition", throwIfNotFound: true);
        m_Main_OpenShop = m_Main.FindAction("OpenShop", throwIfNotFound: true);
        m_Main_Zoom = m_Main.FindAction("Zoom", throwIfNotFound: true);
        m_Main_Escape = m_Main.FindAction("Escape", throwIfNotFound: true);
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

    // Main
    private readonly InputActionMap m_Main;
    private List<IMainActions> m_MainActionsCallbackInterfaces = new List<IMainActions>();
    private readonly InputAction m_Main_MouseLeftButton;
    private readonly InputAction m_Main_MouseRightButton;
    private readonly InputAction m_Main_MouseDeltaX;
    private readonly InputAction m_Main_MouseDeltaY;
    private readonly InputAction m_Main_MousePosition;
    private readonly InputAction m_Main_OpenShop;
    private readonly InputAction m_Main_Zoom;
    private readonly InputAction m_Main_Escape;
    public struct MainActions
    {
        private @InputAsset m_Wrapper;
        public MainActions(@InputAsset wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseLeftButton => m_Wrapper.m_Main_MouseLeftButton;
        public InputAction @MouseRightButton => m_Wrapper.m_Main_MouseRightButton;
        public InputAction @MouseDeltaX => m_Wrapper.m_Main_MouseDeltaX;
        public InputAction @MouseDeltaY => m_Wrapper.m_Main_MouseDeltaY;
        public InputAction @MousePosition => m_Wrapper.m_Main_MousePosition;
        public InputAction @OpenShop => m_Wrapper.m_Main_OpenShop;
        public InputAction @Zoom => m_Wrapper.m_Main_Zoom;
        public InputAction @Escape => m_Wrapper.m_Main_Escape;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void AddCallbacks(IMainActions instance)
        {
            if (instance == null || m_Wrapper.m_MainActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MainActionsCallbackInterfaces.Add(instance);
            @MouseLeftButton.started += instance.OnMouseLeftButton;
            @MouseLeftButton.performed += instance.OnMouseLeftButton;
            @MouseLeftButton.canceled += instance.OnMouseLeftButton;
            @MouseRightButton.started += instance.OnMouseRightButton;
            @MouseRightButton.performed += instance.OnMouseRightButton;
            @MouseRightButton.canceled += instance.OnMouseRightButton;
            @MouseDeltaX.started += instance.OnMouseDeltaX;
            @MouseDeltaX.performed += instance.OnMouseDeltaX;
            @MouseDeltaX.canceled += instance.OnMouseDeltaX;
            @MouseDeltaY.started += instance.OnMouseDeltaY;
            @MouseDeltaY.performed += instance.OnMouseDeltaY;
            @MouseDeltaY.canceled += instance.OnMouseDeltaY;
            @MousePosition.started += instance.OnMousePosition;
            @MousePosition.performed += instance.OnMousePosition;
            @MousePosition.canceled += instance.OnMousePosition;
            @OpenShop.started += instance.OnOpenShop;
            @OpenShop.performed += instance.OnOpenShop;
            @OpenShop.canceled += instance.OnOpenShop;
            @Zoom.started += instance.OnZoom;
            @Zoom.performed += instance.OnZoom;
            @Zoom.canceled += instance.OnZoom;
            @Escape.started += instance.OnEscape;
            @Escape.performed += instance.OnEscape;
            @Escape.canceled += instance.OnEscape;
        }

        private void UnregisterCallbacks(IMainActions instance)
        {
            @MouseLeftButton.started -= instance.OnMouseLeftButton;
            @MouseLeftButton.performed -= instance.OnMouseLeftButton;
            @MouseLeftButton.canceled -= instance.OnMouseLeftButton;
            @MouseRightButton.started -= instance.OnMouseRightButton;
            @MouseRightButton.performed -= instance.OnMouseRightButton;
            @MouseRightButton.canceled -= instance.OnMouseRightButton;
            @MouseDeltaX.started -= instance.OnMouseDeltaX;
            @MouseDeltaX.performed -= instance.OnMouseDeltaX;
            @MouseDeltaX.canceled -= instance.OnMouseDeltaX;
            @MouseDeltaY.started -= instance.OnMouseDeltaY;
            @MouseDeltaY.performed -= instance.OnMouseDeltaY;
            @MouseDeltaY.canceled -= instance.OnMouseDeltaY;
            @MousePosition.started -= instance.OnMousePosition;
            @MousePosition.performed -= instance.OnMousePosition;
            @MousePosition.canceled -= instance.OnMousePosition;
            @OpenShop.started -= instance.OnOpenShop;
            @OpenShop.performed -= instance.OnOpenShop;
            @OpenShop.canceled -= instance.OnOpenShop;
            @Zoom.started -= instance.OnZoom;
            @Zoom.performed -= instance.OnZoom;
            @Zoom.canceled -= instance.OnZoom;
            @Escape.started -= instance.OnEscape;
            @Escape.performed -= instance.OnEscape;
            @Escape.canceled -= instance.OnEscape;
        }

        public void RemoveCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMainActions instance)
        {
            foreach (var item in m_Wrapper.m_MainActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MainActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MainActions @Main => new MainActions(this);
    public interface IMainActions
    {
        void OnMouseLeftButton(InputAction.CallbackContext context);
        void OnMouseRightButton(InputAction.CallbackContext context);
        void OnMouseDeltaX(InputAction.CallbackContext context);
        void OnMouseDeltaY(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnOpenShop(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
    }
}
