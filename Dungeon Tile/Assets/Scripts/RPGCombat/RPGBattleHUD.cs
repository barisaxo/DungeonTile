using UnityEngine;

public class RPGBattleHUD : MonoBehaviour
{
    public RPGGM rpggm;
    public RPGBattleManager bm;
    public GameObject battleHUD;

    public void SetUp()
    {
        bm = rpggm.bm;
        Makeborders();
        MakeBattleMenu();
    }


    public void Makeborders()
    {
        /* assign a random darkish-color */
        Color color = new Color(
             Random.Range(.3f, .4f),
             Random.Range(.3f, .4f),
             Random.Range(.3f, .4f),
             1);

        /* create Battle HUD parent GameObject */
        battleHUD = new GameObject("Battle HUD");
        battleHUD.transform.position = new Vector3(0, 0, 0);
        battleHUD.transform.SetParent(bm.gameObject.transform);

        /*
         * Create Borders:
         *      Create gameObject
         *      add sprite renderer component
         *      add sprite renderer to list
         *      assign sprite
         *      assign color
         *      assign parent
         *      assign position
         *      assign scale(height and width)
         */

        //Left border
        GameObject leftWall = new GameObject("Left Wall");
        SpriteRenderer srL = leftWall.AddComponent<SpriteRenderer>();
        bm.borderSR.Add(srL);
        srL.sprite = rpggm.assetSub.sprite[3];
        srL.color = color;
        leftWall.transform.SetParent(battleHUD.transform);
        leftWall.transform.position = new Vector3(-14, 0, 0);
        leftWall.transform.localScale = new Vector3(.75f, 16, 1);


        //Top border
        GameObject topWall = new GameObject("Top Wall");
        SpriteRenderer srT = topWall.AddComponent<SpriteRenderer>();
        bm.borderSR.Add(srT);
        srT.sprite = rpggm.assetSub.sprite[3];
        srT.color = color;
        topWall.transform.SetParent(battleHUD.transform);
        topWall.transform.position = new Vector3(0, 7.75f, 0);
        topWall.transform.localScale = new Vector3(29, .75f, 1);

        //Right border
        GameObject rightWall = new GameObject("Right Wall");
        SpriteRenderer srR = rightWall.AddComponent<SpriteRenderer>();
        bm.borderSR.Add(srR);
        srR.sprite = rpggm.assetSub.sprite[3];
        srR.color = color;
        rightWall.transform.SetParent(battleHUD.transform);
        rightWall.transform.position = new Vector3(14, 0, 0);
        rightWall.transform.localScale = new Vector3(.75f, 16, 1);

        //Bottom border
        GameObject bottomWall = new GameObject("Bottom Wall");
        SpriteRenderer srB = bottomWall.AddComponent<SpriteRenderer>();
        bm.borderSR.Add(srB);
        srB.sprite = rpggm.assetSub.sprite[3];
        srB.color = color;
        bottomWall.transform.SetParent(battleHUD.transform);
        bottomWall.transform.position = new Vector3(0, -7.75f, 0);
        bottomWall.transform.localScale = new Vector3(29, .75f, 1);

        //Middle border
        GameObject midWall = new GameObject("Middle Wall");
        SpriteRenderer srM = midWall.AddComponent<SpriteRenderer>();
        bm.borderSR.Add(srM);
        srM.sprite = rpggm.assetSub.sprite[3];
        srM.color = color;
        midWall.transform.SetParent(battleHUD.transform);
        midWall.transform.position = new Vector3(0, -1.75f, 0);
        midWall.transform.localScale = new Vector3(29, .5f, 1);
    }

    public void MakeBattleMenu()
    {
        //Menus Parent Transform
        GameObject hudMenu = new GameObject("Hud Menu");
        hudMenu.transform.SetParent(battleHUD.transform);

        /*
         * Create Options:
         *      create Option gameObject
         *      add spriterenderer componnent
         *      assign sprite
         *      assign parent
         *      assign position
         *      add to list
         */

        ////Option One
        //GameObject option1 = new GameObject("Option One");
        //SpriteRenderer srO1 = option1.AddComponent<SpriteRenderer>();
        //srO1.sprite = rpggm.assetSub.sprite[3];
        //option1.transform.SetParent(hudMenu.transform);
        //option1.transform.position = new Vector3(-9, -4.75f, 0);
        //bm.optionSR.Add(srO1);


        //Option Two
        GameObject option2 = new GameObject("Option Two");
        SpriteRenderer srO2 = option2.AddComponent<SpriteRenderer>();
        srO2.sprite = rpggm.assetSub.sprite[3];
        option2.transform.SetParent(hudMenu.transform);
        option2.transform.position = new Vector3(-3, -2.75f, 0);
        bm.optionSR.Add(srO2);


        //Option Three
        GameObject option3 = new GameObject("Option Three");
        SpriteRenderer srO3 = option3.AddComponent<SpriteRenderer>();
        srO3.sprite = srO2.sprite = rpggm.assetSub.sprite[3];
        option3.transform.SetParent(hudMenu.transform);
        option3.transform.position = new Vector3(-3, -4.75f, 0);
        bm.optionSR.Add(srO3);


        //Option Four
        GameObject option4 = new GameObject("Option Four");
        SpriteRenderer srO4 = option4.AddComponent<SpriteRenderer>();
        srO4.sprite = srO2.sprite = rpggm.assetSub.sprite[3];
        option4.transform.SetParent(hudMenu.transform);
        option4.transform.position = new Vector3(-3, -6.75f, 0);
        bm.optionSR.Add(srO4);


        //Option Five
        GameObject option5 = new GameObject("Option Five");
        SpriteRenderer srO5 = option5.AddComponent<SpriteRenderer>();
        srO5.sprite = srO2.sprite = rpggm.assetSub.sprite[3];
        option5.transform.SetParent(hudMenu.transform);
        option5.transform.position = new Vector3(3, -2.75f, 0);
        bm.optionSR.Add(srO5);


        //Option Six
        GameObject option6 = new GameObject("Option Six");
        SpriteRenderer srO6 = option6.AddComponent<SpriteRenderer>();
        srO6.sprite = srO2.sprite = rpggm.assetSub.sprite[3];
        option6.transform.SetParent(hudMenu.transform);
        option6.transform.position = new Vector3(3, -4.75f, 0);
        bm.optionSR.Add(srO6);


        //Option Seven
        GameObject option7 = new GameObject("Option Seven");
        SpriteRenderer srO7 = option7.AddComponent<SpriteRenderer>();
        srO7.sprite = srO2.sprite = rpggm.assetSub.sprite[3];
        option7.transform.SetParent(hudMenu.transform);
        option7.transform.position = new Vector3(3, -6.75f, 0);
        bm.optionSR.Add(srO7);

        ////Option Eight
        //GameObject option8 = new GameObject("Option Eight");
        //SpriteRenderer srO8 = option8.AddComponent<SpriteRenderer>();
        //srO8.sprite = rpggm.assetSub.sprite[3];
        //option8.transform.SetParent(hudMenu.transform);
        //option8.transform.position = new Vector3(9, -4.75f, 0);
        //bm.optionSR.Add(srO8);


        /*
         * Create Icons for Options
         *      create gameobject
         *      assign parent
         *      add spriterenderer component
         *      assign sprite
         *      assign position
         *      fix position
         */


        //Option icon 2
        GameObject icon2 = new GameObject("Icon2");
        icon2.transform.SetParent(option2.transform);
        SpriteRenderer iconSR2 = icon2.AddComponent<SpriteRenderer>();
        iconSR2.sprite = rpggm.assetSub.chordQualitySprite[0];
        icon2.transform.position = option2.transform.position;
        icon2.transform.Translate(new Vector3(0, 0, -1));

        //Option icon 3
        GameObject icon3 = new GameObject("Icon3");
        icon3.transform.SetParent(option3.transform);
        SpriteRenderer iconSR3 = icon3.AddComponent<SpriteRenderer>();
        iconSR3.sprite = rpggm.assetSub.chordQualitySprite[1];
        icon3.transform.position = option3.transform.position;
        icon3.transform.Translate(new Vector3(0, 0, -1));

        //Option icon 4
        GameObject icon4 = new GameObject("Icon4");
        icon4.transform.SetParent(option4.transform);
        SpriteRenderer iconSR4 = icon4.AddComponent<SpriteRenderer>();
        iconSR4.sprite = rpggm.assetSub.chordQualitySprite[2];
        icon4.transform.position = option4.transform.position;
        icon4.transform.Translate(new Vector3(0, 0, -1));

        //Option icon 5
        GameObject icon5 = new GameObject("Icon5");
        icon5.transform.SetParent(option5.transform);
        SpriteRenderer iconSR5 = icon5.AddComponent<SpriteRenderer>();
        iconSR5.sprite = rpggm.assetSub.chordQualitySprite[3];
        icon5.transform.position = option5.transform.position;
        icon5.transform.Translate(new Vector3(0, 0, -1));

        //Option icon 6
        GameObject icon6 = new GameObject("Icon6");
        icon6.transform.SetParent(option6.transform);
        SpriteRenderer iconSR6 = icon6.AddComponent<SpriteRenderer>();
        iconSR6.sprite = rpggm.assetSub.chordQualitySprite[4];
        icon6.transform.position = option6.transform.position;
        icon6.transform.Translate(new Vector3(0, 0, -1));

        //Option icon 7
        GameObject icon7 = new GameObject("Icon7");
        icon7.transform.SetParent(option7.transform);
        SpriteRenderer iconSR7 = icon7.AddComponent<SpriteRenderer>();
        iconSR7.sprite = rpggm.assetSub.chordQualitySprite[5];
        icon7.transform.position = option7.transform.position;
        icon7.transform.Translate(new Vector3(0, 0, -1));



        /*
         * Create Option Border
         *      create Gameobject
         *      add sprite renderer component
         *      assign sprite
         *      add to list
         *      assign parent
         *      assign position
         *      assign scale
         *      fix position
         */


        ////Option One border
        //GameObject option1b = new GameObject("Option One Border");
        //SpriteRenderer sr1b = option1b.AddComponent<SpriteRenderer>();
        //sr1b.sprite = rpggm.assetSub.sprite[3];
        //bm.optionBorderSR.Add(sr1b);
        //option1b.transform.SetParent(option1.transform);
        //option1b.transform.position = option1.transform.position;
        //option1b.transform.localScale = new Vector3(1.3f, 1.3f, 1);
        //option1b.transform.Translate(new Vector3(0, 0, 10));



        //OptionTwoborder
        GameObject option2b = new GameObject("Option Two Border");
        SpriteRenderer sr2b = option2b.AddComponent<SpriteRenderer>();
        sr2b.sprite = rpggm.assetSub.sprite[3];
        bm.optionBorderSR.Add(sr2b);
        option2b.transform.SetParent(option2.transform);
        option2b.transform.position = option2.transform.position;
        option2b.transform.localScale = new Vector3(1.3f, 1.3f, 1);
        option2b.transform.Translate(new Vector3(0, 0, 10));



        //Option Three border
        GameObject option3b = new GameObject("Option Three Border");
        SpriteRenderer sr3b = option3b.AddComponent<SpriteRenderer>();
        sr3b.sprite = rpggm.assetSub.sprite[3];
        bm.optionBorderSR.Add(sr3b);
        option3b.transform.SetParent(option3.transform);
        option3b.transform.position = option3.transform.position;
        option3b.transform.localScale = new Vector3(1.3f, 1.3f, 1);
        option3b.transform.Translate(new Vector3(0, 0, 10));



        //Option Four border
        GameObject option4b = new GameObject("Option Four Border");
        SpriteRenderer sr4b = option4b.AddComponent<SpriteRenderer>();
        sr4b.sprite = rpggm.assetSub.sprite[3];
        bm.optionBorderSR.Add(sr4b);
        option4b.transform.SetParent(option4.transform);
        option4b.transform.position = option4.transform.position;
        option4b.transform.localScale = new Vector3(1.3f, 1.3f, 1);
        option4b.transform.Translate(new Vector3(0, 0, 10));



        //Option Five border
        GameObject option5b = new GameObject("Option Five Border");
        SpriteRenderer sr5b = option5b.AddComponent<SpriteRenderer>();
        sr5b.sprite = rpggm.assetSub.sprite[3];
        bm.optionBorderSR.Add(sr5b);
        option5b.transform.SetParent(option5.transform);
        option5b.transform.position = option5.transform.position;
        option5b.transform.localScale = new Vector3(1.3f, 1.3f, 1);
        option5b.transform.Translate(new Vector3(0, 0, 10));



        //Option Six border
        GameObject option6b = new GameObject("Option Six Border");
        SpriteRenderer sr6b = option6b.AddComponent<SpriteRenderer>();
        sr6b.sprite = rpggm.assetSub.sprite[3];
        bm.optionBorderSR.Add(sr6b);
        option6b.transform.SetParent(option6.transform);
        option6b.transform.position = option6.transform.position;
        option6b.transform.localScale = new Vector3(1.3f, 1.3f, 1);
        option6b.transform.Translate(new Vector3(0, 0, 10));



        //Option Seven border
        GameObject option7b = new GameObject("Option Seven Border");
        SpriteRenderer sr7b = option7b.AddComponent<SpriteRenderer>();
        sr7b.sprite = rpggm.assetSub.sprite[3];
        bm.optionBorderSR.Add(sr7b);
        option7b.transform.SetParent(option7.transform);
        option7b.transform.position = option7.transform.position;
        option7b.transform.localScale = new Vector3(1.3f, 1.3f, 1);
        option7b.transform.Translate(new Vector3(0, 0, 10));



        ////Option Eight border
        //GameObject option8b = new GameObject("Option Eight Border");
        //SpriteRenderer sr8b = option8b.AddComponent<SpriteRenderer>();
        //sr8b.sprite = rpggm.assetSub.sprite[3];
        //bm.optionBorderSR.Add(sr8b);
        //option8b.transform.SetParent(option8.transform);
        //option8b.transform.position = option8.transform.position;
        //option8b.transform.Translate(new Vector3(0, 0, 10));
        //option8b.transform.localScale = new Vector3(1.3f, 1.3f, 1);

    }
}