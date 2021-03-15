using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMap : MonoBehaviour
{
    public BGM bgm;

    public int nMapHeight, nMapWidth;
    public string sMap1;

    public enum TileType { Wall, Empty, BlackHole, Radiation, EM, World, Star, Encounter }

    public GameObject Board, tileBacks, floors, walls;

    void Start()
    {
        Board = new GameObject("Board");
        Board.transform.SetParent(bgm.transform);

        tileBacks = new GameObject("Tile Backs");
        tileBacks.transform.SetParent(Board.transform);

        floors = new GameObject("Floors");
        floors.transform.SetParent(Board.transform);

        walls = new GameObject("Walls");
        walls.transform.SetParent(Board.transform);

        MapTemplate();
    }


    void MapTemplate()
    {           //123456798
        sMap1 += "WWWWWWWWW"; //1
        sMap1 += "W3333333W"; //2
        sMap1 += "W3222223W"; //3
        sMap1 += "W3211123W"; //4
        sMap1 += "W321S123W"; //5
        sMap1 += "W3211123W"; //6
        sMap1 += "W3222223W"; //7
        sMap1 += "W3333333W"; //8
        sMap1 += "WWWWWWWWW"; //9
        nMapWidth = 9;
        nMapHeight = 9;

        MakeMeAMap();
    }

    void MakeMeAMap()
    {
        for (int x = 0; x < nMapWidth; x++)
        {
            for (int y = 0; y < nMapHeight; y++)
            {
                char mTile = sMap1[(y * nMapWidth) + x];
                switch (mTile)
                {
                    case 'W':
                        WallTile(x, y);
                        break;

                    case '1':
                        GameTile(x, y);
                        break;
                    case '2':
                        GameTile(x, y);
                        break;
                    case '3':
                        GameTile(x, y);
                        break;

                    case 'S':
                        StartTile(x, y);
                        break;
                }
            }
        }
    }

    void WallTile(int x, int y)
    {
        GameObject wt = new GameObject("Wall Tile X: " + x + ", Y: " + y);
        wt.transform.position = new Vector3(x * 4, y * 4, 10);
        wt.transform.localScale = new Vector3(4, 4, 1);
        wt.transform.SetParent(walls.transform);

        SpriteRenderer wtSR = wt.AddComponent<SpriteRenderer>();
        wtSR.sprite = bgm.gm.assets.sprite[3];
        wtSR.color = new Color(.15f, .15f, .15f, 1);
    }


    void StartTile(int x, int y)
    {
        GameObject st = new GameObject("Start Tile X: " + x + ", Y: " + y);
        st.transform.position = new Vector3(x * 4, y * 4, 5);
        st.transform.localScale = new Vector3(4, 4, 1);
        st.transform.SetParent(floors.transform);

        SpriteRenderer stSR = st.AddComponent<SpriteRenderer>();
        stSR.sprite = bgm.gm.assets.sprite[1];
        stSR.color = Color.clear;

        stSR.color = Color.white;
        bgm.lists.flippedTiles.Add(st);
        bgm.lists.tileBackGOs.Add(st);

        bgm.player.transform.position = new Vector3(x * 4, y * 4, 0);
    }

    void GameTile(int x, int y)
    {
        GameObject ft = new GameObject("Floor Tile X: " + x + ", Y: " + y);
        ft.transform.position = new Vector3(x * 4, y * 4, 15);
        ft.transform.localScale = new Vector3(4, 4, 1);
        ft.transform.SetParent(floors.transform);

        SpriteRenderer ftSR = ft.AddComponent<SpriteRenderer>();
        ftSR.sprite = bgm.gm.assets.sprite[0];
        ftSR.color = Color.clear;

        UnFlippedTile(x, y);
    }

    void UnFlippedTile(int x, int y)
    {
        //The back of the Face-Down tile.
        GameObject tb = new GameObject("Tile Back X: " + x + ", Y: " + y);
        tb.transform.position = new Vector3(x * 4, y * 4, 5);
        tb.transform.localScale = new Vector3(3.5f, 3.5f, 1);
        tb.transform.SetParent(tileBacks.transform);

        SpriteRenderer tbSR = tb.AddComponent<SpriteRenderer>();
        tbSR.sprite = bgm.gm.assets.sprite[0];
        tbSR.color = new Color(.75f, .75f, .75f, 1);

        //TODO make an asset with a border and get rid of this border GO.
        GameObject tbb = new GameObject("Tile Back Border X: " + x + ", Y: " + y);
        tbb.transform.position = new Vector3(x * 4, y * 4, 5.01f);
        tbb.transform.localScale = new Vector3(4, 4, 1);
        tbb.transform.SetParent(tb.transform);

        SpriteRenderer tbbSR = tbb.AddComponent<SpriteRenderer>();
        tbbSR.sprite = bgm.gm.assets.sprite[3];
        tbbSR.color = Color.black;

        //The Graphic of the Face-Up tile
        GameObject tf = new GameObject("Tile Face X: " + x + ", Y: " + y);
        tf.transform.position = new Vector3(x * 4, y * 4, 5.01f);
        tf.transform.localScale = new Vector3(3.5f, 3.5f, 1);
        tf.transform.SetParent(tb.transform);
        tf.transform.rotation = Quaternion.Euler(180, 0, 0);

        SpriteRenderer tfSR = tf.AddComponent<SpriteRenderer>();
        tfSR.sprite = bgm.gm.assets.sprite[Random.Range(6, 11)];
        tfSR.color = Color.white;

        //Add to list.
        bgm.lists.tileBackGOs.Add(tb);
    }
}






/*
 * 
 * 
 *           //0123456789ABCDEF......
        sMap1 += "WWWWWWWWWWWWWWWW"; //0
        sMap1 += "WS.............W"; //1
        sMap1 += "W..............W"; //2
        sMap1 += "W..............W"; //3
        sMap1 += "W..............W"; //4
        sMap1 += "W..............W"; //5
        sMap1 += "W..............W"; //6
        sMap1 += "W..............W"; //7
        sMap1 += "W..............W"; //8
        sMap1 += "W..............W"; //9
        sMap1 += "W..............W"; //A
        sMap1 += "W..............W"; //B
        sMap1 += "W..............W"; //C
        sMap1 += "W..............W"; //D
        sMap1 += "W..............W"; //E
        sMap1 += "WWWWWWWWWWWWWWWW"; //F

        nMapHeight = 16; nMapWidth = 16;




*/