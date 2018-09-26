using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    int randomMove;
    int randomAttack;
    int randomDefend;
    public bool meleeAttack = false;
    public bool rangeAttack = false;

    private void Start()
    {
        health = 300;
        energy = 999999999;
        
        
    }

    private void EnemyMove()
    {
        //Man måste ha 1 över högsta numret i randoms. Ifall vi ska ha mellan 1-2 så måste man sätta (1, 3) och inte (1, 2)
        randomMove = Random.Range(1, 3); //Gör en random som väljer om den enemy ska attackera eller blocka(attack=1, block=2)
        
        if (randomMove == 1)
        {
            randomAttack = Random.Range(1, 3); //Väljer vilken attack enemy ska använda
            if (randomAttack == 1)
            {
                //kör attack 1 här
                meleeAttack = true;
                print("The evil Toad tried to stab you!");
            }
            else if (randomAttack == 2)
            {
                //Kör attack 2 här
                rangeAttack = true;
                print("The evil toad threw his knife at you!");
            }
        }
        else if (randomMove == 2) //Gör en random ifall move inte är 1 och då är 2 så blockar vi
        {
            randomDefend = Random.Range(1, 3); //Gör en random som väljer vilken typ av block
            if (randomDefend == 1)
            {
                //kör Block 1 här
                meleeDefense = true;
                print("The evil toad tried to block an melee attack!");
            }
            else if (randomDefend == 2)
            {
                //Kör Block 2 här
                rangeDefense = true;
                print("The evil toad tried to block an ranged attack!");
            }
        }
    }
    //genväg för EnemyMove() i andra scripts.
    public void EvilMove()
    {
        EnemyMove();
    }

    private void OnMouseEnter()
    {
        ToString();
    }

     public override string ToString()
    {
        return base.ToString() + "The Evil toad has " + health + "/300 Health left! Hahaa!";
    } 


    public void EnemyStats()
    {
        print(ToString());
    }

    //On attack||block turnNumber++
}
