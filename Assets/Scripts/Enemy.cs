using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    private void Start()
    {
        health = 300;
        energy = 999999999;
    }

    private void OnMouseEnter()
    {
        ToString();
    }

    public override string ToString()
    {
        return base.ToString() + "Health: " + health + "/300";
    }

    //On attack||block turnNumber++
}
