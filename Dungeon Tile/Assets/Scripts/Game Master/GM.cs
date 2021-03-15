using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    public BGM bgGM;
    public RPGGM rpgGM;
    public Assets assets;
    public GameStateManager gameStateManager;
    public AudioManager audioManager;
    // public MyCamera myCamera;

    void Start()
    {
        bgGM = new GameObject("Board Game GM").AddComponent<BGM>();
        bgGM.gm = this;

        rpgGM = new GameObject("RPG-Combat GM").AddComponent<RPGGM>();
        rpgGM.gm = this;

        assets = gameObject.AddComponent<Assets>();
        assets.gm = this;

        gameStateManager = gameObject.AddComponent<GameStateManager>();
        gameStateManager.gm = this;

        audioManager = gameObject.AddComponent<AudioManager>();
        audioManager.gm = this;

        //myCamera = new GameObject("GM Camera").AddComponent<MyCamera>();
        //myCamera.gm = this;
        //myCamera.transform.SetParent(transform);
        //myCamera.gameObject.SetActive(false);
    }

}
