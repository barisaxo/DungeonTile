using UnityEngine;

public class RPGBattleMenu : MonoBehaviour
{
    public RPGGM rpggm;
    public RPGBattleManager bm;

    public int selectedOption, selectedNME, cursorPos;

    Color[] cursorColor;

    public enum MenuState { colorSelect, nmeSelect, waiting };//used in InputKey.cs
    public MenuState menuState = MenuState.nmeSelect;

    public enum KeyPress
    { LeftKey, RightKey, UpKey, DownKey, fromSnmeO, fromInitalize, fromSCO, fromCheckNMEColor }

    public void SetUp()
    {
        bm = rpggm.bm;

        /*create custom colors for unhighlighted options:*/
        cursorColor = new Color[8];
        //cursorColor[0] = new Color(.75f, .75f, .75f, .55f);//greyed white
        cursorColor[0] = new Color(.75f, .15f, .15f, .55f);//greyed red
        cursorColor[1] = new Color(.15f, .75f, .15f, .55f);//greyed green
        cursorColor[2] = new Color(.15f, .15f, .75f, .55f);//greyed blue
        cursorColor[3] = new Color(.15f, .75f, .75f, .55f);//greyed cyan
        cursorColor[4] = new Color(.75f, .15f, .75f, .55f);//greyed magenta
        cursorColor[5] = new Color(.75f, .75f, .15f, .55f);//greyed yellow
        //cursorColor[7] = new Color(.15f, .15f, .15f, .55f);//greyed black


        Initialize();
    }

    /*initializes battle menu cursor & nme position*/
    public void Initialize()
    {
        selectedNME = 0;
        cursorPos = 0;
        OptionSelect(KeyPress.fromInitalize);
        NMESelect(KeyPress.fromInitalize);
    }


    public void OptionSelect(KeyPress key)
    {
        /* Upon recieving a key press on an Option in the battle menu: */

        /* un-highlights the color of the current cursor position
         * checks and removes the borderSR from the ColorFlux
         * makes the option border invisible */

        bm.optionSR[cursorPos].color = cursorColor[cursorPos];

        if (bm.hudSR.Contains(bm.optionBorderSR[cursorPos]))
        { bm.hudSR.Remove(bm.optionBorderSR[cursorPos]); }

        bm.optionBorderSR[cursorPos].color = new Color(0, 0, 0, 0);

        switch (key)
        {
            case KeyPress.fromSnmeO: break; /* from SelectNMEOption() */

            case KeyPress.fromInitalize: /* from Initialize()
                sets all options to greyed-out(unhighlighted) */
                for (int i = 0; i < bm.optionSR.Count; i++)
                {
                    bm.optionSR[i].color = cursorColor[i];
                    bm.optionBorderSR[i].color = new Color(0, 0, 0, 0);
                }
                return;

            case KeyPress.DownKey: cursorPos++; break; /* move cursor Down */

            case KeyPress.UpKey: cursorPos--; break; /* move cursor Up */

            case KeyPress.LeftKey: cursorPos -= 3; break; /* move cursor Left*/

            case KeyPress.RightKey: cursorPos += 3; break; /* move cursor Right */
        }

        /*clamp the cursor position to avoid out of bounds */
        cursorPos = Mathf.Clamp(cursorPos, 0, bm.optionSR.Count - 1);

        //Debug.Log("SelectedNME: " + selectedNME + "; cursorPos: " + cursorPos);

        /* set the option border color to match the HUDs current color
         * add option border to the colorFlux */
        bm.optionBorderSR[cursorPos].color = bm.borderSR[0].color;
        bm.hudSR.Add(bm.optionBorderSR[cursorPos]);

        /* highlight the new cursor position */
        CursorColorer(cursorPos);
    }

    void CursorColorer(int ci)
    {/* these are the highlighted colors for the options */
        switch (ci)
        {
            //case 0: bm.optionSR[cursorPos].color = Color.white; break;
            case 0: bm.optionSR[cursorPos].color = Color.red; break;
            case 1: bm.optionSR[cursorPos].color = Color.green; break;
            case 2: bm.optionSR[cursorPos].color = Color.blue; break;
            case 3: bm.optionSR[cursorPos].color = Color.cyan; break;
            case 4: bm.optionSR[cursorPos].color = Color.magenta; break;
            case 5: bm.optionSR[cursorPos].color = Color.yellow; break;
                //case 7: bm.optionSR[cursorPos].color = Color.black; break;
        }
    }

    public void SelectColorOption()
    {
        menuState = MenuState.nmeSelect;

        if (bm.hudSR.Contains(bm.optionBorderSR[cursorPos]))
        { bm.hudSR.Remove(bm.optionBorderSR[cursorPos]); }

        bm.optionSR[cursorPos].color = cursorColor[cursorPos];
        bm.optionBorderSR[cursorPos].color = new Color(0, 0, 0, 0);

        selectedOption = cursorPos;

        bm.nmeSR[selectedNME].color = cursorColor[cursorPos];
        cursorPos = selectedNME;
        //Debug.Log("SelectedNME: " + selectedNME + "; cursorPos: " + cursorPos);

        bm.battleSystem.CheckNMEColor(selectedNME, selectedOption, bm.nmeAC);

        NMESelect(KeyPress.fromSCO);
    }

    public void SelectNMEOption()
    {
        if (bm.nmeGO.Count > 0)
        {
            menuState = MenuState.colorSelect;
            selectedNME = cursorPos;
            //Debug.Log("SelectedNME: " + selectedNME + "; cursorPos: " + cursorPos);
            bm.nmeBorderSR[cursorPos].color = new Color(0, 0, 0, 0);
            cursorPos = selectedOption;

            OptionSelect(KeyPress.fromSnmeO);
            NMESelect(KeyPress.fromSnmeO);
        }
    }

    public void NMESelect(KeyPress key)
    {
        if (menuState == MenuState.waiting)
        { return; }

        switch (key)
        {
            case KeyPress.fromSnmeO://from SelectNMEOption()
                if (!bm.hudSR.Contains(bm.nmeBorderSR[selectedNME]))
                {
                    bm.hudSR.Add(bm.nmeBorderSR[selectedNME]);

                    //Debug.Log("MM.NMESelect -2: ADD bsr[electedNME] to Hud: "
                    //+ bm.nmeBorderSR[selectedNME]);
                }

                return;

            case KeyPress.fromInitalize://from Initialize()
                if (bm.nmeAC.Count > 0)
                { rpggm.audioManager.RollAudio(bm.nmeAC[cursorPos]); }

                break;

            case KeyPress.fromCheckNMEColor://from BattleSystem.CheckNMEColor();
                if (bm.nmeAC.Count > 0)
                { rpggm.audioManager.RollAudio(bm.nmeAC[cursorPos]); break; }

                else
                { rpggm.audioManager.RollOffAudio(); return; }

            case KeyPress.fromSCO: break;//from SelectColorOption()

            case KeyPress.LeftKey://Left
                if (cursorPos - 1 < 0) { return; }

                //sets old color of nmeBG
                if (bm.hudSR.Contains(bm.nmeBorderSR[cursorPos]))
                {
                    bm.hudSR.Remove(bm.nmeBorderSR[cursorPos]);
                    //Debug.Log("MMremoved.NMEselect.case 3.nmeBorderSR[cursorPos] from hud: "
                    //+ bm.nmeBorderSR[cursorPos]);
                }

                bm.nmeBorderSR[cursorPos].color = new Color(0, 0, 0, 0);

                cursorPos--;

                if (rpggm.audioManager.audioState == RPGAudioManager.AudioState.NotRolling)
                { rpggm.audioManager.RollAudio(bm.nmeAC[cursorPos]); }

                else { rpggm.audioManager.QueAC(bm.nmeAC[cursorPos]); }

                break;

            case KeyPress.RightKey://Right
                if (cursorPos + 1 > bm.nmeAC.Count - 1) { return; }

                //sets old color of nmeBG
                if (bm.hudSR.Contains(bm.nmeBorderSR[cursorPos]))
                {
                    bm.hudSR.Remove(bm.nmeBorderSR[cursorPos]);

                    //Debug.Log("MMremoved.NMESelect.case 4.nmeBorderSR[cursorPos] from hud: " + bm.nmeBorderSR[cursorPos]);
                }

                bm.nmeBorderSR[cursorPos].color = new Color(0, 0, 0, 0);

                cursorPos++;

                if (rpggm.audioManager.audioState == RPGAudioManager.AudioState.NotRolling)
                { rpggm.audioManager.RollAudio(bm.nmeAC[cursorPos]); }

                else { rpggm.audioManager.QueAC(bm.nmeAC[cursorPos]); }

                break;
        }

        //Debug.Log("SelectedNME: " + selectedNME + "; cursorPos: " + cursorPos);

        if (bm.nmeBorderSR.Count > 0)
        {
            bm.nmeBorderSR[cursorPos].color = bm.borderSR[0].color;

            if (!bm.hudSR.Contains(bm.nmeBorderSR[cursorPos]))
            {
                bm.hudSR.Add(bm.nmeBorderSR[cursorPos]);

                //Debug.Log("MMadded.end.nmeBorderSR[cursorPos] to hud: " + bm.nmeBorderSR[cursorPos]);
            }
        }
    }




}