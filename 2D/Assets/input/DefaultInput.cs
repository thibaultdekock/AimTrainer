//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/input/DefaultInput.inputactions
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

public partial class @DefaultInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DefaultInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultInput"",
    ""maps"": [
        {
            ""name"": ""Character"",
            ""id"": ""6e2554ee-ed51-4e81-a283-71172423c776"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""553cf008-07f3-4081-8c97-0b62d948d471"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""View"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9b41db7d-cfc1-4cbe-9f9f-120ac0714852"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""55a1554c-22c0-4cbd-a169-bf6278a2957e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crounch"",
                    ""type"": ""Button"",
                    ""id"": ""72033809-201c-4f0e-b71c-169a86d7fb78"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Prone"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ff42048d-55c3-4b21-8ba8-58e3368a446f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""bbd81fa0-6a26-4cd0-bbb2-88dcf47e8346"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SprintReleased"",
                    ""type"": ""Button"",
                    ""id"": ""10c8a47a-4aee-4a48-aeea-9c2251c7ae22"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeanLeftPressed"",
                    ""type"": ""Button"",
                    ""id"": ""5b1a4b78-f5f7-44f6-bef0-17ddd5b19073"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeanRightPressed"",
                    ""type"": ""Button"",
                    ""id"": ""e6c6cdef-1a6a-4900-ba45-43568f6792ab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeanLeftReleased"",
                    ""type"": ""Button"",
                    ""id"": ""187dbe28-9d04-489e-9237-f20f20b2f00c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeanRightReleased"",
                    ""type"": ""Button"",
                    ""id"": ""43e0e0c9-799e-4602-a2f4-19b01b7f92b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""321387ca-a66d-4d62-a985-e1dab1b3cfb5"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WSAD"",
                    ""id"": ""70456ba3-1b57-4692-a205-133b93eca40f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""dcba4d5c-5093-4eaf-a617-301a6b7b522c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7cd6b6d6-06da-46b3-8534-9d3bf3cc33de"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4c72c326-62d0-44c0-ad59-dafb676a94f3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bfdc9d9c-d7fe-4d00-bc4b-7209d638227f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f196643b-5c00-4580-a97a-1d0e7ed175c4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6446526e-48a7-440c-8c2f-80be206bcfb1"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crounch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""082e0a31-f7e1-416c-b75a-d3475a3c1164"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Prone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""674849f9-cef0-47ef-8a49-7e1129d61322"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Prone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aba325a7-a07a-404f-ba4e-83d3f7801a56"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97688240-2cc0-4d42-8501-42eb429233b2"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SprintReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6715e7fc-ee49-497f-a458-49c6fac2c7ab"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeanLeftPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22b31202-7e04-48d5-bd5c-6fa85c017a0d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeanRightPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8fcd6086-0342-4498-9778-f9c5d24ec048"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeanLeftReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b370b7f0-c072-4a41-8b5f-fb063e816480"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeanRightReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Weapon"",
            ""id"": ""46ae9962-1e1d-4f0c-a659-334806b14743"",
            ""actions"": [
                {
                    ""name"": ""Fire2Pressed"",
                    ""type"": ""Button"",
                    ""id"": ""3ca6bcde-0416-41d4-bdf7-01eb7754a9c6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire2Released"",
                    ""type"": ""Button"",
                    ""id"": ""68cf162c-981d-4e2c-ad41-a32aed120ce0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire1Pressed"",
                    ""type"": ""Button"",
                    ""id"": ""52dcc65d-2fcf-456b-a3cc-45acbb8e1825"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire1Released"",
                    ""type"": ""Button"",
                    ""id"": ""ffc1384c-450f-43a5-8b4b-306681db2f1d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""62d2ed8b-56c8-467c-914a-e09fb38d7ce1"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire2Pressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d2e9ff03-d842-411a-ad01-c688c6c95b45"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire2Released"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fae99915-48f0-4366-b4fb-d544d5cb96a4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire1Pressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cfa2c940-09cb-4b50-813c-fe9ff0bb8a1b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire1Released"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_Movement = m_Character.FindAction("Movement", throwIfNotFound: true);
        m_Character_View = m_Character.FindAction("View", throwIfNotFound: true);
        m_Character_Jump = m_Character.FindAction("Jump", throwIfNotFound: true);
        m_Character_Crounch = m_Character.FindAction("Crounch", throwIfNotFound: true);
        m_Character_Prone = m_Character.FindAction("Prone", throwIfNotFound: true);
        m_Character_Sprint = m_Character.FindAction("Sprint", throwIfNotFound: true);
        m_Character_SprintReleased = m_Character.FindAction("SprintReleased", throwIfNotFound: true);
        m_Character_LeanLeftPressed = m_Character.FindAction("LeanLeftPressed", throwIfNotFound: true);
        m_Character_LeanRightPressed = m_Character.FindAction("LeanRightPressed", throwIfNotFound: true);
        m_Character_LeanLeftReleased = m_Character.FindAction("LeanLeftReleased", throwIfNotFound: true);
        m_Character_LeanRightReleased = m_Character.FindAction("LeanRightReleased", throwIfNotFound: true);
        // Weapon
        m_Weapon = asset.FindActionMap("Weapon", throwIfNotFound: true);
        m_Weapon_Fire2Pressed = m_Weapon.FindAction("Fire2Pressed", throwIfNotFound: true);
        m_Weapon_Fire2Released = m_Weapon.FindAction("Fire2Released", throwIfNotFound: true);
        m_Weapon_Fire1Pressed = m_Weapon.FindAction("Fire1Pressed", throwIfNotFound: true);
        m_Weapon_Fire1Released = m_Weapon.FindAction("Fire1Released", throwIfNotFound: true);
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

    // Character
    private readonly InputActionMap m_Character;
    private List<ICharacterActions> m_CharacterActionsCallbackInterfaces = new List<ICharacterActions>();
    private readonly InputAction m_Character_Movement;
    private readonly InputAction m_Character_View;
    private readonly InputAction m_Character_Jump;
    private readonly InputAction m_Character_Crounch;
    private readonly InputAction m_Character_Prone;
    private readonly InputAction m_Character_Sprint;
    private readonly InputAction m_Character_SprintReleased;
    private readonly InputAction m_Character_LeanLeftPressed;
    private readonly InputAction m_Character_LeanRightPressed;
    private readonly InputAction m_Character_LeanLeftReleased;
    private readonly InputAction m_Character_LeanRightReleased;
    public struct CharacterActions
    {
        private @DefaultInput m_Wrapper;
        public CharacterActions(@DefaultInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Character_Movement;
        public InputAction @View => m_Wrapper.m_Character_View;
        public InputAction @Jump => m_Wrapper.m_Character_Jump;
        public InputAction @Crounch => m_Wrapper.m_Character_Crounch;
        public InputAction @Prone => m_Wrapper.m_Character_Prone;
        public InputAction @Sprint => m_Wrapper.m_Character_Sprint;
        public InputAction @SprintReleased => m_Wrapper.m_Character_SprintReleased;
        public InputAction @LeanLeftPressed => m_Wrapper.m_Character_LeanLeftPressed;
        public InputAction @LeanRightPressed => m_Wrapper.m_Character_LeanRightPressed;
        public InputAction @LeanLeftReleased => m_Wrapper.m_Character_LeanLeftReleased;
        public InputAction @LeanRightReleased => m_Wrapper.m_Character_LeanRightReleased;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void AddCallbacks(ICharacterActions instance)
        {
            if (instance == null || m_Wrapper.m_CharacterActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CharacterActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @View.started += instance.OnView;
            @View.performed += instance.OnView;
            @View.canceled += instance.OnView;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Crounch.started += instance.OnCrounch;
            @Crounch.performed += instance.OnCrounch;
            @Crounch.canceled += instance.OnCrounch;
            @Prone.started += instance.OnProne;
            @Prone.performed += instance.OnProne;
            @Prone.canceled += instance.OnProne;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
            @SprintReleased.started += instance.OnSprintReleased;
            @SprintReleased.performed += instance.OnSprintReleased;
            @SprintReleased.canceled += instance.OnSprintReleased;
            @LeanLeftPressed.started += instance.OnLeanLeftPressed;
            @LeanLeftPressed.performed += instance.OnLeanLeftPressed;
            @LeanLeftPressed.canceled += instance.OnLeanLeftPressed;
            @LeanRightPressed.started += instance.OnLeanRightPressed;
            @LeanRightPressed.performed += instance.OnLeanRightPressed;
            @LeanRightPressed.canceled += instance.OnLeanRightPressed;
            @LeanLeftReleased.started += instance.OnLeanLeftReleased;
            @LeanLeftReleased.performed += instance.OnLeanLeftReleased;
            @LeanLeftReleased.canceled += instance.OnLeanLeftReleased;
            @LeanRightReleased.started += instance.OnLeanRightReleased;
            @LeanRightReleased.performed += instance.OnLeanRightReleased;
            @LeanRightReleased.canceled += instance.OnLeanRightReleased;
        }

        private void UnregisterCallbacks(ICharacterActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @View.started -= instance.OnView;
            @View.performed -= instance.OnView;
            @View.canceled -= instance.OnView;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Crounch.started -= instance.OnCrounch;
            @Crounch.performed -= instance.OnCrounch;
            @Crounch.canceled -= instance.OnCrounch;
            @Prone.started -= instance.OnProne;
            @Prone.performed -= instance.OnProne;
            @Prone.canceled -= instance.OnProne;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
            @SprintReleased.started -= instance.OnSprintReleased;
            @SprintReleased.performed -= instance.OnSprintReleased;
            @SprintReleased.canceled -= instance.OnSprintReleased;
            @LeanLeftPressed.started -= instance.OnLeanLeftPressed;
            @LeanLeftPressed.performed -= instance.OnLeanLeftPressed;
            @LeanLeftPressed.canceled -= instance.OnLeanLeftPressed;
            @LeanRightPressed.started -= instance.OnLeanRightPressed;
            @LeanRightPressed.performed -= instance.OnLeanRightPressed;
            @LeanRightPressed.canceled -= instance.OnLeanRightPressed;
            @LeanLeftReleased.started -= instance.OnLeanLeftReleased;
            @LeanLeftReleased.performed -= instance.OnLeanLeftReleased;
            @LeanLeftReleased.canceled -= instance.OnLeanLeftReleased;
            @LeanRightReleased.started -= instance.OnLeanRightReleased;
            @LeanRightReleased.performed -= instance.OnLeanRightReleased;
            @LeanRightReleased.canceled -= instance.OnLeanRightReleased;
        }

        public void RemoveCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICharacterActions instance)
        {
            foreach (var item in m_Wrapper.m_CharacterActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CharacterActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CharacterActions @Character => new CharacterActions(this);

    // Weapon
    private readonly InputActionMap m_Weapon;
    private List<IWeaponActions> m_WeaponActionsCallbackInterfaces = new List<IWeaponActions>();
    private readonly InputAction m_Weapon_Fire2Pressed;
    private readonly InputAction m_Weapon_Fire2Released;
    private readonly InputAction m_Weapon_Fire1Pressed;
    private readonly InputAction m_Weapon_Fire1Released;
    public struct WeaponActions
    {
        private @DefaultInput m_Wrapper;
        public WeaponActions(@DefaultInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire2Pressed => m_Wrapper.m_Weapon_Fire2Pressed;
        public InputAction @Fire2Released => m_Wrapper.m_Weapon_Fire2Released;
        public InputAction @Fire1Pressed => m_Wrapper.m_Weapon_Fire1Pressed;
        public InputAction @Fire1Released => m_Wrapper.m_Weapon_Fire1Released;
        public InputActionMap Get() { return m_Wrapper.m_Weapon; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WeaponActions set) { return set.Get(); }
        public void AddCallbacks(IWeaponActions instance)
        {
            if (instance == null || m_Wrapper.m_WeaponActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_WeaponActionsCallbackInterfaces.Add(instance);
            @Fire2Pressed.started += instance.OnFire2Pressed;
            @Fire2Pressed.performed += instance.OnFire2Pressed;
            @Fire2Pressed.canceled += instance.OnFire2Pressed;
            @Fire2Released.started += instance.OnFire2Released;
            @Fire2Released.performed += instance.OnFire2Released;
            @Fire2Released.canceled += instance.OnFire2Released;
            @Fire1Pressed.started += instance.OnFire1Pressed;
            @Fire1Pressed.performed += instance.OnFire1Pressed;
            @Fire1Pressed.canceled += instance.OnFire1Pressed;
            @Fire1Released.started += instance.OnFire1Released;
            @Fire1Released.performed += instance.OnFire1Released;
            @Fire1Released.canceled += instance.OnFire1Released;
        }

        private void UnregisterCallbacks(IWeaponActions instance)
        {
            @Fire2Pressed.started -= instance.OnFire2Pressed;
            @Fire2Pressed.performed -= instance.OnFire2Pressed;
            @Fire2Pressed.canceled -= instance.OnFire2Pressed;
            @Fire2Released.started -= instance.OnFire2Released;
            @Fire2Released.performed -= instance.OnFire2Released;
            @Fire2Released.canceled -= instance.OnFire2Released;
            @Fire1Pressed.started -= instance.OnFire1Pressed;
            @Fire1Pressed.performed -= instance.OnFire1Pressed;
            @Fire1Pressed.canceled -= instance.OnFire1Pressed;
            @Fire1Released.started -= instance.OnFire1Released;
            @Fire1Released.performed -= instance.OnFire1Released;
            @Fire1Released.canceled -= instance.OnFire1Released;
        }

        public void RemoveCallbacks(IWeaponActions instance)
        {
            if (m_Wrapper.m_WeaponActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IWeaponActions instance)
        {
            foreach (var item in m_Wrapper.m_WeaponActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_WeaponActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public WeaponActions @Weapon => new WeaponActions(this);
    public interface ICharacterActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnView(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCrounch(InputAction.CallbackContext context);
        void OnProne(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnSprintReleased(InputAction.CallbackContext context);
        void OnLeanLeftPressed(InputAction.CallbackContext context);
        void OnLeanRightPressed(InputAction.CallbackContext context);
        void OnLeanLeftReleased(InputAction.CallbackContext context);
        void OnLeanRightReleased(InputAction.CallbackContext context);
    }
    public interface IWeaponActions
    {
        void OnFire2Pressed(InputAction.CallbackContext context);
        void OnFire2Released(InputAction.CallbackContext context);
        void OnFire1Pressed(InputAction.CallbackContext context);
        void OnFire1Released(InputAction.CallbackContext context);
    }
}
