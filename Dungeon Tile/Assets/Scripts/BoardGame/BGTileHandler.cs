using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGTileHandler : MonoBehaviour
{
    public BGM bgm;

    //public void FlipTile()
    //{
    //    for (int i = 0; i < bgm.lists.tileBackGOs.Count; i++)
    //    {
    //        float dist = Vector3.Distance(bgm.player.transform.position,
    //            bgm.lists.tileBackGOs[i].transform.position);

    //        if (dist < 5.1f)
    //        {
    //            if (bgm.lists.flippedTiles.Contains(bgm.lists.tileBackGOs[i]))
    //            {
    //                bgm.stateManager.bgState = BGStateManager.BGStates.Static;
    //                return;
    //            }

    //            else
    //            {
    //                bgm.stateManager.bgState = BGStateManager.BGStates.IsFlipping;
    //                StartCoroutine(PickUpTheTile(bgm.lists.tileBackGOs[i]));
    //            }
    //            break;
    //        }
    //    }
    //}

    ////flip the tile by enlarging and rotating, then setting back to correct size
    //IEnumerator PickUpTheTile(GameObject tile)
    //{
    //    if (tile.transform.localScale.x < 5)
    //    {
    //        float x = tile.transform.localScale.x + Time.deltaTime * 7;
    //        tile.transform.localScale = new Vector3(x, x, 1);
    //        yield return new WaitForEndOfFrame();
    //        StartCoroutine(PickUpTheTile(tile));
    //    }
    //    else
    //    {
    //        tile.transform.GetChild(0).gameObject.SetActive(false);
    //        StartCoroutine(FlipOverTheTile(tile));
    //    }
    //}

    //IEnumerator FlipOverTheTile(GameObject tile)
    //{
    //    if (tile.transform.rotation.x < .99f)
    //    {
    //        tile.transform.Rotate(Time.deltaTime * 300, 0, 0);
    //        yield return new WaitForEndOfFrame();
    //        StartCoroutine(FlipOverTheTile(tile));
    //    }
    //    else
    //    {
    //        tile.transform.rotation = Quaternion.Euler(180, 0, 0);
    //        tile.GetComponent<SpriteRenderer>().color = Color.clear;
    //        StartCoroutine(SetDownTheTile(tile));
    //        yield return null;
    //    }
    //}

    //IEnumerator SetDownTheTile(GameObject tile)
    //{
    //    if (tile.transform.localScale.x > 4)
    //    {
    //        float x = tile.transform.localScale.x - Time.deltaTime * 7;
    //        tile.transform.localScale = new Vector3(x, x, 1);
    //        yield return new WaitForEndOfFrame();
    //        StartCoroutine(SetDownTheTile(tile));
    //    }
    //    else
    //    {
    //        bgm.lists.flippedTiles.Add(tile);
    //        tile.transform.localScale = new Vector3(4, 4, 1);
    //        bgm.stateManager.bgState = BGStateManager.BGStates.Static;
    //        yield return null;
    //    }
    //}
}
