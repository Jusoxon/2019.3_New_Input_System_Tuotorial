// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

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
            ""name"": ""GamePlay"",
            ""id"": ""342f4d15-5d58-402a-8906-647bc4f0aed8"",
            ""actions"": [
                {
                    ""name"": ""Check"",
                    ""type"": ""Button"",
                    ""id"": ""4fbc094f-a98d-42ec-a494-31f61d08120b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""a29813c8-44d9-415f-9416-d162daeb9c6d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""fe04c3ca-9c95-4b74-9f7a-f7d6b584f32a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateCam"",
                    ""type"": ""Button"",
                    ""id"": ""d41592ef-d4b2-4c64-a7e8-97fa3a544db5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Triangle"",
                    ""type"": ""Button"",
                    ""id"": ""eef1b245-ddbf-4965-a3e9-590914fb55a7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Square"",
                    ""type"": ""Button"",
                    ""id"": ""129dc5e6-e50d-4f6d-8db2-0f1b529c9333"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""D_Right"",
                    ""type"": ""Button"",
                    ""id"": ""bcfb12e2-6fca-4004-aed6-ed526a08af21"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""D_Left"",
                    ""type"": ""Button"",
                    ""id"": ""31243d2b-0d41-437f-b5c0-20b130f3ee9d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""D_Up"",
                    ""type"": ""Button"",
                    ""id"": ""235259ef-f318-4588-bde4-17b7a156a7d0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""D_Down"",
                    ""type"": ""Button"",
                    ""id"": ""e011a0b4-0558-446b-9274-bb445f89be42"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L1"",
                    ""type"": ""Button"",
                    ""id"": ""119f16a1-2f69-4c6d-abe4-b7a15da7988c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L2"",
                    ""type"": ""Button"",
                    ""id"": ""90554617-468f-446a-b0be-f1b4f94ff4f1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R1"",
                    ""type"": ""Button"",
                    ""id"": ""ac87d02f-70fe-47a9-8864-d4180097f8fc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R2"",
                    ""type"": ""Button"",
                    ""id"": ""7cabb238-b07f-4164-bddc-36350ce44049"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Option"",
                    ""type"": ""Button"",
                    ""id"": ""26a077bd-3fa3-4f3b-a107-bc18e8f2d0db"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TouchPad"",
                    ""type"": ""Button"",
                    ""id"": ""cebef75f-61ad-4cdf-90ed-49afdb6d9d54"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8da1dc04-9aa5-4dbd-894b-2749c2a45789"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Check"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf2d2cb7-e928-4316-9e04-e6f370ba0a98"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dab4ae64-8444-468b-9d2a-9efbd08969fe"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd166ace-d549-476f-83f6-0d670d6d20d8"",
                    ""path"": ""<DualShockGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a80bf637-ff93-4e03-8f49-f8808bb0cbb6"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Triangle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e78a6ca-f57e-4735-9d1c-90058de5e1f7"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Square"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ffefb33-9f7c-423f-a565-a7024a6eef95"",
                    ""path"": ""<DualShockGamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""949886c3-355e-4923-b1c7-3c6edb2598cf"",
                    ""path"": ""<DualShockGamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""202d16a3-52cc-4aae-b4bc-e638011005c6"",
                    ""path"": ""<DualShockGamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D_Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c322ce0f-a78c-47ac-a17c-f2aa4651e29a"",
                    ""path"": ""<DualShockGamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D_Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19593eca-a4c1-4613-8c4b-9f9e8104a362"",
                    ""path"": ""<DualShockGamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b920e5d8-8a21-41f6-a3d5-1e191bb264c8"",
                    ""path"": ""<DualShockGamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""095127f2-59ce-40d7-ab04-8c4ab240f46b"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09c7686e-e43f-42ba-ada5-7af375c2e1a1"",
                    ""path"": ""<DualShockGamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e227ee05-e9cd-43ad-bd6a-dd973ee5ce3f"",
                    ""path"": ""<DualShockGamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Option"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62838fee-d7b2-40da-bc15-f774b53d10b8"",
                    ""path"": ""<DualShockGamepad>/touchpadButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchPad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""OptionMode"",
            ""id"": ""cda51e91-8701-4389-a17a-023ce8ca8a5c"",
            ""actions"": [
                {
                    ""name"": ""L1"",
                    ""type"": ""Button"",
                    ""id"": ""3fb09296-2aa8-4028-8f70-745ef0a00fdf"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R1"",
                    ""type"": ""Button"",
                    ""id"": ""644b7f88-af7b-4e3a-9166-b555a9a4e18a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Circle"",
                    ""type"": ""Button"",
                    ""id"": ""f58aa6e1-d146-4b65-8caa-9f9f0ea06abc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cross"",
                    ""type"": ""Button"",
                    ""id"": ""ebf75bd3-f88a-4896-954d-564379182c28"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Square"",
                    ""type"": ""Button"",
                    ""id"": ""4bb91855-a816-4dca-9296-64357b84acac"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Triangle"",
                    ""type"": ""Button"",
                    ""id"": ""c2b7fc2e-8dc1-4967-a167-9741a7e71719"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LStick"",
                    ""type"": ""Button"",
                    ""id"": ""6bc70551-5dc8-455f-9f5a-f8e9b8aa53fe"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RStick"",
                    ""type"": ""Button"",
                    ""id"": ""b6f0b45f-e7b2-4d6b-bcad-36fb0d455525"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Option"",
                    ""type"": ""Button"",
                    ""id"": ""5b90e188-fb73-4ee7-846b-191ec13514d1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9032c222-cd14-434f-bdff-7caa8163e5e0"",
                    ""path"": ""<DualShockGamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""496243c0-ea3b-4457-a4da-591fd1e95a7d"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c620110-45e3-4de1-bc97-d7c29dc06c4f"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Circle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""743b6e1a-c413-4949-ab64-1b645e54e79e"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cross"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30d35d94-5927-46a3-9d84-3926d380052f"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Square"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d858224d-5634-456d-8698-50098292648e"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Triangle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9165e048-1e05-4380-b0e2-13f6e4dd95d5"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7422d28b-ec98-4970-a776-21ef138de775"",
                    ""path"": ""<DualShockGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f30ce69-ca5d-4645-a339-eccaf8a56014"",
                    ""path"": ""<DualShockGamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Option"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_Check = m_GamePlay.FindAction("Check", throwIfNotFound: true);
        m_GamePlay_Cancel = m_GamePlay.FindAction("Cancel", throwIfNotFound: true);
        m_GamePlay_Move = m_GamePlay.FindAction("Move", throwIfNotFound: true);
        m_GamePlay_RotateCam = m_GamePlay.FindAction("RotateCam", throwIfNotFound: true);
        m_GamePlay_Triangle = m_GamePlay.FindAction("Triangle", throwIfNotFound: true);
        m_GamePlay_Square = m_GamePlay.FindAction("Square", throwIfNotFound: true);
        m_GamePlay_D_Right = m_GamePlay.FindAction("D_Right", throwIfNotFound: true);
        m_GamePlay_D_Left = m_GamePlay.FindAction("D_Left", throwIfNotFound: true);
        m_GamePlay_D_Up = m_GamePlay.FindAction("D_Up", throwIfNotFound: true);
        m_GamePlay_D_Down = m_GamePlay.FindAction("D_Down", throwIfNotFound: true);
        m_GamePlay_L1 = m_GamePlay.FindAction("L1", throwIfNotFound: true);
        m_GamePlay_L2 = m_GamePlay.FindAction("L2", throwIfNotFound: true);
        m_GamePlay_R1 = m_GamePlay.FindAction("R1", throwIfNotFound: true);
        m_GamePlay_R2 = m_GamePlay.FindAction("R2", throwIfNotFound: true);
        m_GamePlay_Option = m_GamePlay.FindAction("Option", throwIfNotFound: true);
        m_GamePlay_TouchPad = m_GamePlay.FindAction("TouchPad", throwIfNotFound: true);
        // OptionMode
        m_OptionMode = asset.FindActionMap("OptionMode", throwIfNotFound: true);
        m_OptionMode_L1 = m_OptionMode.FindAction("L1", throwIfNotFound: true);
        m_OptionMode_R1 = m_OptionMode.FindAction("R1", throwIfNotFound: true);
        m_OptionMode_Circle = m_OptionMode.FindAction("Circle", throwIfNotFound: true);
        m_OptionMode_Cross = m_OptionMode.FindAction("Cross", throwIfNotFound: true);
        m_OptionMode_Square = m_OptionMode.FindAction("Square", throwIfNotFound: true);
        m_OptionMode_Triangle = m_OptionMode.FindAction("Triangle", throwIfNotFound: true);
        m_OptionMode_LStick = m_OptionMode.FindAction("LStick", throwIfNotFound: true);
        m_OptionMode_RStick = m_OptionMode.FindAction("RStick", throwIfNotFound: true);
        m_OptionMode_Option = m_OptionMode.FindAction("Option", throwIfNotFound: true);
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

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_GamePlay_Check;
    private readonly InputAction m_GamePlay_Cancel;
    private readonly InputAction m_GamePlay_Move;
    private readonly InputAction m_GamePlay_RotateCam;
    private readonly InputAction m_GamePlay_Triangle;
    private readonly InputAction m_GamePlay_Square;
    private readonly InputAction m_GamePlay_D_Right;
    private readonly InputAction m_GamePlay_D_Left;
    private readonly InputAction m_GamePlay_D_Up;
    private readonly InputAction m_GamePlay_D_Down;
    private readonly InputAction m_GamePlay_L1;
    private readonly InputAction m_GamePlay_L2;
    private readonly InputAction m_GamePlay_R1;
    private readonly InputAction m_GamePlay_R2;
    private readonly InputAction m_GamePlay_Option;
    private readonly InputAction m_GamePlay_TouchPad;
    public struct GamePlayActions
    {
        private @PlayerControls m_Wrapper;
        public GamePlayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Check => m_Wrapper.m_GamePlay_Check;
        public InputAction @Cancel => m_Wrapper.m_GamePlay_Cancel;
        public InputAction @Move => m_Wrapper.m_GamePlay_Move;
        public InputAction @RotateCam => m_Wrapper.m_GamePlay_RotateCam;
        public InputAction @Triangle => m_Wrapper.m_GamePlay_Triangle;
        public InputAction @Square => m_Wrapper.m_GamePlay_Square;
        public InputAction @D_Right => m_Wrapper.m_GamePlay_D_Right;
        public InputAction @D_Left => m_Wrapper.m_GamePlay_D_Left;
        public InputAction @D_Up => m_Wrapper.m_GamePlay_D_Up;
        public InputAction @D_Down => m_Wrapper.m_GamePlay_D_Down;
        public InputAction @L1 => m_Wrapper.m_GamePlay_L1;
        public InputAction @L2 => m_Wrapper.m_GamePlay_L2;
        public InputAction @R1 => m_Wrapper.m_GamePlay_R1;
        public InputAction @R2 => m_Wrapper.m_GamePlay_R2;
        public InputAction @Option => m_Wrapper.m_GamePlay_Option;
        public InputAction @TouchPad => m_Wrapper.m_GamePlay_TouchPad;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @Check.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCheck;
                @Check.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCheck;
                @Check.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCheck;
                @Cancel.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCancel;
                @Move.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMove;
                @RotateCam.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRotateCam;
                @RotateCam.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRotateCam;
                @RotateCam.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRotateCam;
                @Triangle.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTriangle;
                @Triangle.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTriangle;
                @Triangle.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTriangle;
                @Square.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSquare;
                @Square.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSquare;
                @Square.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSquare;
                @D_Right.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnD_Right;
                @D_Right.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnD_Right;
                @D_Right.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnD_Right;
                @D_Left.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnD_Left;
                @D_Left.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnD_Left;
                @D_Left.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnD_Left;
                @D_Up.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnD_Up;
                @D_Up.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnD_Up;
                @D_Up.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnD_Up;
                @D_Down.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnD_Down;
                @D_Down.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnD_Down;
                @D_Down.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnD_Down;
                @L1.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnL1;
                @L1.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnL1;
                @L1.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnL1;
                @L2.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnL2;
                @L2.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnL2;
                @L2.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnL2;
                @R1.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnR1;
                @R1.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnR1;
                @R1.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnR1;
                @R2.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnR2;
                @R2.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnR2;
                @R2.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnR2;
                @Option.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnOption;
                @Option.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnOption;
                @Option.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnOption;
                @TouchPad.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTouchPad;
                @TouchPad.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTouchPad;
                @TouchPad.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTouchPad;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Check.started += instance.OnCheck;
                @Check.performed += instance.OnCheck;
                @Check.canceled += instance.OnCheck;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @RotateCam.started += instance.OnRotateCam;
                @RotateCam.performed += instance.OnRotateCam;
                @RotateCam.canceled += instance.OnRotateCam;
                @Triangle.started += instance.OnTriangle;
                @Triangle.performed += instance.OnTriangle;
                @Triangle.canceled += instance.OnTriangle;
                @Square.started += instance.OnSquare;
                @Square.performed += instance.OnSquare;
                @Square.canceled += instance.OnSquare;
                @D_Right.started += instance.OnD_Right;
                @D_Right.performed += instance.OnD_Right;
                @D_Right.canceled += instance.OnD_Right;
                @D_Left.started += instance.OnD_Left;
                @D_Left.performed += instance.OnD_Left;
                @D_Left.canceled += instance.OnD_Left;
                @D_Up.started += instance.OnD_Up;
                @D_Up.performed += instance.OnD_Up;
                @D_Up.canceled += instance.OnD_Up;
                @D_Down.started += instance.OnD_Down;
                @D_Down.performed += instance.OnD_Down;
                @D_Down.canceled += instance.OnD_Down;
                @L1.started += instance.OnL1;
                @L1.performed += instance.OnL1;
                @L1.canceled += instance.OnL1;
                @L2.started += instance.OnL2;
                @L2.performed += instance.OnL2;
                @L2.canceled += instance.OnL2;
                @R1.started += instance.OnR1;
                @R1.performed += instance.OnR1;
                @R1.canceled += instance.OnR1;
                @R2.started += instance.OnR2;
                @R2.performed += instance.OnR2;
                @R2.canceled += instance.OnR2;
                @Option.started += instance.OnOption;
                @Option.performed += instance.OnOption;
                @Option.canceled += instance.OnOption;
                @TouchPad.started += instance.OnTouchPad;
                @TouchPad.performed += instance.OnTouchPad;
                @TouchPad.canceled += instance.OnTouchPad;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);

    // OptionMode
    private readonly InputActionMap m_OptionMode;
    private IOptionModeActions m_OptionModeActionsCallbackInterface;
    private readonly InputAction m_OptionMode_L1;
    private readonly InputAction m_OptionMode_R1;
    private readonly InputAction m_OptionMode_Circle;
    private readonly InputAction m_OptionMode_Cross;
    private readonly InputAction m_OptionMode_Square;
    private readonly InputAction m_OptionMode_Triangle;
    private readonly InputAction m_OptionMode_LStick;
    private readonly InputAction m_OptionMode_RStick;
    private readonly InputAction m_OptionMode_Option;
    public struct OptionModeActions
    {
        private @PlayerControls m_Wrapper;
        public OptionModeActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @L1 => m_Wrapper.m_OptionMode_L1;
        public InputAction @R1 => m_Wrapper.m_OptionMode_R1;
        public InputAction @Circle => m_Wrapper.m_OptionMode_Circle;
        public InputAction @Cross => m_Wrapper.m_OptionMode_Cross;
        public InputAction @Square => m_Wrapper.m_OptionMode_Square;
        public InputAction @Triangle => m_Wrapper.m_OptionMode_Triangle;
        public InputAction @LStick => m_Wrapper.m_OptionMode_LStick;
        public InputAction @RStick => m_Wrapper.m_OptionMode_RStick;
        public InputAction @Option => m_Wrapper.m_OptionMode_Option;
        public InputActionMap Get() { return m_Wrapper.m_OptionMode; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OptionModeActions set) { return set.Get(); }
        public void SetCallbacks(IOptionModeActions instance)
        {
            if (m_Wrapper.m_OptionModeActionsCallbackInterface != null)
            {
                @L1.started -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnL1;
                @L1.performed -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnL1;
                @L1.canceled -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnL1;
                @R1.started -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnR1;
                @R1.performed -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnR1;
                @R1.canceled -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnR1;
                @Circle.started -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnCircle;
                @Circle.performed -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnCircle;
                @Circle.canceled -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnCircle;
                @Cross.started -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnCross;
                @Cross.performed -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnCross;
                @Cross.canceled -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnCross;
                @Square.started -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnSquare;
                @Square.performed -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnSquare;
                @Square.canceled -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnSquare;
                @Triangle.started -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnTriangle;
                @Triangle.performed -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnTriangle;
                @Triangle.canceled -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnTriangle;
                @LStick.started -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnLStick;
                @LStick.performed -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnLStick;
                @LStick.canceled -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnLStick;
                @RStick.started -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnRStick;
                @RStick.performed -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnRStick;
                @RStick.canceled -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnRStick;
                @Option.started -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnOption;
                @Option.performed -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnOption;
                @Option.canceled -= m_Wrapper.m_OptionModeActionsCallbackInterface.OnOption;
            }
            m_Wrapper.m_OptionModeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @L1.started += instance.OnL1;
                @L1.performed += instance.OnL1;
                @L1.canceled += instance.OnL1;
                @R1.started += instance.OnR1;
                @R1.performed += instance.OnR1;
                @R1.canceled += instance.OnR1;
                @Circle.started += instance.OnCircle;
                @Circle.performed += instance.OnCircle;
                @Circle.canceled += instance.OnCircle;
                @Cross.started += instance.OnCross;
                @Cross.performed += instance.OnCross;
                @Cross.canceled += instance.OnCross;
                @Square.started += instance.OnSquare;
                @Square.performed += instance.OnSquare;
                @Square.canceled += instance.OnSquare;
                @Triangle.started += instance.OnTriangle;
                @Triangle.performed += instance.OnTriangle;
                @Triangle.canceled += instance.OnTriangle;
                @LStick.started += instance.OnLStick;
                @LStick.performed += instance.OnLStick;
                @LStick.canceled += instance.OnLStick;
                @RStick.started += instance.OnRStick;
                @RStick.performed += instance.OnRStick;
                @RStick.canceled += instance.OnRStick;
                @Option.started += instance.OnOption;
                @Option.performed += instance.OnOption;
                @Option.canceled += instance.OnOption;
            }
        }
    }
    public OptionModeActions @OptionMode => new OptionModeActions(this);
    public interface IGamePlayActions
    {
        void OnCheck(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnRotateCam(InputAction.CallbackContext context);
        void OnTriangle(InputAction.CallbackContext context);
        void OnSquare(InputAction.CallbackContext context);
        void OnD_Right(InputAction.CallbackContext context);
        void OnD_Left(InputAction.CallbackContext context);
        void OnD_Up(InputAction.CallbackContext context);
        void OnD_Down(InputAction.CallbackContext context);
        void OnL1(InputAction.CallbackContext context);
        void OnL2(InputAction.CallbackContext context);
        void OnR1(InputAction.CallbackContext context);
        void OnR2(InputAction.CallbackContext context);
        void OnOption(InputAction.CallbackContext context);
        void OnTouchPad(InputAction.CallbackContext context);
    }
    public interface IOptionModeActions
    {
        void OnL1(InputAction.CallbackContext context);
        void OnR1(InputAction.CallbackContext context);
        void OnCircle(InputAction.CallbackContext context);
        void OnCross(InputAction.CallbackContext context);
        void OnSquare(InputAction.CallbackContext context);
        void OnTriangle(InputAction.CallbackContext context);
        void OnLStick(InputAction.CallbackContext context);
        void OnRStick(InputAction.CallbackContext context);
        void OnOption(InputAction.CallbackContext context);
    }
}
