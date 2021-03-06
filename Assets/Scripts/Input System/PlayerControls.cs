// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input System/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Ship"",
            ""id"": ""554613e4-7dcd-4bed-9bc9-79c9022c74f1"",
            ""actions"": [
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8c6d4cf3-9abe-45c3-ba75-b31d126da528"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Button"",
                    ""id"": ""aed865ea-1740-44c4-be08-3024c60110ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Button"",
                    ""id"": ""59173602-5879-4d94-8392-0d3fc768e1ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Break"",
                    ""type"": ""Button"",
                    ""id"": ""b2074d70-1d67-4649-874f-32d3f5042622"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""0771ab6d-aa11-4bef-8ebf-a83c07e4322b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TiltLeft"",
                    ""type"": ""Button"",
                    ""id"": ""832960f6-716f-4869-b042-d397f5a466ab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TiltRight"",
                    ""type"": ""Button"",
                    ""id"": ""cb8c650b-9d95-4717-b32b-caca495d99ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AltShoot"",
                    ""type"": ""Button"",
                    ""id"": ""af02a073-5eda-46a0-81ee-76ab9965aacd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Sideways"",
                    ""id"": ""60e48b6d-acfa-4044-b115-4a7a9dcf4eee"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a3149e57-f25b-4d50-9e77-13ce6fb6addb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7cf839fa-9292-405c-a32f-64a4cdb16d08"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ControllerSideways"",
                    ""id"": ""c54725e4-3ccf-4968-912f-676e57b2c112"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7c69740c-d44d-456e-bb97-71395a6ffa81"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5e30871c-832d-4bef-80bc-7c876fb6bfd3"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Up/Down"",
                    ""id"": ""8811e676-2f61-4bdc-9fc4-f1dbc00cbbcd"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4ebbb2f5-f4f3-4ed9-9734-b7fae81fad3c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a6f1cbaf-98bf-4489-9423-e3fa218d211b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controller Up/Down"",
                    ""id"": ""62c146d4-8669-4963-88eb-7ac3ae86d855"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2e7e9e77-ebfe-43e0-be59-8b3d854b0481"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f427dea7-0e3a-48ac-87a1-c1c902f9d655"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""78b91e1b-418b-4891-91c4-809c14bd7949"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0e2d697-1f3b-4f18-90d0-c09f5d825209"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42d57296-c2c8-42a8-9c41-a1d27621f407"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e447972d-7649-4235-b621-2ec217266bfc"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""636497a3-42dd-4b4c-9e6c-7bf671c0c65a"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""871bf941-e954-451e-b4d8-fc740a9b20d9"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b543391e-62af-4fd7-a1c5-4ed5b251461d"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TiltLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be57b36e-0199-4808-9b6c-651a19fc5c34"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TiltRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18a896c4-2f96-4909-a463-1696c9dd5c82"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5ff543d-6e9c-452c-b579-3719c5725d5e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AltShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e1381f6-2863-4f3c-b28f-ba86571299d9"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AltShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Mech"",
            ""id"": ""09532fc5-0af9-474f-a37e-8a9b12937937"",
            ""actions"": [
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Button"",
                    ""id"": ""35e0a321-b2d2-41bb-ab60-c0d1b067360e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Button"",
                    ""id"": ""4e897fae-715e-4204-8d92-1eac5a6fe424"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotationHorizontal"",
                    ""type"": ""Button"",
                    ""id"": ""8225e167-71c6-4b81-96c5-8e13e772b7af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotationVertical"",
                    ""type"": ""Button"",
                    ""id"": ""c76cd4c2-e953-42f9-9c71-f8a7ceb98e67"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""b4a122a4-c840-4bb0-ad3a-a2e7dd110502"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Sideways"",
                    ""id"": ""591f73dd-5f00-478a-b0d8-4c9042945fb7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0dd09185-78ea-41e9-ae3d-d5d3835fb6f8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""bfb1515f-324c-4d9f-97ff-5671d3d09fcd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ControllerSideways"",
                    ""id"": ""bae5bfe8-2fc5-4304-b178-8def1c976789"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""285d2d55-2535-415d-ac65-13c428d8b2f3"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f5674dcd-1d03-46f8-bda3-ba5390c1a98e"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Up/Down"",
                    ""id"": ""5605c995-2362-4707-8dbc-198a9f13dab2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""69ef8ed3-d62d-4eac-8f2f-9baeeb8f1073"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f3fc93d3-1933-416b-a5fe-31ce88310cf6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ControllerUp/Down"",
                    ""id"": ""9616bf98-a7a4-494e-8971-adb6cec3568a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d6e821cf-1af4-4e61-b1d6-4d04f92f1de7"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5b4768e2-a945-4cb9-9bd1-8ccb705d2862"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""RotHorizontal"",
                    ""id"": ""7289b500-a2aa-448f-bbbf-8e4a8744c2ec"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationHorizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""807d199e-b1de-4820-98c2-44e498b9900d"",
                    ""path"": ""<XInputController>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6df8ab29-7cc3-4783-8ee5-249f0d41eada"",
                    ""path"": ""<XInputController>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""RotVertical"",
                    ""id"": ""ccea00c4-251e-4f94-aad3-9855aeecf175"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationVertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""856e2d89-06d5-4701-a09b-cf2906c5d7e2"",
                    ""path"": ""<XInputController>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""fbedba30-b6df-4baa-9813-c9d5987dab51"",
                    ""path"": ""<XInputController>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""20f05586-9722-49a9-8b1f-d54b72685728"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Ship
        m_Ship = asset.FindActionMap("Ship", throwIfNotFound: true);
        m_Ship_Horizontal = m_Ship.FindAction("Horizontal", throwIfNotFound: true);
        m_Ship_Vertical = m_Ship.FindAction("Vertical", throwIfNotFound: true);
        m_Ship_Boost = m_Ship.FindAction("Boost", throwIfNotFound: true);
        m_Ship_Break = m_Ship.FindAction("Break", throwIfNotFound: true);
        m_Ship_Shoot = m_Ship.FindAction("Shoot", throwIfNotFound: true);
        m_Ship_TiltLeft = m_Ship.FindAction("TiltLeft", throwIfNotFound: true);
        m_Ship_TiltRight = m_Ship.FindAction("TiltRight", throwIfNotFound: true);
        m_Ship_AltShoot = m_Ship.FindAction("AltShoot", throwIfNotFound: true);
        // Mech
        m_Mech = asset.FindActionMap("Mech", throwIfNotFound: true);
        m_Mech_Horizontal = m_Mech.FindAction("Horizontal", throwIfNotFound: true);
        m_Mech_Vertical = m_Mech.FindAction("Vertical", throwIfNotFound: true);
        m_Mech_RotationHorizontal = m_Mech.FindAction("RotationHorizontal", throwIfNotFound: true);
        m_Mech_RotationVertical = m_Mech.FindAction("RotationVertical", throwIfNotFound: true);
        m_Mech_Move = m_Mech.FindAction("Move", throwIfNotFound: true);
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

    // Ship
    private readonly InputActionMap m_Ship;
    private IShipActions m_ShipActionsCallbackInterface;
    private readonly InputAction m_Ship_Horizontal;
    private readonly InputAction m_Ship_Vertical;
    private readonly InputAction m_Ship_Boost;
    private readonly InputAction m_Ship_Break;
    private readonly InputAction m_Ship_Shoot;
    private readonly InputAction m_Ship_TiltLeft;
    private readonly InputAction m_Ship_TiltRight;
    private readonly InputAction m_Ship_AltShoot;
    public struct ShipActions
    {
        private @PlayerActions m_Wrapper;
        public ShipActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horizontal => m_Wrapper.m_Ship_Horizontal;
        public InputAction @Vertical => m_Wrapper.m_Ship_Vertical;
        public InputAction @Boost => m_Wrapper.m_Ship_Boost;
        public InputAction @Break => m_Wrapper.m_Ship_Break;
        public InputAction @Shoot => m_Wrapper.m_Ship_Shoot;
        public InputAction @TiltLeft => m_Wrapper.m_Ship_TiltLeft;
        public InputAction @TiltRight => m_Wrapper.m_Ship_TiltRight;
        public InputAction @AltShoot => m_Wrapper.m_Ship_AltShoot;
        public InputActionMap Get() { return m_Wrapper.m_Ship; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShipActions set) { return set.Get(); }
        public void SetCallbacks(IShipActions instance)
        {
            if (m_Wrapper.m_ShipActionsCallbackInterface != null)
            {
                @Horizontal.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnHorizontal;
                @Vertical.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnVertical;
                @Boost.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnBoost;
                @Boost.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnBoost;
                @Boost.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnBoost;
                @Break.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnBreak;
                @Break.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnBreak;
                @Break.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnBreak;
                @Shoot.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnShoot;
                @TiltLeft.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnTiltLeft;
                @TiltLeft.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnTiltLeft;
                @TiltLeft.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnTiltLeft;
                @TiltRight.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnTiltRight;
                @TiltRight.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnTiltRight;
                @TiltRight.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnTiltRight;
                @AltShoot.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnAltShoot;
                @AltShoot.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnAltShoot;
                @AltShoot.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnAltShoot;
            }
            m_Wrapper.m_ShipActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @Boost.started += instance.OnBoost;
                @Boost.performed += instance.OnBoost;
                @Boost.canceled += instance.OnBoost;
                @Break.started += instance.OnBreak;
                @Break.performed += instance.OnBreak;
                @Break.canceled += instance.OnBreak;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @TiltLeft.started += instance.OnTiltLeft;
                @TiltLeft.performed += instance.OnTiltLeft;
                @TiltLeft.canceled += instance.OnTiltLeft;
                @TiltRight.started += instance.OnTiltRight;
                @TiltRight.performed += instance.OnTiltRight;
                @TiltRight.canceled += instance.OnTiltRight;
                @AltShoot.started += instance.OnAltShoot;
                @AltShoot.performed += instance.OnAltShoot;
                @AltShoot.canceled += instance.OnAltShoot;
            }
        }
    }
    public ShipActions @Ship => new ShipActions(this);

    // Mech
    private readonly InputActionMap m_Mech;
    private IMechActions m_MechActionsCallbackInterface;
    private readonly InputAction m_Mech_Horizontal;
    private readonly InputAction m_Mech_Vertical;
    private readonly InputAction m_Mech_RotationHorizontal;
    private readonly InputAction m_Mech_RotationVertical;
    private readonly InputAction m_Mech_Move;
    public struct MechActions
    {
        private @PlayerActions m_Wrapper;
        public MechActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horizontal => m_Wrapper.m_Mech_Horizontal;
        public InputAction @Vertical => m_Wrapper.m_Mech_Vertical;
        public InputAction @RotationHorizontal => m_Wrapper.m_Mech_RotationHorizontal;
        public InputAction @RotationVertical => m_Wrapper.m_Mech_RotationVertical;
        public InputAction @Move => m_Wrapper.m_Mech_Move;
        public InputActionMap Get() { return m_Wrapper.m_Mech; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MechActions set) { return set.Get(); }
        public void SetCallbacks(IMechActions instance)
        {
            if (m_Wrapper.m_MechActionsCallbackInterface != null)
            {
                @Horizontal.started -= m_Wrapper.m_MechActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_MechActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_MechActionsCallbackInterface.OnHorizontal;
                @Vertical.started -= m_Wrapper.m_MechActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_MechActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_MechActionsCallbackInterface.OnVertical;
                @RotationHorizontal.started -= m_Wrapper.m_MechActionsCallbackInterface.OnRotationHorizontal;
                @RotationHorizontal.performed -= m_Wrapper.m_MechActionsCallbackInterface.OnRotationHorizontal;
                @RotationHorizontal.canceled -= m_Wrapper.m_MechActionsCallbackInterface.OnRotationHorizontal;
                @RotationVertical.started -= m_Wrapper.m_MechActionsCallbackInterface.OnRotationVertical;
                @RotationVertical.performed -= m_Wrapper.m_MechActionsCallbackInterface.OnRotationVertical;
                @RotationVertical.canceled -= m_Wrapper.m_MechActionsCallbackInterface.OnRotationVertical;
                @Move.started -= m_Wrapper.m_MechActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MechActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MechActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_MechActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @RotationHorizontal.started += instance.OnRotationHorizontal;
                @RotationHorizontal.performed += instance.OnRotationHorizontal;
                @RotationHorizontal.canceled += instance.OnRotationHorizontal;
                @RotationVertical.started += instance.OnRotationVertical;
                @RotationVertical.performed += instance.OnRotationVertical;
                @RotationVertical.canceled += instance.OnRotationVertical;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public MechActions @Mech => new MechActions(this);
    public interface IShipActions
    {
        void OnHorizontal(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
        void OnBreak(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnTiltLeft(InputAction.CallbackContext context);
        void OnTiltRight(InputAction.CallbackContext context);
        void OnAltShoot(InputAction.CallbackContext context);
    }
    public interface IMechActions
    {
        void OnHorizontal(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
        void OnRotationHorizontal(InputAction.CallbackContext context);
        void OnRotationVertical(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
