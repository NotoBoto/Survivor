using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    private float _speed;
    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    private int _woodCount;
    public int WoodCount
    {
        get { return _woodCount; }
        set { _woodCount = value; }
    }

    private int _stoneCount;
    public int StoneCount
    {
        get { return _stoneCount; }
        set { _stoneCount = value; }
    }
}
