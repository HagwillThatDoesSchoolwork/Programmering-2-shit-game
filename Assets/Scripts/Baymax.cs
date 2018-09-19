using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baymax : Character
{

    void Start()
    {
        health = 100;
        energy = 100;
    }
    public override string ToString()
    {
        return base.ToString() + "Health: " + health + "/100" + "\n" + "Energy: " + energy + "/100";
    }

}
