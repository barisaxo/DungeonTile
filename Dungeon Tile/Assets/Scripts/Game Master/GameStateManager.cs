using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public GM gm;

    public enum GameState
    {
        Start,
        Menu,
        BoardGame,
        Platformer,
        CardGame,
        RPGCombat,
        FPS,
        TDShooter,
        TrwoDee,
        Fading,
        FadeOutComplete
    }
    public GameState gameState = GameState.BoardGame;
    public GameState queuedGS;
    public GameObject oldGSGO;
    public GameObject blackScreenGrip;
    public GameObject blackScreen;
    public SpriteRenderer blackScreenSR;

    void Start()
    {
        blackScreenGrip = new GameObject("Black Screen Grip");
        blackScreenGrip.transform.SetParent(gameObject.transform);

        blackScreen = new GameObject("Black Screen");
        blackScreenSR = blackScreen.AddComponent<SpriteRenderer>();
        blackScreenSR.sprite = gm.assets.sprite[3];
        blackScreenSR.color = Color.clear;
        blackScreen.transform.SetParent(blackScreenGrip.transform);
        blackScreen.transform.position = blackScreenGrip.transform.position;
        blackScreen.transform.Translate(0, 0, 1);
        blackScreen.transform.localScale = new Vector3(32, 18, 1);
    }

    public void GameStateChange(GameState newGS)
    {
        if (gameState == GameState.Fading) { return; }

        if (gameState != GameState.FadeOutComplete)
        {
            switch (gameState)
            {
                case GameState.RPGCombat:
                    //gm.rpgGM.gameObject.SetActive(false);

                    oldGSGO = gm.rpgGM.gameObject;
                    blackScreenGrip.transform.position = gm.rpgGM.myCam.transform.position;
                    StartCoroutine(FadingOutToBlack());
                    break;

                case GameState.BoardGame:
                    //gm.bgGM.gameObject.SetActive(false);

                    oldGSGO = gm.bgGM.gameObject;
                    blackScreenGrip.transform.position = gm.bgGM.player.transform.position;
                    StartCoroutine(FadingOutToBlack());
                    break;
            }

            queuedGS = newGS;
            gameState = GameState.Fading;
            return;
        }


        else
        {
            switch (newGS)
            {
                case GameState.Start: break;
                case GameState.Menu: break;

                case GameState.BoardGame:
                    gm.bgGM.gameObject.SetActive(true);
                    blackScreenGrip.transform.position = gm.bgGM.player.transform.position;
                    gameState = GameState.BoardGame;
                    break;

                case GameState.Platformer:
                    break;

                case GameState.CardGame: break;

                case GameState.RPGCombat:
                    gm.rpgGM.gameObject.SetActive(true);
                    blackScreenGrip.transform.position = gm.rpgGM.myCam.transform.position;
                    gameState = GameState.RPGCombat;
                    break;

                case GameState.FPS: break;
                case GameState.TDShooter: break;
                case GameState.TrwoDee: break;

            }
        }
    }

    IEnumerator FadingOutToBlack()
    {
        float a = blackScreenSR.color.a;

        if (a < 1)
        {
            a += Time.deltaTime;
            //Debug.Log(a);
            blackScreenSR.color = new Color(0, 0, 0, a);
            yield return new WaitForEndOfFrame();
            StartCoroutine(FadingOutToBlack());
        }

        else
        {
            yield return new WaitForEndOfFrame();
            gameState = GameState.FadeOutComplete;
            oldGSGO.SetActive(false);
            GameStateChange(queuedGS);
            StartCoroutine(FadingInToClear());
        }
    }

    IEnumerator FadingInToClear()
    {
        if (gameState == GameState.Fading)
        {
            yield return new WaitForEndOfFrame();
            StartCoroutine(FadingInToClear());
        }

        else
        {
            float a = blackScreenSR.color.a;

            if (a > 0)
            {
                a -= Time.deltaTime;
                blackScreenSR.color = new Color(0, 0, 0, a);
                yield return new WaitForEndOfFrame();
                StartCoroutine(FadingInToClear());
            }

            else
            {
                yield return null;
            }
        }
    }
}


/*
 * using UnityEngine;
using System.Collections;

public class RPGGameStateManager : MonoBehaviour
{
    public RPGGM gm;
    public RPGBattleManager bm;

    public GameObject blackScreen;
    public SpriteRenderer blackScreenSR;

    public enum GameState
    {
        Start,
        Explore,
        Battle,
        Fading,
        FadeOutComplete,
        InMenu,
    }

    public GameState gameState = GameState.Start;
    public GameState queuedGS;

    private void Start()
    {
        bm = gm.bm;
        blackScreen = new GameObject("Black Screen");
        blackScreenSR = blackScreen.AddComponent<SpriteRenderer>();
        blackScreenSR.sprite = gm.assetSub.sprite[3];
        blackScreenSR.color = Color.clear;
        blackScreen.transform.SetParent(gameObject.transform);
        blackScreen.transform.position = new Vector3(
            gm.myCam.gameObject.transform.position.x,
            gm.myCam.gameObject.transform.position.y, -5);
        blackScreen.transform.localScale = new Vector3(32, 18, 1);
    }

    public void StateChange(GameState newGS)
    {
        if (gameState == GameState.Fading) { return; }

        if (gameState != GameState.FadeOutComplete)
        {
            gameState = GameState.Fading;
            queuedGS = newGS;

            StartCoroutine(FadingOutToBlack());
            return;
        }

        switch (newGS)
        {
            case GameState.Battle:
                gameState = GameState.Battle;
                gm.movementSub.stepCounter = 0;
                gm.audioManager.PauseExploreMusic();
                gm.board.SetActive(false);
                bm.gameObject.SetActive(true);
                bm.nme.EnableNME();
                bm.battleMenu.Initialize();
                StartCoroutine(gm.colorFlux.ColorChange());
                return;

            case GameState.Explore:
                gameState = GameState.Explore;
                bm.gameObject.SetActive(false);
                gm.board.SetActive(true);
                gm.audioManager.PlayExploreMusic();
                return;

            case GameState.InMenu:
                gameState = GameState.InMenu;
                gm.board.gameObject.SetActive(false);
                gm.startScreen.gameObject.SetActive(false);
                gm.audioManager.RollOffAudio();
                gm.gameMenu.gameObject.SetActive(true);
                return;
        }

    }

    IEnumerator FadingOutToBlack()
    {
        float a = blackScreenSR.color.a;

        if (a < 1)
        {
            a += Time.deltaTime;
            //Debug.Log(a);
            blackScreenSR.color = new Color(0, 0, 0, a);
            yield return new WaitForEndOfFrame();
            StartCoroutine(FadingOutToBlack());
        }

        else
        {
            yield return new WaitForEndOfFrame();
            gameState = GameState.FadeOutComplete;
            StateChange(queuedGS);
            StartCoroutine(FadingInToClear());
        }
    }

    IEnumerator FadingInToClear()
    {
        if (gameState == GameState.Fading)
        {
            yield return new WaitForEndOfFrame();
            StartCoroutine(FadingInToClear());
        }

        else
        {
            float a = blackScreenSR.color.a;

            if (a > 0)
            {
                a -= Time.deltaTime;
                blackScreenSR.color = new Color(0, 0, 0, a);
                yield return new WaitForEndOfFrame();
                StartCoroutine(FadingInToClear());
            }

            else { yield return null; }
        }
    }
}
*/