using UnityEngine;
using System.Collections.Generic;

public class RPGBattleManager : MonoBehaviour
{
    public RPGGM rpggm;

    //add all components for battle
    public RPGBattleHUD battleHUD;
    public RPGBattleSystem battleSystem;
    public RPGNME nme;
    public RPGBattleMenu battleMenu;

    public List<SpriteRenderer> borderSR = new List<SpriteRenderer>();
    public List<SpriteRenderer> hudSR = new List<SpriteRenderer>();

    public List<SpriteRenderer> optionSR = new List<SpriteRenderer>();
    public List<SpriteRenderer> optionBorderSR = new List<SpriteRenderer>();

    public List<SpriteRenderer> nmeSR = new List<SpriteRenderer>();
    public List<SpriteRenderer> nmeBorderSR = new List<SpriteRenderer>();
    public List<AudioClip> nmeAC = new List<AudioClip>();
    public List<GameObject> nmeGO = new List<GameObject>();

    public List<AudioClip> cadences = new List<AudioClip>();

    public void SetUp()
    {
        battleHUD = gameObject.AddComponent<RPGBattleHUD>();
        battleHUD.rpggm = rpggm;
        battleHUD.SetUp();

        battleSystem = gameObject.AddComponent<RPGBattleSystem>();
        battleSystem.rpggm = rpggm;

        nme = gameObject.AddComponent<RPGNME>();
        nme.rpggm = rpggm;
        nme.SetUp();

        battleMenu = gameObject.AddComponent<RPGBattleMenu>();
        battleMenu.rpggm = rpggm;
        battleMenu.SetUp();
    }
}