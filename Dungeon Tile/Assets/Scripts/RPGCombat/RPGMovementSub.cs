using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGMovementSub : MonoBehaviour
{
    public RPGGM rpggm;

    public float stepCounter, speed = 8f;

    public enum Direction { North, East, South, West, NorthEast, NorthWest, SouthEast, SouthWest }

    public void Move(Direction direction)
    {
        float x = rpggm.player.transform.position.x;
        float y = rpggm.player.transform.position.y;

        switch (direction)
        {//player movement directions by speed
            case Direction.East: x += Time.deltaTime * speed; break;

            case Direction.West: x -= Time.deltaTime * speed; break;

            case Direction.North: y += Time.deltaTime * speed; break;

            case Direction.South: y -= Time.deltaTime * speed; break;

            case Direction.NorthWest: x -= Time.deltaTime * speed * .7f; y += Time.deltaTime * speed * .7f; break;

            case Direction.NorthEast: x += Time.deltaTime * speed * .7f; y += Time.deltaTime * speed * .7f; break;

            case Direction.SouthWest: x -= Time.deltaTime * speed * .7f; y -= Time.deltaTime * speed * .7f; break;

            case Direction.SouthEast: x += Time.deltaTime * speed * .7f; y -= Time.deltaTime * speed * .7f; break;
        }

        //move player - stays in camera FOV - to be replaced
        x = Mathf.Clamp(x, -14, 14);
        y = Mathf.Clamp(y, -8, 8);
        rpggm.player.transform.position = new Vector3(x, y, 10);

        //random battle, increases chance with # of steps taken
        stepCounter += Time.deltaTime;
        float r = Random.Range(5f, 5000f);

        //chance to start a battle
        if (r < stepCounter)
        { rpggm.gameStateManager.StateChange(RPGGameStateManager.GameState.Battle); }
    }
}