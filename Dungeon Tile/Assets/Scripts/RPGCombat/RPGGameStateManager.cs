using UnityEngine;
using System.Collections;

public class RPGGameStateManager : MonoBehaviour
{
    public RPGGM rpggm;
    public RPGBattleManager bm;

    public GameObject blackScreen;
    public SpriteRenderer blackScreenSR;

    public bool battleWon;

    public enum GameState
    {
        Start,
        Explore,
        Battle,
        FadingOut,
        FadeOutComplete,
        InMenu,
        Returning,
    }

    public GameState gameState = GameState.Start;
    public GameState queuedGS;

    private void Start()
    {
        bm = rpggm.bm;
        blackScreen = new GameObject("Black Screen");
        blackScreenSR = blackScreen.AddComponent<SpriteRenderer>();
        blackScreenSR.sprite = rpggm.assetSub.sprite[3];
        blackScreenSR.color = Color.clear;
        blackScreen.transform.SetParent(gameObject.transform);
        blackScreen.transform.position = new Vector3(
            rpggm.myCam.gameObject.transform.position.x,
            rpggm.myCam.gameObject.transform.position.y, -5);
        blackScreen.transform.localScale = new Vector3(32, 18, 1);
    }



    public void StateChange(GameState gs)
    {
        if (gameState == GameState.FadingOut)
        { return; }

        if (gameState != GameState.FadeOutComplete)
        {
            gameState = GameState.FadingOut;
            queuedGS = gs;

            StartCoroutine(FadingOutOutToBlack());
            return;
        }

        switch (gs)
        {
            case GameState.Battle:
                gameState = GameState.Battle;
                rpggm.movementSub.stepCounter = 0;
                rpggm.audioManager.PauseExploreMusic();
                rpggm.board.SetActive(false);
                bm.gameObject.SetActive(true);
                bm.nme.EnableNME();
                bm.battleMenu.Initialize();
                StartCoroutine(rpggm.colorFlux.ColorChange());
                return;

            case GameState.Explore:
                gameState = GameState.Explore;
                bm.gameObject.SetActive(false);
                rpggm.board.SetActive(true);
                rpggm.audioManager.PlayExploreMusic();
                return;

            case GameState.InMenu:
                gameState = GameState.InMenu;
                rpggm.board.gameObject.SetActive(false);
                rpggm.startScreen.gameObject.SetActive(false);
                rpggm.audioManager.RollOffAudio();
                rpggm.gameMenu.gameObject.SetActive(true);
                return;

            case GameState.Returning:
                rpggm.audioManager.RollOffAudio();
                rpggm.gm.gameStateManager.GameStateChange(GameStateManager.GameState.BoardGame);
                return;
        }

    }

    IEnumerator FadingOutOutToBlack()
    {
        float a = blackScreenSR.color.a;

        if (a < 1)
        {
            a += Time.deltaTime;
            //Debug.Log(a);
            blackScreenSR.color = new Color(0, 0, 0, a);
            yield return new WaitForEndOfFrame();
            StartCoroutine(FadingOutOutToBlack());
        }

        else
        {
            if (battleWon)
            {
                battleWon = false;
                yield return new WaitForEndOfFrame();
                gameState = GameState.FadeOutComplete;
                StateChange(GameState.Returning);
            }
            else
            {
                yield return new WaitForEndOfFrame();
                gameState = GameState.FadeOutComplete;
                StateChange(queuedGS);
                StartCoroutine(FadingInToClear());
            }
        }
    }

    private void OnEnable()
    {
        if (gameState != GameState.Start)
        {
            rpggm.audioManager.explorePlaybackPos = 0f;
            gameState = GameState.Explore;
            // queuedGS = GameState.Explore;
            //StartCoroutine(FadingInToClear());
            StateChange(GameState.Explore);
        }
        //if (blackScreenSR)
        //{ }
    }

    IEnumerator FadingInToClear()
    {
        if (gameState == GameState.FadingOut)
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