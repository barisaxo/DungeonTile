using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BGInputKey : MonoBehaviour
{
    public BGM bgm;

    public Test gamepad;
    public Vector2 ls;
    public float rsRZ;

    public float rsZ;

    private void Start()
    {
        gamepad = new Test();

        gamepad.N30.Enable();

        gamepad.N30.A.performed += ctx => SayIt("A");
        gamepad.N30.B.performed += ctx => SayIt("B");
        gamepad.N30.X.performed += ctx => SayIt("X");
        gamepad.N30.Y.performed += ctx => SayIt("Y");
        gamepad.N30.L1.performed += ctx => SayIt("L1");
        gamepad.N30.R1.performed += ctx => SayIt("R1");
        gamepad.N30.L2.performed += ctx => SayIt("L2");
        gamepad.N30.R2.performed += ctx => SayIt("R2");
        gamepad.N30.L3.performed += ctx => SayIt("L3");
        gamepad.N30.R3.performed += ctx => SayIt("R3");
        gamepad.N30.Start.performed += ctx => SayIt("+");
        gamepad.N30.Select.performed += ctx => SayIt("-");
        gamepad.N30.Home.performed += ctx => SayIt("Home");
        gamepad.N30.DPadUp.performed += ctx => bgm.movement.Move(BGMovement.Direction.North);
        gamepad.N30.DPadDown.performed += ctx => bgm.movement.Move(BGMovement.Direction.South);
        gamepad.N30.DPadLeft.performed += ctx => bgm.movement.Move(BGMovement.Direction.West);
        gamepad.N30.DPadRight.performed += ctx => bgm.movement.Move(BGMovement.Direction.East);
        gamepad.N30.LeftStick.performed += ctx => ls = ctx.ReadValue<Vector2>();
        gamepad.N30.LeftStick.canceled += ctx => ls = Vector2.zero;
        gamepad.N30.RightStickRZ.performed += ctx => rsRZ = ctx.ReadValue<float>();
        gamepad.N30.RightStickRZ.canceled += ctx => rsRZ = 0f;
        gamepad.N30.RightStickZ.performed += ctx => rsZ = ctx.ReadValue<float>();
        gamepad.N30.RightStickZ.canceled += ctx => rsZ = 0f;

        //gamepad.N30.RightStickX.performed += ctx => rs.x = ctx.ReadValue<float>();
        //gamepad.N30.RightStickX.canceled += ctx => rs.x = 0f;
        //gamepad.N30.RightStickY.performed += ctx => rs.y = ctx.ReadValue<float>();
        //gamepad.N30.RightStickY.canceled += ctx => rs.y = 0f;
        //gamepad.N30.RightStickX.performed += ctx => SayIt("right");


        //var j = Input.GetJoystickNames();
        //Debug.Log(j);
    }

    void SayIt(string s)
    {
        Debug.Log(s);

        Debug.Log(ls + ", " + new Vector2(rsRZ, rsZ));
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {

            if (Input.GetKeyDown(KeyCode.W))
            {
                if (bgm.stateManager.bgState == BGStateManager.BGStates.Static)
                {
                    bgm.movement.Move(BGMovement.Direction.North);
                }
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                if (bgm.stateManager.bgState == BGStateManager.BGStates.Static)
                {
                    bgm.movement.Move(BGMovement.Direction.South);
                }
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                if (bgm.stateManager.bgState == BGStateManager.BGStates.Static)
                {
                    bgm.movement.Move(BGMovement.Direction.West);
                }
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                if (bgm.stateManager.bgState == BGStateManager.BGStates.Static)
                {
                    bgm.movement.Move(BGMovement.Direction.East);
                }
            }
        }
    }
}



/*
 * 
 * 
 * 
 * 
 * 
 *  * INPUT (old) ->
 * JoystickButton0  == "Fire1"       == Y
 * JoystickButton1  == "Fire2"       == B
 * JoystickButton2  == "Fire3"       == A
 * JoystickButton3  ==  "JUMP"       == X
 * JoystickButton4  ==               == L1
 * JoystickButton5  ==               == R1
 * JoystickButton6  ==               == L2
 * JoystickButton7  ==               == R2
 * JoystickButton8  ==               == -select
 * JoystickButton9  ==               == +start          
 * JoystickButton10 ==               == L3
 * JoystickButton11 ==               == R3
 * JoystickButton12 ==               == Home          
 * JoystickButton13 ==            
 * JoystickButton14 ==            
 * JoystickButton15 ==            
 * JoystickButton16 ==            
 * JoystickButton17 ==            
 * JoystickButton18 ==            
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */




/*
 * THE 8BITDO WAS NOT IN MAC MODE DURING THIS TEST
 * Mac recoginized it as '8BitDo'
 * when in mac mode, it is recognized as 'Wireless Controller'
 * 
 * JoystickButton0  == "Fire1"       == A
 * JoystickButton1  == "Fire2"       == B
 * JoystickButton2  == "Fire3"       == *Home*
 * JoystickButton3  ==  N/A          == X
 * JoystickButton4  ==  "Jump"       == Y
 * JoystickButton5  ==            ???
 * JoystickButton6  ==            L1
 * JoystickButton7  ==            R1
 * JoystickButton8  ==            L2
 * JoystickButton9  ==            R2
 * JoystickButton10 ==            -(select)
 * JoystickButton11 ==            +(start)
 * JoystickButton12 ==            ???
 * JoystickButton13 ==            L3
 * JoystickButton14 ==            R3
 * JoystickButton15 ==            ???
 * JoystickButton16 ==            ???
 * JoystickButton17 ==            ???
 * JoystickButton18 ==            ???
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 

            //if (Input.GetKeyDown(KeyCode.JoystickButton0))
            //{ Debug.Log(KeyCode.JoystickButton0); }
            //if (Input.GetKeyDown(KeyCode.JoystickButton1))
            //{ Debug.Log(KeyCode.JoystickButton1); }
            //if (Input.GetKeyDown(KeyCode.JoystickButton2))
            //{ Debug.Log(KeyCode.JoystickButton2); }
            //if (Input.GetKeyDown(KeyCode.JoystickButton3))
            //{ Debug.Log(KeyCode.JoystickButton3); }
            //if (Input.GetKeyDown(KeyCode.JoystickButton4))
            //{ Debug.Log(KeyCode.JoystickButton4); }
            //if (Input.GetKeyDown(KeyCode.JoystickButton5))
            //{ Debug.Log(KeyCode.JoystickButton5); }
            //if (Input.GetKeyDown(KeyCode.JoystickButton6))
            //{ Debug.Log(KeyCode.JoystickButton6); }
            //if (Input.GetKeyDown(KeyCode.JoystickButton7))
            //{ Debug.Log(KeyCode.JoystickButton7); }
            //if (Input.GetKeyDown(KeyCode.JoystickButton8))
            //{ Debug.Log(KeyCode.JoystickButton8); }
            //if (Input.GetKeyDown(KeyCode.JoystickButton9))
            //{ Debug.Log(KeyCode.JoystickButton9); }
            //if (Input.GetKeyDown(KeyCode.JoystickButton10))
            //{ Debug.Log(KeyCode.JoystickButton10); }
            //if (Input.GetKeyDown(KeyCode.JoystickButton11))
            //{ Debug.Log(KeyCode.JoystickButton11); }
            //if (Input.GetKeyDown(KeyCode.JoystickButton12))
            //{ Debug.Log(KeyCode.JoystickButton12); }
            //if (Input.GetKeyDown(KeyCode.JoystickButton13))
            //{ Debug.Log(KeyCode.JoystickButton13); }
            //if (Input.GetKeyDown(KeyCode.JoystickButton14))
            //{ Debug.Log(KeyCode.JoystickButton14); }
            //if (Input.GetKeyDown(KeyCode.JoystickButton15))
            //{ Debug.Log(KeyCode.JoystickButton15); }
            //if (Input.GetKeyDown(KeyCode.JoystickButton16))
            //{ Debug.Log(KeyCode.JoystickButton16); }
            //if (Input.GetKeyDown(KeyCode.JoystickButton17))
            //{ Debug.Log(KeyCode.JoystickButton17); }
            //if (Input.GetKeyDown(KeyCode.JoystickButton18))
            //{ Debug.Log(KeyCode.JoystickButton18); }
            //if (Input.GetKeyDown(KeyCode.JoystickButton19))
            //{ Debug.Log(KeyCode.JoystickButton19); }


            //if (Input.GetButtonDown("Horizontal"))
            //{ Debug.Log("Horizontal"); }
            //if (Input.GetButtonDown("Vertical"))
            //{ Debug.Log("Vertical"); }
            //if (Input.GetButtonDown("Fire1"))
            //{ Debug.Log("Fire1"); }
            //if (Input.GetButtonDown("Fire2"))
            //{ Debug.Log("Fire2 "); }
            //if (Input.GetButtonDown("Fire3"))
            //{ Debug.Log("Fire3 "); }
            //if (Input.GetButtonDown("Jump"))
            //{ Debug.Log("Jump"); }
            //if (Input.GetButtonDown("Mouse X"))
            //{ Debug.Log("Mouse X"); }
            //if (Input.GetButtonDown("Mouse Y"))
            //{ Debug.Log("Mouse Y"); }
            //if (Input.GetButtonDown("Mouse ScrollWheel"))
            //{ Debug.Log("Mouse ScrollWheel"); }
 */