using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baymax : Character
{
    void Start()
    {
        health = 100;
        energy = 200;
    }

    public override string ToString()
    {
        return base.ToString() + "You have " + health + "/100 health left and "  + energy + "/200 energy left!";
    }

    //Genväg för ToString funktionen för användning i andra scripts.
    public void BaymaxStats()
    {
        print(ToString());
    }
}
