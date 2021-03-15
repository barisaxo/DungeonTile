using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGLists : MonoBehaviour
{
    public BGM bgm;

    public List<GameObject> tileBackGOs = new List<GameObject>();
    public List<SpriteRenderer> tileBackSRs = new List<SpriteRenderer>();

    public List<GameObject> flippedTiles = new List<GameObject>();
    //TODO list<> MiniGameType... list<> ring level
}
