using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGPlayer : MonoBehaviour
{
    public RPGGM rpggm;

    public int mad, exp;

    public SpriteRenderer playerSR;

    void Start()
    {
        gameObject.transform.SetParent(rpggm.board.transform);
        playerSR = gameObject.AddComponent<SpriteRenderer>();
        playerSR.sprite = rpggm.assetSub.sprite[3];
        playerSR.color = new Color(
            Random.Range(0.5f, 1f),
            Random.Range(0.5f, 1f),
            Random.Range(0.5f, 1f), 1);

        gameObject.transform.position = new Vector3(
            rpggm.myCam.transform.position.x,
            rpggm.myCam.transform.position.y, 10);
    }

}