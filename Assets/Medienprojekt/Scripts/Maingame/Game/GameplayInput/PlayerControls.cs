// GENERATED AUTOMATICALLY FROM 'Assets/Medienprojekt/Scripts/Game/GameplayInput/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""63472f68-f357-4e83-a656-2a8a7d4c54fd"",
            ""actions"": [
                {
                    ""name"": ""XSmash"",
                    ""type"": ""Value"",
                    ""id"": ""4d95c747-9d57-4394-80de-75a79cf6d9cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ASmash"",
                    ""type"": ""Button"",
                    ""id"": ""e1f8375e-0d93-445c-8e0e-cb0a9d814fc5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BSmash"",
                    ""type"": ""Button"",
                    ""id"": ""c9198d69-cab4-4d00-a1e5-109dc5c90d5e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""YSmash"",
                    ""type"": ""Button"",
                    ""id"": ""49ea8200-77d9-41e1-b81e-42d13fe4b217"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""c2b3e477-7da1-41e6-b204-49a5a910fcc4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""46887a77-db80-47f7-a5d4-912a9cb530a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Oben"",
                    ""type"": ""Button"",
                    ""id"": ""d04e3cfc-03ec-452a-ab5f-135d54848958"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Unten"",
                    ""type"": ""Button"",
                    ""id"": ""ddf901c6-9e3e-4a81-a015-22dc458f7964"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Links"",
                    ""type"": ""Button"",
                    ""id"": ""4afffcb4-8e32-42c7-a052-93388a4423b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rechts"",
                    ""type"": ""Button"",
                    ""id"": ""c4dd3fc2-a989-4bc4-bfb3-5cb8b64ed061"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bae44542-31f1-4dcf-958c-0f2a7824cb7c"",
                    ""path"": ""<HID::usb gamepad           >/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""XSmash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba28115d-2bbd-4e9a-976b-1e0d3a8d0fcb"",
                    ""path"": ""<HID::usb gamepad           >/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ASmash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2404aef0-15e6-4834-9e8a-4f7293aadd5f"",
                    ""path"": ""<HID::usb gamepad           >/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BSmash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c53d4729-dae0-4565-9a38-e606f5329036"",
                    ""path"": ""<HID::usb gamepad           >/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""YSmash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""590727e8-04e9-4740-89a0-9872c234d348"",
                    ""path"": ""<HID::usb gamepad           >/button10"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1f5c2de-0b4d-4db9-bdba-5bb0c9f27357"",
                    ""path"": ""<HID::usb gamepad           >/button9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ccfba7c-ee99-4702-a372-b0ce74e9c638"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Oben"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8cbf27b3-a84b-4844-a40a-62d0d1a4059f"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Unten"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a80d2ef9-56e6-4f19-8196-9216807d1346"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Links"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""620ae599-f1bd-43cb-93cf-b62bcd2b6a4c"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rechts"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_XSmash = m_Gameplay.FindAction("XSmash", throwIfNotFound: true);
        m_Gameplay_ASmash = m_Gameplay.FindAction("ASmash", throwIfNotFound: true);
        m_Gameplay_BSmash = m_Gameplay.FindAction("BSmash", throwIfNotFound: true);
        m_Gameplay_YSmash = m_Gameplay.FindAction("YSmash", throwIfNotFound: true);
        m_Gameplay_Start = m_Gameplay.FindAction("Start", throwIfNotFound: true);
        m_Gameplay_Select = m_Gameplay.FindAction("Select", throwIfNotFound: true);
        m_Gameplay_Oben = m_Gameplay.FindAction("Oben", throwIfNotFound: true);
        m_Gameplay_Unten = m_Gameplay.FindAction("Unten", throwIfNotFound: true);
        m_Gameplay_Links = m_Gameplay.FindAction("Links", throwIfNotFound: true);
        m_Gameplay_Rechts = m_Gameplay.FindAction("Rechts", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_XSmash;
    private readonly InputAction m_Gameplay_ASmash;
    private readonly InputAction m_Gameplay_BSmash;
    private readonly InputAction m_Gameplay_YSmash;
    private readonly InputAction m_Gameplay_Start;
    private readonly InputAction m_Gameplay_Select;
    private readonly InputAction m_Gameplay_Oben;
    private readonly InputAction m_Gameplay_Unten;
    private readonly InputAction m_Gameplay_Links;
    private readonly InputAction m_Gameplay_Rechts;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @XSmash => m_Wrapper.m_Gameplay_XSmash;
        public InputAction @ASmash => m_Wrapper.m_Gameplay_ASmash;
        public InputAction @BSmash => m_Wrapper.m_Gameplay_BSmash;
        public InputAction @YSmash => m_Wrapper.m_Gameplay_YSmash;
        public InputAction @Start => m_Wrapper.m_Gameplay_Start;
        public InputAction @Select => m_Wrapper.m_Gameplay_Select;
        public InputAction @Oben => m_Wrapper.m_Gameplay_Oben;
        public InputAction @Unten => m_Wrapper.m_Gameplay_Unten;
        public InputAction @Links => m_Wrapper.m_Gameplay_Links;
        public InputAction @Rechts => m_Wrapper.m_Gameplay_Rechts;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @XSmash.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnXSmash;
                @XSmash.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnXSmash;
                @XSmash.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnXSmash;
                @ASmash.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnASmash;
                @ASmash.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnASmash;
                @ASmash.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnASmash;
                @BSmash.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBSmash;
                @BSmash.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBSmash;
                @BSmash.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBSmash;
                @YSmash.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnYSmash;
                @YSmash.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnYSmash;
                @YSmash.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnYSmash;
                @Start.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStart;
                @Select.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSelect;
                @Oben.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOben;
                @Oben.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOben;
                @Oben.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOben;
                @Unten.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUnten;
                @Unten.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUnten;
                @Unten.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUnten;
                @Links.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLinks;
                @Links.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLinks;
                @Links.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLinks;
                @Rechts.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRechts;
                @Rechts.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRechts;
                @Rechts.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRechts;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @XSmash.started += instance.OnXSmash;
                @XSmash.performed += instance.OnXSmash;
                @XSmash.canceled += instance.OnXSmash;
                @ASmash.started += instance.OnASmash;
                @ASmash.performed += instance.OnASmash;
                @ASmash.canceled += instance.OnASmash;
                @BSmash.started += instance.OnBSmash;
                @BSmash.performed += instance.OnBSmash;
                @BSmash.canceled += instance.OnBSmash;
                @YSmash.started += instance.OnYSmash;
                @YSmash.performed += instance.OnYSmash;
                @YSmash.canceled += instance.OnYSmash;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Oben.started += instance.OnOben;
                @Oben.performed += instance.OnOben;
                @Oben.canceled += instance.OnOben;
                @Unten.started += instance.OnUnten;
                @Unten.performed += instance.OnUnten;
                @Unten.canceled += instance.OnUnten;
                @Links.started += instance.OnLinks;
                @Links.performed += instance.OnLinks;
                @Links.canceled += instance.OnLinks;
                @Rechts.started += instance.OnRechts;
                @Rechts.performed += instance.OnRechts;
                @Rechts.canceled += instance.OnRechts;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnXSmash(InputAction.CallbackContext context);
        void OnASmash(InputAction.CallbackContext context);
        void OnBSmash(InputAction.CallbackContext context);
        void OnYSmash(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnOben(InputAction.CallbackContext context);
        void OnUnten(InputAction.CallbackContext context);
        void OnLinks(InputAction.CallbackContext context);
        void OnRechts(InputAction.CallbackContext context);
    }
}
