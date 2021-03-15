using System.Collections;
using UnityEngine;

public class RPGColorFlux : MonoBehaviour
{
    public RPGGM rpggm;
    public RPGBattleManager bm;

    Camera cam;
    public float rc, gc, bc;
    bool rs, gs, bs;
    public float r, g, b, rr, ra, br, ba, gr, ga, ri, gi, bi;

    void Start()
    {
        bm = rpggm.bm;

        cam = rpggm.myCam.cam;

        rs = true; gs = true; bs = true;
        r = Random.Range(.1f, .2f);
        g = Random.Range(.1f, .2f);
        b = Random.Range(.1f, .2f);
        rc = Random.Range(.003f, .008f);
        gc = Random.Range(.003f, .008f);
        bc = Random.Range(.003f, .008f);

        StartCoroutine(ColorChange());
    }


    void Update()
    {
        WeirdColorCycler();
    }

    void WeirdColorCycler()
    { // Weird Color Cycler - might want to simpify

        //red
        if (rs == true)
        {
            r += rc * Time.deltaTime * 5;
            if (r >= .25f && rs == true) { rs = false; }
        }
        else
        {
            r -= rc * Time.deltaTime * 5;
            if (r <= .01f && rs == false) { rs = true; }
        }

        //green
        if (gs == true)
        {
            g += gc * Time.deltaTime * 5;
            if (g >= .25f && gs == true) { gs = false; }
        }
        else
        {
            g -= gc * Time.deltaTime * 5;
            if (g <= .01f && gs == false) { gs = true; }
        }

        //blue
        if (bs == true)
        {
            b += bc * Time.deltaTime * 5;
            if (b >= .25f && bs == true) { bs = false; }
        }
        else
        {
            b -= bc * Time.deltaTime * 5;
            if (b <= .01f && bs == false) { bs = true; }
        }

        cam.backgroundColor = new Color(r, g, b);
    }

    public IEnumerator ColorChange()
    {
        if (rpggm.gameStateManager.gameState == RPGGameStateManager.GameState.Battle)
        {
            Color color = new Color(
                 Random.Range(.3f, .4f),
                 Random.Range(.3f, .4f),
                 Random.Range(.3f, .4f),
                 1);

            for (int i = 0; i < bm.hudSR.Count; i++)
            {
                if (bm.hudSR[i])
                    bm.hudSR[i].color = color;
            }

            for (int i = 0; i < bm.borderSR.Count; i++)
            {
                if (bm.borderSR[i])
                    bm.borderSR[i].color = color;
            }

            yield return new WaitForSeconds(Random.Range(.2f, .4f));

            StartCoroutine(ColorChange());
        }
    }
}