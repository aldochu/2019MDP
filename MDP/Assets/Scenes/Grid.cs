using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    public Vector3 position;
    public int x, y;


    public Grid(Vector3 pos, int x, int y)
    {
        position = pos;
        this.x = x;
        this.y = y;
        
    }
}

