using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMovement : MonoBehaviour
{
    public BGM bgm;


    public enum Direction { North, South, East, West }

    public void Move(Direction dir)
    {
        Vector3 pos = bgm.player.transform.position;
        float x = pos.x;
        float y = pos.y;
        float z = pos.z;

        switch (dir)
        {
            case Direction.North:
                if (y + 4 < (bgm.map.nMapHeight - 1) * 4)
                {

                    //flip first, then move player
                    FlipTile(new Vector3(x, y + 4, z));
                }
                else
                {
                    //nudge
                }
                break;

            case Direction.South:
                if (y - 4 > 0)
                {
                    //bgm.player.transform.position = new Vector3(x, y - 4, z);
                    FlipTile(new Vector3(x, y - 4, z));
                }
                else
                {
                    //TODO nudge
                }
                break;

            case Direction.East:
                if (x + 4 < (bgm.map.nMapWidth - 1) * 4)
                {
                    //bgm.player.transform.position = new Vector3(x + 4, y, z);
                    FlipTile(new Vector3(x + 4, y, z));
                }
                else
                {
                    //nudge
                }
                break;

            case Direction.West:
                if (x - 4 > 0)
                {
                    //bgm.player.transform.position = new Vector3(x - 4, y, z);
                    FlipTile(new Vector3(x - 4, y, z));
                }
                else
                {
                    //nudge
                }
                break;
        }
    }


    public void FlipTile(Vector3 pos)
    {
        for (int i = 0; i < bgm.lists.tileBackGOs.Count; i++)
        {
            float dist = Vector3.Distance(pos,
                bgm.lists.tileBackGOs[i].transform.position);

            if (dist < 5.1f)
            {
                if (bgm.lists.flippedTiles.Contains(bgm.lists.tileBackGOs[i]))
                {
                    bgm.stateManager.bgState = BGStateManager.BGStates.Moving;
                    StartCoroutine(PickUpThePlayer(null));//, pos));
                    StartCoroutine(MoveThePlayer(pos));
                }
                else
                {
                    bgm.stateManager.bgState = BGStateManager.BGStates.IsFlipping;
                    bgm.lists.tileBackGOs[i].transform.GetChild(0).gameObject.SetActive(false);
                    StartCoroutine(PickUpTheTile(bgm.lists.tileBackGOs[i], pos));
                }
                break;
            }
        }
    }

    //flip the tile by enlarging and rotating, then setting back to correct size
    IEnumerator PickUpTheTile(GameObject tile, Vector3 pos)
    {
        if (tile.transform.localScale.x < 5)
        {
            float x = tile.transform.localScale.x + Time.deltaTime * 7;
            tile.transform.localScale = new Vector3(x, x, 1);
            //yield return new WaitForEndOfFrame();
            //StartCoroutine(PickUpTheTile(tile, pos));
        }

        if (tile.transform.rotation.x < .99f)
        {
            tile.transform.Rotate(Time.deltaTime * 300, 0, 0);
        }

        if (tile.transform.localScale.x < 5 || tile.transform.rotation.x < .99f)
        {
            yield return new WaitForEndOfFrame();
            StartCoroutine(PickUpTheTile(tile, pos));
        }
        else
        {
            tile.GetComponent<SpriteRenderer>().color = Color.clear;
            StartCoroutine(SetDownTheTile(tile, pos));
        }
    }

    IEnumerator SetDownTheTile(GameObject tile, Vector3 pos)
    {
        if (tile.transform.localScale.x > 4)
        {
            float x = tile.transform.localScale.x - Time.deltaTime * 7;
            tile.transform.localScale = new Vector3(x, x, 1);
            yield return new WaitForEndOfFrame();
            StartCoroutine(SetDownTheTile(tile, pos));
        }

        else
        {
            bgm.lists.flippedTiles.Add(tile);
            tile.transform.localScale = new Vector3(4, 4, 1);
            yield return new WaitForSeconds(.25f);
            StartCoroutine(PickUpThePlayer(tile));//, pos));
            StartCoroutine(MoveThePlayer(pos));
            bgm.stateManager.bgState = BGStateManager.BGStates.Moving;
        }
    }

    IEnumerator PickUpThePlayer(GameObject tile)
    {
        if (bgm.player.transform.localScale.x < 4)
        {
            float x = bgm.player.transform.localScale.x + Time.deltaTime * 4;
            bgm.player.transform.localScale = new Vector3(x, x, 1);
        }

        if (bgm.player.transform.localScale.x < 4)
        {
            yield return new WaitForEndOfFrame();
            StartCoroutine(PickUpThePlayer(tile));
        }

        else
        {
            StartCoroutine(SetDownThePlayer(tile));
        }

    }

    IEnumerator MoveThePlayer(Vector3 pos)
    {
        if (bgm.player.transform.position != pos)
        {
            bgm.player.transform.position =
                Vector3.MoveTowards(bgm.player.transform.position, pos, Time.deltaTime * 10);
            yield return new WaitForEndOfFrame();
            StartCoroutine(MoveThePlayer(pos));
        }

        yield break;
    }

    IEnumerator SetDownThePlayer(GameObject tile)
    {
        if (bgm.player.transform.localScale.x > 3)
        {
            float x = bgm.player.transform.localScale.x - Time.deltaTime * 4;
            bgm.player.transform.localScale = new Vector3(x, x, 1);
            yield return new WaitForEndOfFrame();
            StartCoroutine(SetDownThePlayer(tile));
        }

        else
        {
            bgm.player.transform.localScale = new Vector3(3, 3, 1);
            CheckTile(tile);
            yield break;
        }
    }

    void CheckTile(GameObject tile)
    {
        if (tile)
        {
            //TODO create a list to check against - refactor.
            Sprite s = tile.transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().sprite;

            if (s == bgm.gm.assets.sprite[6])
            {
                bgm.gm.gameStateManager.GameStateChange(GameStateManager.GameState.RPGCombat);
            }

            else
            {
                bgm.stateManager.bgState = BGStateManager.BGStates.Static;
            }
        }

        else
        {
            bgm.stateManager.bgState = BGStateManager.BGStates.Static;
        }
    }
}
