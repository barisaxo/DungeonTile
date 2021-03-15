using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RPGStartScreen : MonoBehaviour
{
    public RPGGM rpggm;

    public SpriteRenderer sr;
    Text text;
    float timer;
    Canvas canvas;

    void Start()
    {
        gameObject.transform.position = rpggm.myCam.transform.position;
        transform.Translate(new Vector3(0, 0, 5));
        sr = gameObject.AddComponent<SpriteRenderer>();

        canvas = gameObject.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;

        Font ArialFont = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
        text = gameObject.AddComponent<Text>();
        text.alignment = TextAnchor.MiddleCenter;
        text.resizeTextForBestFit = true;
        text.font = ArialFont;
        text.material = ArialFont.material;
        //gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(1000, 400);
        timer = 6;

        StartCoroutine(CountDownToStart());
    }

    public void DisableStartScreen()
    { timer = 0; }

    IEnumerator CountDownToStart()
    {
        timer -= Time.deltaTime;

        text.text =
            "press 'TAB' for menu\n\n" +
            "This message will self destruct in\n" + (int)timer + " seconds";

        if ((int)timer == 0) { text.text = "good luck... punk"; }

        if (timer <= 0)
        {
            rpggm.gameStateManager.StateChange(RPGGameStateManager.GameState.Explore);
            gameObject.SetActive(false);
        }

        if (timer > 0)
        {
            yield return new WaitForEndOfFrame();
            StartCoroutine(CountDownToStart());
        }
    }
}
