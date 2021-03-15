using UnityEngine;

//TODO: make an update-loop script to be the only script with void Update() ?

public class RPGInputKey : MonoBehaviour
{
    public RPGGM rpggm;
    public RPGBattleManager bm;

    public Test gamepad;
    public Vector2 ls;
    public float rsRZ;
    public float rsZ;

    private void Start()
    {
        bm = rpggm.bm;

        gamepad = new Test();

        gamepad.N30.Enable();

        //gamepad.N30.A.performed += ctx => SayIt("A");
        //gamepad.N30.B.performed += ctx => SayIt("B");
        //gamepad.N30.X.performed += ctx => SayIt("X");
        //gamepad.N30.Y.performed += ctx => SayIt("Y");
        //gamepad.N30.L1.performed += ctx => SayIt("L1");
        //gamepad.N30.R1.performed += ctx => SayIt("R1");
        //gamepad.N30.L2.performed += ctx => SayIt("L2");
        //gamepad.N30.R2.performed += ctx => SayIt("R2");
        //gamepad.N30.L3.performed += ctx => SayIt("L3");
        //gamepad.N30.R3.performed += ctx => SayIt("R3");
        //gamepad.N30.Start.performed += ctx => SayIt("+");
        //gamepad.N30.Select.performed += ctx => SayIt("-");
        //gamepad.N30.Home.performed += ctx => SayIt("Home");
        //gamepad.N30.DPadUp.performed += ctx => bgm.movement.Move(BGMovement.Direction.North);
        //gamepad.N30.DPadDown.performed += ctx => bgm.movement.Move(BGMovement.Direction.South);
        //gamepad.N30.DPadLeft.performed += ctx => bgm.movement.Move(BGMovement.Direction.West);
        //gamepad.N30.DPadRight.performed += ctx => bgm.movement.Move(BGMovement.Direction.East);
        //gamepad.N30.LeftStick.performed += ctx => ls = ctx.ReadValue<Vector2>();
        //gamepad.N30.LeftStick.canceled += ctx => ls = Vector2.zero;
        //gamepad.N30.RightStickRZ.performed += ctx => rsRZ = ctx.ReadValue<float>();
        //gamepad.N30.RightStickRZ.canceled += ctx => rsRZ = 0f;
        //gamepad.N30.RightStickZ.performed += ctx => rsZ = ctx.ReadValue<float>();
        //gamepad.N30.RightStickZ.canceled += ctx => rsZ = 0f;

    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            switch (rpggm.gameStateManager.gameState)
            {
                case RPGGameStateManager.GameState.Battle:
                    switch (bm.battleMenu.menuState)
                    {
                        case RPGBattleMenu.MenuState.colorSelect:
                            if (Input.GetKeyDown(KeyCode.DownArrow))
                            { bm.battleMenu.OptionSelect(RPGBattleMenu.KeyPress.DownKey); }

                            if (Input.GetKeyDown(KeyCode.UpArrow))
                            { bm.battleMenu.OptionSelect(RPGBattleMenu.KeyPress.UpKey); }

                            if (Input.GetKeyDown(KeyCode.LeftArrow))
                            { bm.battleMenu.OptionSelect(RPGBattleMenu.KeyPress.LeftKey); }

                            if (Input.GetKeyDown(KeyCode.RightArrow))
                            { bm.battleMenu.OptionSelect(RPGBattleMenu.KeyPress.RightKey); }

                            if (Input.GetKeyDown(KeyCode.Return))
                            { bm.battleMenu.SelectColorOption(); }

                            break;

                        case RPGBattleMenu.MenuState.nmeSelect:
                            if (Input.GetKeyDown(KeyCode.LeftArrow))
                            { bm.battleMenu.NMESelect(RPGBattleMenu.KeyPress.LeftKey); }

                            if (Input.GetKeyDown(KeyCode.RightArrow))
                            { bm.battleMenu.NMESelect(RPGBattleMenu.KeyPress.RightKey); }

                            if (Input.GetKeyDown(KeyCode.Return))
                            { bm.battleMenu.SelectNMEOption(); }

                            break;
                    }

                    break;


                case RPGGameStateManager.GameState.Start:
                    if (Input.GetKeyDown(KeyCode.Tab))
                    {
                        rpggm.gameStateManager.StateChange(RPGGameStateManager.GameState.InMenu);
                        return;
                    }
                    //AnyKey (except tab) to disable start screen.
                    rpggm.startScreen.DisableStartScreen();
                    return;


                case RPGGameStateManager.GameState.InMenu:
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        rpggm.gameMenu.gameObject.SetActive(false);
                        rpggm.gameStateManager.StateChange(RPGGameStateManager.GameState.Explore);
                        return;
                    }

                    if (Input.GetKeyDown(KeyCode.Escape))
                    {
                        rpggm.gameMenu.gameObject.SetActive(false);
                        rpggm.gameStateManager.StateChange(RPGGameStateManager.GameState.Returning);
                        //rpggm.gm.gameStateManager.GameStateChange(GameStateManager.GameState.BoardGame);
                    }

                    break;

                case RPGGameStateManager.GameState.Explore:
                    if (Input.GetKeyDown(KeyCode.Tab))
                    {
                        rpggm.gameStateManager.StateChange(RPGGameStateManager.GameState.InMenu);
                    }

                    break;
            }

            //if (Input.GetKeyDown(KeyCode.Escape))
            //{
            //    //rpggm.gameStateManager.gameState = RPGGameStateManager.GameState.Start;
            //    rpggm.gm.gameStateManager.GameStateChange(GameStateManager.GameState.BoardGame);
            //    //#if UNITY_EDITOR
            //    //                UnityEditor.EditorApplication.isPlaying = false;
            //    //#endif
            //    //Application.Quit();
            //}
        }

        if (Input.anyKey)
        {
            switch (rpggm.gameStateManager.gameState)
            {
                case RPGGameStateManager.GameState.Explore:

                    //A TEST SHOWS THAT WHEN PRESSING MULTIPLE KEYS:
                    //  W & S WON'T TRIGGER AT THE SAME TIME (Macbook Pro)
                    // ie the W && S statement below won't return if other keys are also pressed
                    //if (Input.GetKey(KeyCode.A)) { Debug.Log("A"); }
                    //if (Input.GetKey(KeyCode.S)) { Debug.Log("S"); }
                    //if (Input.GetKey(KeyCode.D)) { Debug.Log("D"); }
                    //if (Input.GetKey(KeyCode.W)) { Debug.Log("W"); }

                    if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
                    { return; }

                    if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S))
                    { return; }

                    if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
                    { rpggm.movementSub.Move(RPGMovementSub.Direction.NorthWest); return; }

                    if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
                    { rpggm.movementSub.Move(RPGMovementSub.Direction.SouthWest); return; }

                    if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
                    { rpggm.movementSub.Move(RPGMovementSub.Direction.SouthEast); return; }

                    if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
                    { rpggm.movementSub.Move(RPGMovementSub.Direction.NorthEast); return; }

                    if (Input.GetKey(KeyCode.A))
                    { rpggm.movementSub.Move(RPGMovementSub.Direction.West); return; }

                    if (Input.GetKey(KeyCode.D))
                    { rpggm.movementSub.Move(RPGMovementSub.Direction.East); return; }

                    if (Input.GetKey(KeyCode.W))
                    { rpggm.movementSub.Move(RPGMovementSub.Direction.North); return; }

                    if (Input.GetKey(KeyCode.S))
                    { rpggm.movementSub.Move(RPGMovementSub.Direction.South); return; }

                    break;
            }
        }
    }
}
