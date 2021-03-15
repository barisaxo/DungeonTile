using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGMap : MonoBehaviour
{
    public RPGGM rpggm;

    void Start()
    {

    }

}

/*
 * Types of MAPS:
 * World, Town, Instance(dungeon), 
 * Shop(room/ building), Building(dungeon), Rooms(dungeon)
 *
 * Layout of maps:
 * Rooms, Corridors, Walls, Roads
 * Doors, Portals, Stairs, Ladders
 * 
 * Terrians >
 * Walkable & Unwalkable(unpassable)
 * One-Way Passable?
 * Climbable?
 * Swimable?
 * Flying?
 * 
 * Trees, Rocks, Puddles, Signs, Switches, Objects
 * 
 * Interactable: 
 * NPCs, Shopkeeps, NME, Chests, Items(Loot)
 * Foraging, 
 * 
 * 
 */