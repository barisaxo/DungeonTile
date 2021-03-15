using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RPGGameMenu : MonoBehaviour
{
    public RPGGM rpggm;

    Text text;
    Canvas canvas;

    void Start()
    {
        gameObject.transform.position = rpggm.myCam.transform.position;
        transform.Translate(new Vector3(0, 0, 5));

        canvas = gameObject.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;

        Font ArialFont = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
        text = gameObject.AddComponent<Text>();
        text.alignment = TextAnchor.MiddleCenter;
        text.resizeTextForBestFit = true;
        text.font = ArialFont;
        text.material = ArialFont.material;

        text.text = "for movement: W, A, S, D\n for battle: arrow keys & return\n\n"
            + "press 'SPACE' to continue\n" + "press 'ESC' to return to the ship";
        //TODO "Return to the ship?" > decision tree || (A)SELECT | (B)CANCEL ||

        //
    }


}
/*
 * MENUS:
 *  Options Menu
 *      Volumes > NME music, Explore music, SFX
 *      
 *  Character Sheet
 *      Stats, LevelUp, Customize
 *      
 *  Inventory
 *      Equipment, Consumables
 *      
 *  Grimoire
 *      Build Your Deck
 *      
 *  Help -> Tutorial
 *      Practice Mode
 * 
 */