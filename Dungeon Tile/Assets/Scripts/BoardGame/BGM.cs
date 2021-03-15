using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public GM gm;

    public BGCamera myCamera;
    public BGMap map;

    public BGPlayer player;
    public BGMovement movement;
    public BGInputKey inputKey;
    public BGTileHandler tileHandler;
    public BGLists lists;
    public BGStateManager stateManager;

    void Start()
    {
        player = new GameObject("Player").AddComponent<BGPlayer>();
        player.transform.SetParent(transform);
        player.bgm = this;

        myCamera = new GameObject("Camera").AddComponent<BGCamera>();
        myCamera.transform.SetParent(transform);
        myCamera.bgm = this;

        map = gameObject.AddComponent<BGMap>();
        map.bgm = this;

        inputKey = gameObject.AddComponent<BGInputKey>();
        inputKey.bgm = this;

        lists = gameObject.AddComponent<BGLists>();
        lists.bgm = this;

        movement = gameObject.AddComponent<BGMovement>();
        movement.bgm = this;

        tileHandler = gameObject.AddComponent<BGTileHandler>();
        tileHandler.bgm = this;

        stateManager = gameObject.AddComponent<BGStateManager>();
        stateManager.bgm = this;
    }

}
