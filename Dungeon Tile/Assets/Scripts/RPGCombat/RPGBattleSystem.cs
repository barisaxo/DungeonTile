using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGBattleSystem : MonoBehaviour
{
    public RPGGM rpggm;
    public RPGBattleManager bm;
    public AudioClip[] audioClips = new AudioClip[7];

    private void Start()
    { bm = rpggm.bm; }

    public void CheckNMEColor(int selectedNME, int selectedOption, List<AudioClip> ac)
    {//TODO over head text display for feedback: "Your Magic Cadenced NME1 !" > "Your Magic Only Made NME1 angry!"

        bm.nmeAC = ac;
        audioClips = rpggm.assetSub.audioClips;

        //checks if the 
        if (ac[selectedNME] == audioClips[selectedOption])
        {//correct
            //Debug.Log("Good Answer!"); //defeat(DISABLE) NME
            if (bm.hudSR.Contains(bm.nmeBorderSR[selectedNME]))
            {
                bm.hudSR.Remove(bm.nmeBorderSR[selectedNME]);
                //Debug.Log("BS.checkNMEColor Removed nmeBorderSR[selectedNME] from hud: " + selectedNME);
            }

            bm.nmeAC.Remove(bm.nmeAC[selectedNME]);
            bm.nmeSR.Remove(bm.nmeSR[selectedNME]);
            bm.nmeBorderSR[selectedNME].color = new Color(0, 0, 0, 0);
            bm.nmeBorderSR.Remove(bm.nmeBorderSR[selectedNME]);
            bm.nmeGO[selectedNME].SetActive(false);
            bm.nmeGO.Remove(bm.nmeGO[selectedNME]);

            //Debug.Log("BS.checkNMEColor REMOVED nmeBorderSR[selectedNME] from BSRlist: " + selectedNME);
            if (bm.nmeGO.Count > 0)
            {
                bm.battleMenu.cursorPos = 0;
                bm.battleMenu.NMESelect(RPGBattleMenu.KeyPress.fromCheckNMEColor);
            }

            else
            {
                StartCoroutine(CheckingForWait());
            }
        }

        else
        {//for incorrect answers
            //Debug.Log("WRONG!");
            var old = bm.nmeAC[selectedNME];
            for (int i = 0; i < 4; i++)
            {//change NME music//attempts to not repeat the same audio
                if (bm.nmeAC[selectedNME] == old)
                {
                    bm.nmeAC[selectedNME] = rpggm.assetSub.audioClips[Random.Range(3, 6)];
                }
                else { break; }
            }

            bm.battleMenu.menuState = RPGBattleMenu.MenuState.waiting;

            StartCoroutine(ScreenShake(0f, selectedNME, RPGBattleMenu.KeyPress.fromCheckNMEColor));

            //bm.battleMenu.cursorPos = selectedNME;
            //bm.battleMenu.NMESelect(BattleMenu.KeyPress.fromCheckNMEColor);
        }
    }

    IEnumerator CheckingForWait()
    {//After winning the battle, wait for the audio to roll off, then continue
        if (rpggm.audioManager.audioState == RPGAudioManager.AudioState.Rolling)
        {
            yield return new WaitForEndOfFrame();
            StartCoroutine(CheckingForWait());
        }

        else
        {//continued final actions after winning
            rpggm.gameStateManager.battleWon = true;
            rpggm.gameStateManager.StateChange(RPGGameStateManager.GameState.Explore);
        }
    }

    IEnumerator ScreenShake(float f, int selectedNME, RPGBattleMenu.KeyPress fromKey)
    {
        if (f < .7f)
        {
            f += Time.deltaTime;

            rpggm.myCam.transform.position = new Vector3(Mathf.Sin(f) * Random.Range(-.15f, .15f),
                Mathf.Sin(f) * Random.Range(-.15f, .15f), -10);

            for (int i = 0; i < bm.hudSR.Count; i++)
            {//add red to borders
                bm.hudSR[i].color = new Color(
                    bm.hudSR[i].color.r + .00666f,
                    bm.hudSR[i].color.g,
                    bm.hudSR[i].color.b,
                    bm.hudSR[i].color.a);
            }

            for (int i = 0; i < bm.borderSR.Count; i++)
            {
                bm.borderSR[i].color = new Color(
                    bm.borderSR[i].color.r + .00666f,
                    bm.borderSR[i].color.g,
                    bm.borderSR[i].color.b,
                    bm.borderSR[i].color.a);
            }

            yield return new WaitForEndOfFrame();

            StartCoroutine(ScreenShake(f, selectedNME, fromKey));
        }

        else
        {//return camera to neutral position
            rpggm.myCam.transform.position = new Vector3(0, 0, -10);
            bm.battleMenu.menuState = RPGBattleMenu.MenuState.nmeSelect;
            bm.battleMenu.cursorPos = selectedNME;
            bm.battleMenu.NMESelect(RPGBattleMenu.KeyPress.fromCheckNMEColor);
        }

        yield return null;
    }
    //TODO NME TURN?
    /*
     * 
     */
}