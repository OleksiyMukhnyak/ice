﻿using UnityEngine;
using System.Collections;

public class Result
{

    public string Name { get; set; }
    public float Score { get; set; }


    public Result(string name, float score)
    {
        this.Name = name;
        this.Score = score;
    }

}
