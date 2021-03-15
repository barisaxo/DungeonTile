using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGPlayer : MonoBehaviour
{
    public BGM bgm;

    void Start()
    {
        bgm.myCamera.transform.SetParent(gameObject.transform);
        bgm.myCamera.transform.position = new Vector3(gameObject.transform.position.x,
            gameObject.transform.position.y, -10);

        SpriteRenderer pSR = gameObject.AddComponent<SpriteRenderer>();
        pSR.sprite = bgm.gm.assets.sprite[5];

        gameObject.transform.localScale = new Vector3(3, 3, 1);
    }
}
