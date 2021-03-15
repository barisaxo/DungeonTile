// GENERATED AUTOMATICALLY FROM 'Assets/Test.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Test : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Test()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Test"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""f993871e-1ed4-4234-9830-f28487db2f0d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""0f75aefd-5534-474a-a356-a6813e0e1124"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""198ad43f-4529-4c49-aa49-cc76501921ba"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""5d1c8928-1ac6-493a-9848-2bd1520b0cdf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""978bfe49-cc26-4a3d-ab7b-7d7a29327403"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""00ca640b-d935-4593-8157-c05846ea39b3"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e2062cb9-1b15-46a2-838c-2f8d72a0bdd9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8180e8bd-4097-4f4e-ab88-4523101a6ce9"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""320bffee-a40b-4347-ac70-c210eb8bc73a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1c5327b5-f71c-4f60-99c7-4e737386f1d1"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d2581a9b-1d11-4566-b27d-b92aff5fabbc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2e46982e-44cc-431b-9f0b-c11910bf467a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fcfe95b8-67b9-4526-84b5-5d0bc98d6400"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""77bff152-3580-4b21-b6de-dcd0c7e41164"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1635d3fe-58b6-4ba9-a4e2-f4b964f6b5c8"",
                    ""path"": ""<XRController>/{Primary2DAxis}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ea4d645-4504-4529-b061-ab81934c3752"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1f7a91b-d0fd-4a62-997e-7fb9b69bf235"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c8e490b-c610-4785-884f-f04217b23ca4"",
                    ""path"": ""<Pointer>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse;Touch"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e5f5442-8668-4b27-a940-df99bad7e831"",
                    ""path"": ""<Joystick>/{Hatswitch}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""143bb1cd-cc10-4eca-a2f0-a3664166fe91"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05f6913d-c316-48b2-a6bb-e225f14c7960"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""886e731e-7071-4ae4-95c0-e61739dad6fd"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee3d0cd2-254e-47a7-a8cb-bc94d9658c54"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8255d333-5683-4943-a58a-ccb207ff1dce"",
                    ""path"": ""<XRController>/{PrimaryAction}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""9b0cee49-6ba0-48c1-af20-ac27d1ac67a0"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""632d9c00-2c6e-4177-8ef0-52879d089065"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""30bea978-6715-44ad-a5e1-a8f1e224e185"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""61837c58-efb5-47c0-9cfc-638778978de7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""461d1c13-b39f-470c-89bb-8a1425b06c7d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ab85a7a9-e2bb-4452-ae91-2bb8fbd43f82"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""92619fa8-7e16-4252-aa9b-230e327f6270"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""691ab04d-026b-4ecc-a31d-180b2db1cacd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a657d9b8-7a40-4d56-9cd9-6e6e508994cf"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDevicePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""54137fe0-e4a9-40c6-bb5d-a330b54dca31"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDeviceOrientation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""89088cb8-cbac-4012-ba77-01e127fbc8bc"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""809f371f-c5e2-4e7a-83a1-d867598f40dd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""14a5d6e8-4aaf-4119-a9ef-34b8c2c548bf"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9144cbe6-05e1-4687-a6d7-24f99d23dd81"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2db08d65-c5fb-421b-983f-c71163608d67"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""58748904-2ea9-4a80-8579-b500e6a76df8"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8ba04515-75aa-45de-966d-393d9bbd1c14"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""712e721c-bdfb-4b23-a86c-a0d9fcfea921"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fcd248ae-a788-4676-a12e-f4d81205600b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1f04d9bc-c50b-41a1-bfcc-afb75475ec20"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fb8277d4-c5cd-4663-9dc7-ee3f0b506d90"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""e25d9774-381c-4a61-b47c-7b6b299ad9f9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3db53b26-6601-41be-9887-63ac74e79d19"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0cb3e13e-3d90-4178-8ae6-d9c5501d653f"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0392d399-f6dd-4c82-8062-c1e9c0d34835"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""942a66d9-d42f-43d6-8d70-ecb4ba5363bc"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""ff527021-f211-4c02-933e-5976594c46ed"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""563fbfdd-0f09-408d-aa75-8642c4f08ef0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eb480147-c587-4a33-85ed-eb0ab9942c43"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2bf42165-60bc-42ca-8072-8c13ab40239b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""85d264ad-e0a0-4565-b7ff-1a37edde51ac"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""74214943-c580-44e4-98eb-ad7eebe17902"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cea9b045-a000-445b-95b8-0c171af70a3b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8607c725-d935-4808-84b1-8354e29bab63"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4cda81dc-9edd-4e03-9d7c-a71a14345d0b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9e92bb26-7e3b-4ec4-b06b-3c8f8e498ddc"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82627dcc-3b13-4ba9-841d-e4b746d6553e"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c52c8e0b-8179-41d3-b8a1-d149033bbe86"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1394cbc-336e-44ce-9ea8-6007ed6193f7"",
                    ""path"": ""<Pen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5693e57a-238a-46ed-b5ae-e64e6e574302"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4faf7dc9-b979-4210-aa8c-e808e1ef89f5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d66d5ba-88d7-48e6-b1cd-198bbfef7ace"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47c2a644-3ebc-4dae-a106-589b7ca75b59"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb9e6b34-44bf-4381-ac63-5aa15d19f677"",
                    ""path"": ""<XRController>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38c99815-14ea-4617-8627-164d27641299"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24066f69-da47-44f3-a07e-0015fb02eb2e"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c191405-5738-4d4b-a523-c6a301dbf754"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7236c0d9-6ca3-47cf-a6ee-a97f5b59ea77"",
                    ""path"": ""<XRController>/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDevicePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23e01e3a-f935-4948-8d8b-9bcac77714fb"",
                    ""path"": ""<XRController>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDeviceOrientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""N30 pro (macOS mode)"",
            ""id"": ""92c91d93-5b0e-4a74-8370-a847b8ff4bb5"",
            ""actions"": [
                {
                    ""name"": ""DPadUp"",
                    ""type"": ""Button"",
                    ""id"": ""c29deb63-0b0e-4efc-afb8-78b671476dbf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DPadDown"",
                    ""type"": ""Button"",
                    ""id"": ""1a8c243c-2805-4165-97cb-e122b6baa977"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DPadLeft"",
                    ""type"": ""Button"",
                    ""id"": ""ce2ced64-6bfe-46cc-82a2-8697448e28ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DPadRight"",
                    ""type"": ""Button"",
                    ""id"": ""a95b469b-3bc7-44c6-b539-7cd1aeb752a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""fcbb608f-eb4c-42cf-a638-d13d72dbc37c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""dccbc5b5-004f-4eeb-8113-4d7f1e35d489"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""X"",
                    ""type"": ""Button"",
                    ""id"": ""67b114b4-4613-46e5-9d29-a605080b005b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Y"",
                    ""type"": ""Button"",
                    ""id"": ""be0e304b-3341-4ba4-a6b3-42183f8c0881"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""12618133-3405-4aa9-b53e-82068f5e7b3f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""f32617a9-9f28-4301-8e2c-07f5f4dffb1d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L1"",
                    ""type"": ""Button"",
                    ""id"": ""275a2d23-8bbf-4c74-be7a-1d9c78aeb5f2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R1"",
                    ""type"": ""Button"",
                    ""id"": ""9c190127-7504-45da-ac9a-ebdb3a771056"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L2"",
                    ""type"": ""Button"",
                    ""id"": ""e0dc97a7-807f-4465-a6c6-5ab248f930c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R2"",
                    ""type"": ""Button"",
                    ""id"": ""a551ba10-dae9-4a4f-a768-f6e2946f5123"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L3"",
                    ""type"": ""Button"",
                    ""id"": ""5cc37998-35db-4f28-8260-9afb89e56f59"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R3"",
                    ""type"": ""Button"",
                    ""id"": ""ca2130cd-8924-4ce6-a0e5-9e563b6bd51e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftStick"",
                    ""type"": ""Value"",
                    ""id"": ""2b052809-7cce-412e-9b79-bfdb9b7cf3b9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightStick"",
                    ""type"": ""Value"",
                    ""id"": ""66c5e4a5-0764-416c-a0eb-879decb502be"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Home"",
                    ""type"": ""Button"",
                    ""id"": ""4a7431ae-c948-4a20-83be-27d039c2b37d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a8c68c39-1055-418b-a56f-2e4bbd1c8e99"",
                    ""path"": ""<HID::Unknown Wireless Controller>/hat/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0db9c52-bc02-436c-851b-b7ffd3f486c6"",
                    ""path"": ""<HID::Unknown Wireless Controller>/hat/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0b837b7-f484-4ef7-8383-964bf1102504"",
                    ""path"": ""<HID::Unknown Wireless Controller>/hat/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0eec6d88-8457-4fd5-8493-7c828809b8b2"",
                    ""path"": ""<HID::Unknown Wireless Controller>/hat/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2180314d-cc77-494c-821b-5261fa11db4d"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f660d9a8-41f8-4931-8a51-5cae33db7924"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62858950-cc47-4e66-99d1-72628186253d"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b5953e7-d1d2-40f3-b9aa-58dd6b5bede5"",
                    ""path"": ""<HID::Unknown Wireless Controller>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""883aa1a3-4f4a-44b9-9684-552afc04ce99"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button10"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4265d0af-547a-4e6b-aba6-6adcb0bb87cb"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8823eaf-e41e-4628-b514-db978b708c72"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""382908fa-f881-4e77-82f6-856e750a0a46"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9c197b1-7009-47e4-8e70-caf59c93de21"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""592ce39e-8379-48fb-b3e2-349b47fa6a15"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a893ca1-ff4f-4502-9a73-22cec7575c70"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button11"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3d92f76-511e-4440-8cff-da8a1922fd85"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button12"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2fb48d53-b520-4a79-b8b8-25333677c707"",
                    ""path"": ""<HID::Unknown Wireless Controller>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56c3ccf0-99da-44ee-b2bf-db5e21e004f0"",
                    ""path"": ""<HID::Unknown Wireless Controller>/rz"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""531db2f5-a093-44f7-8da0-cc31788d18db"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button13"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Home"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""N30"",
            ""id"": ""e5d55de7-4403-4a97-857a-cfc5b379a5a5"",
            ""actions"": [
                {
                    ""name"": ""DPadUp"",
                    ""type"": ""Button"",
                    ""id"": ""d3a375fc-99c9-4ea7-b5e0-908419f042c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DPadDown"",
                    ""type"": ""Button"",
                    ""id"": ""0e4625e4-969c-4a55-8c2e-75875936fb8b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DPadLeft"",
                    ""type"": ""Button"",
                    ""id"": ""d694f5cc-dfa3-4720-a1c5-e0703f4a27ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DPadRight"",
                    ""type"": ""Button"",
                    ""id"": ""f8c0ba40-f141-4855-aca1-c7924efb2943"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""eda5568e-d51a-4eb9-a687-0fde9be96923"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""2c71fa7b-96e3-4232-bdd9-93e889b071d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""X"",
                    ""type"": ""Button"",
                    ""id"": ""be27f934-7135-4a09-b3f2-783db909531d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Y"",
                    ""type"": ""Button"",
                    ""id"": ""5066cf44-2434-4da5-b176-9eb38d6db3b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""01383ae4-3267-444b-8154-1416ec338913"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""3cb87a61-4a63-43ed-99e6-e185dacdd29f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L1"",
                    ""type"": ""Button"",
                    ""id"": ""2eb00447-8191-48da-87ac-b1c521803fa7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R1"",
                    ""type"": ""Button"",
                    ""id"": ""573a13a3-f169-4e4d-a699-c5e309e371db"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L2"",
                    ""type"": ""Button"",
                    ""id"": ""e1698df0-2dc3-45f2-aae0-ef5cd03c025d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R2"",
                    ""type"": ""Button"",
                    ""id"": ""358321d7-3add-4360-9569-6470f3438fbe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L3"",
                    ""type"": ""Button"",
                    ""id"": ""8c99d686-690a-4de4-9e54-1d9d25b767ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R3"",
                    ""type"": ""Button"",
                    ""id"": ""cf555b1f-88f1-4a5b-a418-1655464ab746"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftStick"",
                    ""type"": ""Value"",
                    ""id"": ""d5015ca4-8826-46ec-bf23-be35103d1e86"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightStickRZ"",
                    ""type"": ""Value"",
                    ""id"": ""28157ed0-ccf0-4355-9b69-488b5a1cd6d5"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightStickZ"",
                    ""type"": ""Value"",
                    ""id"": ""b250c615-fa62-48b6-b86a-1d1487920661"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Home"",
                    ""type"": ""Button"",
                    ""id"": ""134d5f56-2f9d-4b84-b279-ac0880e5fa42"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bdd8a951-383c-451c-8fe4-0793c7c97258"",
                    ""path"": ""<HID::Unknown Wireless Controller>/hat/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb605542-b969-4881-b835-516e01708dc6"",
                    ""path"": ""<HID::Unknown Wireless Controller>/hat/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7052bbca-10eb-4d2b-a8d0-b3dbfa6d5c0e"",
                    ""path"": ""<HID::Unknown Wireless Controller>/hat/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1181957-484e-4534-a6db-20d77c3b13d8"",
                    ""path"": ""<HID::Unknown Wireless Controller>/hat/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""652cc6d9-4643-4d70-8f0b-6460921e40d2"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9a74fd8-b2ef-4585-973d-04d62ea702e3"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85e77c2a-f243-403a-a624-d13dc4c4313a"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bec7925b-640a-4ffe-bb0e-977d5850811b"",
                    ""path"": ""<HID::Unknown Wireless Controller>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5f32311-bc49-4a26-93f4-f8d1444f232a"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button10"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e20ee1ca-520d-4198-ae27-1541c1a4adc5"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e21bac97-4e04-47d0-86c3-8e408d9157aa"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3de3a3df-32ff-43fb-b440-bf35d79a31ac"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdac00f7-8cb7-43b5-b234-566f764f363a"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1727586c-2d71-4155-9f78-5da782551850"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19909972-9da4-47f9-99f2-240db3267d12"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button11"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29fb5e4a-c91d-428f-942f-60dcf8b17374"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button12"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8f2e8b5-8a06-4551-9a58-7c67b2234ea8"",
                    ""path"": ""<HID::Unknown Wireless Controller>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a801ece7-5e67-47d4-95fb-eef83ad654a3"",
                    ""path"": ""<HID::Unknown Wireless Controller>/rz"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStickRZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1cd186e5-af51-40e5-b347-4da7c7b4f45f"",
                    ""path"": ""<HID::Unknown Wireless Controller>/button13"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Home"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f794fa9-3464-47da-bd39-6e27dea0ab15"",
                    ""path"": ""<HID::Unknown Wireless Controller>/rz"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStickZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Fire = m_Player.FindAction("Fire", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Navigate = m_UI.FindAction("Navigate", throwIfNotFound: true);
        m_UI_Submit = m_UI.FindAction("Submit", throwIfNotFound: true);
        m_UI_Cancel = m_UI.FindAction("Cancel", throwIfNotFound: true);
        m_UI_Point = m_UI.FindAction("Point", throwIfNotFound: true);
        m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
        m_UI_ScrollWheel = m_UI.FindAction("ScrollWheel", throwIfNotFound: true);
        m_UI_MiddleClick = m_UI.FindAction("MiddleClick", throwIfNotFound: true);
        m_UI_RightClick = m_UI.FindAction("RightClick", throwIfNotFound: true);
        m_UI_TrackedDevicePosition = m_UI.FindAction("TrackedDevicePosition", throwIfNotFound: true);
        m_UI_TrackedDeviceOrientation = m_UI.FindAction("TrackedDeviceOrientation", throwIfNotFound: true);
        // N30 pro (macOS mode)
        m_N30promacOSmode = asset.FindActionMap("N30 pro (macOS mode)", throwIfNotFound: true);
        m_N30promacOSmode_DPadUp = m_N30promacOSmode.FindAction("DPadUp", throwIfNotFound: true);
        m_N30promacOSmode_DPadDown = m_N30promacOSmode.FindAction("DPadDown", throwIfNotFound: true);
        m_N30promacOSmode_DPadLeft = m_N30promacOSmode.FindAction("DPadLeft", throwIfNotFound: true);
        m_N30promacOSmode_DPadRight = m_N30promacOSmode.FindAction("DPadRight", throwIfNotFound: true);
        m_N30promacOSmode_A = m_N30promacOSmode.FindAction("A", throwIfNotFound: true);
        m_N30promacOSmode_B = m_N30promacOSmode.FindAction("B", throwIfNotFound: true);
        m_N30promacOSmode_X = m_N30promacOSmode.FindAction("X", throwIfNotFound: true);
        m_N30promacOSmode_Y = m_N30promacOSmode.FindAction("Y", throwIfNotFound: true);
        m_N30promacOSmode_Start = m_N30promacOSmode.FindAction("Start", throwIfNotFound: true);
        m_N30promacOSmode_Select = m_N30promacOSmode.FindAction("Select", throwIfNotFound: true);
        m_N30promacOSmode_L1 = m_N30promacOSmode.FindAction("L1", throwIfNotFound: true);
        m_N30promacOSmode_R1 = m_N30promacOSmode.FindAction("R1", throwIfNotFound: true);
        m_N30promacOSmode_L2 = m_N30promacOSmode.FindAction("L2", throwIfNotFound: true);
        m_N30promacOSmode_R2 = m_N30promacOSmode.FindAction("R2", throwIfNotFound: true);
        m_N30promacOSmode_L3 = m_N30promacOSmode.FindAction("L3", throwIfNotFound: true);
        m_N30promacOSmode_R3 = m_N30promacOSmode.FindAction("R3", throwIfNotFound: true);
        m_N30promacOSmode_LeftStick = m_N30promacOSmode.FindAction("LeftStick", throwIfNotFound: true);
        m_N30promacOSmode_RightStick = m_N30promacOSmode.FindAction("RightStick", throwIfNotFound: true);
        m_N30promacOSmode_Home = m_N30promacOSmode.FindAction("Home", throwIfNotFound: true);
        // N30
        m_N30 = asset.FindActionMap("N30", throwIfNotFound: true);
        m_N30_DPadUp = m_N30.FindAction("DPadUp", throwIfNotFound: true);
        m_N30_DPadDown = m_N30.FindAction("DPadDown", throwIfNotFound: true);
        m_N30_DPadLeft = m_N30.FindAction("DPadLeft", throwIfNotFound: true);
        m_N30_DPadRight = m_N30.FindAction("DPadRight", throwIfNotFound: true);
        m_N30_A = m_N30.FindAction("A", throwIfNotFound: true);
        m_N30_B = m_N30.FindAction("B", throwIfNotFound: true);
        m_N30_X = m_N30.FindAction("X", throwIfNotFound: true);
        m_N30_Y = m_N30.FindAction("Y", throwIfNotFound: true);
        m_N30_Start = m_N30.FindAction("Start", throwIfNotFound: true);
        m_N30_Select = m_N30.FindAction("Select", throwIfNotFound: true);
        m_N30_L1 = m_N30.FindAction("L1", throwIfNotFound: true);
        m_N30_R1 = m_N30.FindAction("R1", throwIfNotFound: true);
        m_N30_L2 = m_N30.FindAction("L2", throwIfNotFound: true);
        m_N30_R2 = m_N30.FindAction("R2", throwIfNotFound: true);
        m_N30_L3 = m_N30.FindAction("L3", throwIfNotFound: true);
        m_N30_R3 = m_N30.FindAction("R3", throwIfNotFound: true);
        m_N30_LeftStick = m_N30.FindAction("LeftStick", throwIfNotFound: true);
        m_N30_RightStickRZ = m_N30.FindAction("RightStickRZ", throwIfNotFound: true);
        m_N30_RightStickZ = m_N30.FindAction("RightStickZ", throwIfNotFound: true);
        m_N30_Home = m_N30.FindAction("Home", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Fire;
    public struct PlayerActions
    {
        private @Test m_Wrapper;
        public PlayerActions(@Test wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Fire => m_Wrapper.m_Player_Fire;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Navigate;
    private readonly InputAction m_UI_Submit;
    private readonly InputAction m_UI_Cancel;
    private readonly InputAction m_UI_Point;
    private readonly InputAction m_UI_Click;
    private readonly InputAction m_UI_ScrollWheel;
    private readonly InputAction m_UI_MiddleClick;
    private readonly InputAction m_UI_RightClick;
    private readonly InputAction m_UI_TrackedDevicePosition;
    private readonly InputAction m_UI_TrackedDeviceOrientation;
    public struct UIActions
    {
        private @Test m_Wrapper;
        public UIActions(@Test wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_UI_Navigate;
        public InputAction @Submit => m_Wrapper.m_UI_Submit;
        public InputAction @Cancel => m_Wrapper.m_UI_Cancel;
        public InputAction @Point => m_Wrapper.m_UI_Point;
        public InputAction @Click => m_Wrapper.m_UI_Click;
        public InputAction @ScrollWheel => m_Wrapper.m_UI_ScrollWheel;
        public InputAction @MiddleClick => m_Wrapper.m_UI_MiddleClick;
        public InputAction @RightClick => m_Wrapper.m_UI_RightClick;
        public InputAction @TrackedDevicePosition => m_Wrapper.m_UI_TrackedDevicePosition;
        public InputAction @TrackedDeviceOrientation => m_Wrapper.m_UI_TrackedDeviceOrientation;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Submit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Point.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @ScrollWheel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @MiddleClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @RightClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @TrackedDevicePosition.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @ScrollWheel.started += instance.OnScrollWheel;
                @ScrollWheel.performed += instance.OnScrollWheel;
                @ScrollWheel.canceled += instance.OnScrollWheel;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @TrackedDevicePosition.started += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled += instance.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled += instance.OnTrackedDeviceOrientation;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // N30 pro (macOS mode)
    private readonly InputActionMap m_N30promacOSmode;
    private IN30promacOSmodeActions m_N30promacOSmodeActionsCallbackInterface;
    private readonly InputAction m_N30promacOSmode_DPadUp;
    private readonly InputAction m_N30promacOSmode_DPadDown;
    private readonly InputAction m_N30promacOSmode_DPadLeft;
    private readonly InputAction m_N30promacOSmode_DPadRight;
    private readonly InputAction m_N30promacOSmode_A;
    private readonly InputAction m_N30promacOSmode_B;
    private readonly InputAction m_N30promacOSmode_X;
    private readonly InputAction m_N30promacOSmode_Y;
    private readonly InputAction m_N30promacOSmode_Start;
    private readonly InputAction m_N30promacOSmode_Select;
    private readonly InputAction m_N30promacOSmode_L1;
    private readonly InputAction m_N30promacOSmode_R1;
    private readonly InputAction m_N30promacOSmode_L2;
    private readonly InputAction m_N30promacOSmode_R2;
    private readonly InputAction m_N30promacOSmode_L3;
    private readonly InputAction m_N30promacOSmode_R3;
    private readonly InputAction m_N30promacOSmode_LeftStick;
    private readonly InputAction m_N30promacOSmode_RightStick;
    private readonly InputAction m_N30promacOSmode_Home;
    public struct N30promacOSmodeActions
    {
        private @Test m_Wrapper;
        public N30promacOSmodeActions(@Test wrapper) { m_Wrapper = wrapper; }
        public InputAction @DPadUp => m_Wrapper.m_N30promacOSmode_DPadUp;
        public InputAction @DPadDown => m_Wrapper.m_N30promacOSmode_DPadDown;
        public InputAction @DPadLeft => m_Wrapper.m_N30promacOSmode_DPadLeft;
        public InputAction @DPadRight => m_Wrapper.m_N30promacOSmode_DPadRight;
        public InputAction @A => m_Wrapper.m_N30promacOSmode_A;
        public InputAction @B => m_Wrapper.m_N30promacOSmode_B;
        public InputAction @X => m_Wrapper.m_N30promacOSmode_X;
        public InputAction @Y => m_Wrapper.m_N30promacOSmode_Y;
        public InputAction @Start => m_Wrapper.m_N30promacOSmode_Start;
        public InputAction @Select => m_Wrapper.m_N30promacOSmode_Select;
        public InputAction @L1 => m_Wrapper.m_N30promacOSmode_L1;
        public InputAction @R1 => m_Wrapper.m_N30promacOSmode_R1;
        public InputAction @L2 => m_Wrapper.m_N30promacOSmode_L2;
        public InputAction @R2 => m_Wrapper.m_N30promacOSmode_R2;
        public InputAction @L3 => m_Wrapper.m_N30promacOSmode_L3;
        public InputAction @R3 => m_Wrapper.m_N30promacOSmode_R3;
        public InputAction @LeftStick => m_Wrapper.m_N30promacOSmode_LeftStick;
        public InputAction @RightStick => m_Wrapper.m_N30promacOSmode_RightStick;
        public InputAction @Home => m_Wrapper.m_N30promacOSmode_Home;
        public InputActionMap Get() { return m_Wrapper.m_N30promacOSmode; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(N30promacOSmodeActions set) { return set.Get(); }
        public void SetCallbacks(IN30promacOSmodeActions instance)
        {
            if (m_Wrapper.m_N30promacOSmodeActionsCallbackInterface != null)
            {
                @DPadUp.started -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnDPadUp;
                @DPadUp.performed -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnDPadUp;
                @DPadUp.canceled -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnDPadUp;
                @DPadDown.started -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnDPadDown;
                @DPadDown.performed -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnDPadDown;
                @DPadDown.canceled -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnDPadDown;
                @DPadLeft.started -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnDPadLeft;
                @DPadLeft.performed -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnDPadLeft;
                @DPadLeft.canceled -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnDPadLeft;
                @DPadRight.started -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnDPadRight;
                @DPadRight.performed -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnDPadRight;
                @DPadRight.canceled -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnDPadRight;
                @A.started -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnA;
                @B.started -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnB;
                @X.started -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnX;
                @X.performed -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnX;
                @X.canceled -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnX;
                @Y.started -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnY;
                @Y.performed -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnY;
                @Y.canceled -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnY;
                @Start.started -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnStart;
                @Select.started -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnSelect;
                @L1.started -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnL1;
                @L1.performed -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnL1;
                @L1.canceled -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnL1;
                @R1.started -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnR1;
                @R1.performed -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnR1;
                @R1.canceled -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnR1;
                @L2.started -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnL2;
                @L2.performed -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnL2;
                @L2.canceled -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnL2;
                @R2.started -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnR2;
                @R2.performed -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnR2;
                @R2.canceled -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnR2;
                @L3.started -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnL3;
                @L3.performed -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnL3;
                @L3.canceled -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnL3;
                @R3.started -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnR3;
                @R3.performed -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnR3;
                @R3.canceled -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnR3;
                @LeftStick.started -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnLeftStick;
                @LeftStick.performed -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnLeftStick;
                @LeftStick.canceled -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnLeftStick;
                @RightStick.started -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnRightStick;
                @RightStick.performed -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnRightStick;
                @RightStick.canceled -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnRightStick;
                @Home.started -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnHome;
                @Home.performed -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnHome;
                @Home.canceled -= m_Wrapper.m_N30promacOSmodeActionsCallbackInterface.OnHome;
            }
            m_Wrapper.m_N30promacOSmodeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DPadUp.started += instance.OnDPadUp;
                @DPadUp.performed += instance.OnDPadUp;
                @DPadUp.canceled += instance.OnDPadUp;
                @DPadDown.started += instance.OnDPadDown;
                @DPadDown.performed += instance.OnDPadDown;
                @DPadDown.canceled += instance.OnDPadDown;
                @DPadLeft.started += instance.OnDPadLeft;
                @DPadLeft.performed += instance.OnDPadLeft;
                @DPadLeft.canceled += instance.OnDPadLeft;
                @DPadRight.started += instance.OnDPadRight;
                @DPadRight.performed += instance.OnDPadRight;
                @DPadRight.canceled += instance.OnDPadRight;
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
                @X.started += instance.OnX;
                @X.performed += instance.OnX;
                @X.canceled += instance.OnX;
                @Y.started += instance.OnY;
                @Y.performed += instance.OnY;
                @Y.canceled += instance.OnY;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @L1.started += instance.OnL1;
                @L1.performed += instance.OnL1;
                @L1.canceled += instance.OnL1;
                @R1.started += instance.OnR1;
                @R1.performed += instance.OnR1;
                @R1.canceled += instance.OnR1;
                @L2.started += instance.OnL2;
                @L2.performed += instance.OnL2;
                @L2.canceled += instance.OnL2;
                @R2.started += instance.OnR2;
                @R2.performed += instance.OnR2;
                @R2.canceled += instance.OnR2;
                @L3.started += instance.OnL3;
                @L3.performed += instance.OnL3;
                @L3.canceled += instance.OnL3;
                @R3.started += instance.OnR3;
                @R3.performed += instance.OnR3;
                @R3.canceled += instance.OnR3;
                @LeftStick.started += instance.OnLeftStick;
                @LeftStick.performed += instance.OnLeftStick;
                @LeftStick.canceled += instance.OnLeftStick;
                @RightStick.started += instance.OnRightStick;
                @RightStick.performed += instance.OnRightStick;
                @RightStick.canceled += instance.OnRightStick;
                @Home.started += instance.OnHome;
                @Home.performed += instance.OnHome;
                @Home.canceled += instance.OnHome;
            }
        }
    }
    public N30promacOSmodeActions @N30promacOSmode => new N30promacOSmodeActions(this);

    // N30
    private readonly InputActionMap m_N30;
    private IN30Actions m_N30ActionsCallbackInterface;
    private readonly InputAction m_N30_DPadUp;
    private readonly InputAction m_N30_DPadDown;
    private readonly InputAction m_N30_DPadLeft;
    private readonly InputAction m_N30_DPadRight;
    private readonly InputAction m_N30_A;
    private readonly InputAction m_N30_B;
    private readonly InputAction m_N30_X;
    private readonly InputAction m_N30_Y;
    private readonly InputAction m_N30_Start;
    private readonly InputAction m_N30_Select;
    private readonly InputAction m_N30_L1;
    private readonly InputAction m_N30_R1;
    private readonly InputAction m_N30_L2;
    private readonly InputAction m_N30_R2;
    private readonly InputAction m_N30_L3;
    private readonly InputAction m_N30_R3;
    private readonly InputAction m_N30_LeftStick;
    private readonly InputAction m_N30_RightStickRZ;
    private readonly InputAction m_N30_RightStickZ;
    private readonly InputAction m_N30_Home;
    public struct N30Actions
    {
        private @Test m_Wrapper;
        public N30Actions(@Test wrapper) { m_Wrapper = wrapper; }
        public InputAction @DPadUp => m_Wrapper.m_N30_DPadUp;
        public InputAction @DPadDown => m_Wrapper.m_N30_DPadDown;
        public InputAction @DPadLeft => m_Wrapper.m_N30_DPadLeft;
        public InputAction @DPadRight => m_Wrapper.m_N30_DPadRight;
        public InputAction @A => m_Wrapper.m_N30_A;
        public InputAction @B => m_Wrapper.m_N30_B;
        public InputAction @X => m_Wrapper.m_N30_X;
        public InputAction @Y => m_Wrapper.m_N30_Y;
        public InputAction @Start => m_Wrapper.m_N30_Start;
        public InputAction @Select => m_Wrapper.m_N30_Select;
        public InputAction @L1 => m_Wrapper.m_N30_L1;
        public InputAction @R1 => m_Wrapper.m_N30_R1;
        public InputAction @L2 => m_Wrapper.m_N30_L2;
        public InputAction @R2 => m_Wrapper.m_N30_R2;
        public InputAction @L3 => m_Wrapper.m_N30_L3;
        public InputAction @R3 => m_Wrapper.m_N30_R3;
        public InputAction @LeftStick => m_Wrapper.m_N30_LeftStick;
        public InputAction @RightStickRZ => m_Wrapper.m_N30_RightStickRZ;
        public InputAction @RightStickZ => m_Wrapper.m_N30_RightStickZ;
        public InputAction @Home => m_Wrapper.m_N30_Home;
        public InputActionMap Get() { return m_Wrapper.m_N30; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(N30Actions set) { return set.Get(); }
        public void SetCallbacks(IN30Actions instance)
        {
            if (m_Wrapper.m_N30ActionsCallbackInterface != null)
            {
                @DPadUp.started -= m_Wrapper.m_N30ActionsCallbackInterface.OnDPadUp;
                @DPadUp.performed -= m_Wrapper.m_N30ActionsCallbackInterface.OnDPadUp;
                @DPadUp.canceled -= m_Wrapper.m_N30ActionsCallbackInterface.OnDPadUp;
                @DPadDown.started -= m_Wrapper.m_N30ActionsCallbackInterface.OnDPadDown;
                @DPadDown.performed -= m_Wrapper.m_N30ActionsCallbackInterface.OnDPadDown;
                @DPadDown.canceled -= m_Wrapper.m_N30ActionsCallbackInterface.OnDPadDown;
                @DPadLeft.started -= m_Wrapper.m_N30ActionsCallbackInterface.OnDPadLeft;
                @DPadLeft.performed -= m_Wrapper.m_N30ActionsCallbackInterface.OnDPadLeft;
                @DPadLeft.canceled -= m_Wrapper.m_N30ActionsCallbackInterface.OnDPadLeft;
                @DPadRight.started -= m_Wrapper.m_N30ActionsCallbackInterface.OnDPadRight;
                @DPadRight.performed -= m_Wrapper.m_N30ActionsCallbackInterface.OnDPadRight;
                @DPadRight.canceled -= m_Wrapper.m_N30ActionsCallbackInterface.OnDPadRight;
                @A.started -= m_Wrapper.m_N30ActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_N30ActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_N30ActionsCallbackInterface.OnA;
                @B.started -= m_Wrapper.m_N30ActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_N30ActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_N30ActionsCallbackInterface.OnB;
                @X.started -= m_Wrapper.m_N30ActionsCallbackInterface.OnX;
                @X.performed -= m_Wrapper.m_N30ActionsCallbackInterface.OnX;
                @X.canceled -= m_Wrapper.m_N30ActionsCallbackInterface.OnX;
                @Y.started -= m_Wrapper.m_N30ActionsCallbackInterface.OnY;
                @Y.performed -= m_Wrapper.m_N30ActionsCallbackInterface.OnY;
                @Y.canceled -= m_Wrapper.m_N30ActionsCallbackInterface.OnY;
                @Start.started -= m_Wrapper.m_N30ActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_N30ActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_N30ActionsCallbackInterface.OnStart;
                @Select.started -= m_Wrapper.m_N30ActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_N30ActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_N30ActionsCallbackInterface.OnSelect;
                @L1.started -= m_Wrapper.m_N30ActionsCallbackInterface.OnL1;
                @L1.performed -= m_Wrapper.m_N30ActionsCallbackInterface.OnL1;
                @L1.canceled -= m_Wrapper.m_N30ActionsCallbackInterface.OnL1;
                @R1.started -= m_Wrapper.m_N30ActionsCallbackInterface.OnR1;
                @R1.performed -= m_Wrapper.m_N30ActionsCallbackInterface.OnR1;
                @R1.canceled -= m_Wrapper.m_N30ActionsCallbackInterface.OnR1;
                @L2.started -= m_Wrapper.m_N30ActionsCallbackInterface.OnL2;
                @L2.performed -= m_Wrapper.m_N30ActionsCallbackInterface.OnL2;
                @L2.canceled -= m_Wrapper.m_N30ActionsCallbackInterface.OnL2;
                @R2.started -= m_Wrapper.m_N30ActionsCallbackInterface.OnR2;
                @R2.performed -= m_Wrapper.m_N30ActionsCallbackInterface.OnR2;
                @R2.canceled -= m_Wrapper.m_N30ActionsCallbackInterface.OnR2;
                @L3.started -= m_Wrapper.m_N30ActionsCallbackInterface.OnL3;
                @L3.performed -= m_Wrapper.m_N30ActionsCallbackInterface.OnL3;
                @L3.canceled -= m_Wrapper.m_N30ActionsCallbackInterface.OnL3;
                @R3.started -= m_Wrapper.m_N30ActionsCallbackInterface.OnR3;
                @R3.performed -= m_Wrapper.m_N30ActionsCallbackInterface.OnR3;
                @R3.canceled -= m_Wrapper.m_N30ActionsCallbackInterface.OnR3;
                @LeftStick.started -= m_Wrapper.m_N30ActionsCallbackInterface.OnLeftStick;
                @LeftStick.performed -= m_Wrapper.m_N30ActionsCallbackInterface.OnLeftStick;
                @LeftStick.canceled -= m_Wrapper.m_N30ActionsCallbackInterface.OnLeftStick;
                @RightStickRZ.started -= m_Wrapper.m_N30ActionsCallbackInterface.OnRightStickRZ;
                @RightStickRZ.performed -= m_Wrapper.m_N30ActionsCallbackInterface.OnRightStickRZ;
                @RightStickRZ.canceled -= m_Wrapper.m_N30ActionsCallbackInterface.OnRightStickRZ;
                @RightStickZ.started -= m_Wrapper.m_N30ActionsCallbackInterface.OnRightStickZ;
                @RightStickZ.performed -= m_Wrapper.m_N30ActionsCallbackInterface.OnRightStickZ;
                @RightStickZ.canceled -= m_Wrapper.m_N30ActionsCallbackInterface.OnRightStickZ;
                @Home.started -= m_Wrapper.m_N30ActionsCallbackInterface.OnHome;
                @Home.performed -= m_Wrapper.m_N30ActionsCallbackInterface.OnHome;
                @Home.canceled -= m_Wrapper.m_N30ActionsCallbackInterface.OnHome;
            }
            m_Wrapper.m_N30ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DPadUp.started += instance.OnDPadUp;
                @DPadUp.performed += instance.OnDPadUp;
                @DPadUp.canceled += instance.OnDPadUp;
                @DPadDown.started += instance.OnDPadDown;
                @DPadDown.performed += instance.OnDPadDown;
                @DPadDown.canceled += instance.OnDPadDown;
                @DPadLeft.started += instance.OnDPadLeft;
                @DPadLeft.performed += instance.OnDPadLeft;
                @DPadLeft.canceled += instance.OnDPadLeft;
                @DPadRight.started += instance.OnDPadRight;
                @DPadRight.performed += instance.OnDPadRight;
                @DPadRight.canceled += instance.OnDPadRight;
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
                @X.started += instance.OnX;
                @X.performed += instance.OnX;
                @X.canceled += instance.OnX;
                @Y.started += instance.OnY;
                @Y.performed += instance.OnY;
                @Y.canceled += instance.OnY;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @L1.started += instance.OnL1;
                @L1.performed += instance.OnL1;
                @L1.canceled += instance.OnL1;
                @R1.started += instance.OnR1;
                @R1.performed += instance.OnR1;
                @R1.canceled += instance.OnR1;
                @L2.started += instance.OnL2;
                @L2.performed += instance.OnL2;
                @L2.canceled += instance.OnL2;
                @R2.started += instance.OnR2;
                @R2.performed += instance.OnR2;
                @R2.canceled += instance.OnR2;
                @L3.started += instance.OnL3;
                @L3.performed += instance.OnL3;
                @L3.canceled += instance.OnL3;
                @R3.started += instance.OnR3;
                @R3.performed += instance.OnR3;
                @R3.canceled += instance.OnR3;
                @LeftStick.started += instance.OnLeftStick;
                @LeftStick.performed += instance.OnLeftStick;
                @LeftStick.canceled += instance.OnLeftStick;
                @RightStickRZ.started += instance.OnRightStickRZ;
                @RightStickRZ.performed += instance.OnRightStickRZ;
                @RightStickRZ.canceled += instance.OnRightStickRZ;
                @RightStickZ.started += instance.OnRightStickZ;
                @RightStickZ.performed += instance.OnRightStickZ;
                @RightStickZ.canceled += instance.OnRightStickZ;
                @Home.started += instance.OnHome;
                @Home.performed += instance.OnHome;
                @Home.canceled += instance.OnHome;
            }
        }
    }
    public N30Actions @N30 => new N30Actions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnScrollWheel(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnTrackedDevicePosition(InputAction.CallbackContext context);
        void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
    }
    public interface IN30promacOSmodeActions
    {
        void OnDPadUp(InputAction.CallbackContext context);
        void OnDPadDown(InputAction.CallbackContext context);
        void OnDPadLeft(InputAction.CallbackContext context);
        void OnDPadRight(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
        void OnX(InputAction.CallbackContext context);
        void OnY(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnL1(InputAction.CallbackContext context);
        void OnR1(InputAction.CallbackContext context);
        void OnL2(InputAction.CallbackContext context);
        void OnR2(InputAction.CallbackContext context);
        void OnL3(InputAction.CallbackContext context);
        void OnR3(InputAction.CallbackContext context);
        void OnLeftStick(InputAction.CallbackContext context);
        void OnRightStick(InputAction.CallbackContext context);
        void OnHome(InputAction.CallbackContext context);
    }
    public interface IN30Actions
    {
        void OnDPadUp(InputAction.CallbackContext context);
        void OnDPadDown(InputAction.CallbackContext context);
        void OnDPadLeft(InputAction.CallbackContext context);
        void OnDPadRight(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
        void OnX(InputAction.CallbackContext context);
        void OnY(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnL1(InputAction.CallbackContext context);
        void OnR1(InputAction.CallbackContext context);
        void OnL2(InputAction.CallbackContext context);
        void OnR2(InputAction.CallbackContext context);
        void OnL3(InputAction.CallbackContext context);
        void OnR3(InputAction.CallbackContext context);
        void OnLeftStick(InputAction.CallbackContext context);
        void OnRightStickRZ(InputAction.CallbackContext context);
        void OnRightStickZ(InputAction.CallbackContext context);
        void OnHome(InputAction.CallbackContext context);
    }
}
