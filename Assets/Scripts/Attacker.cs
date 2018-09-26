using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attacker : MonoBehaviour
{
    public Enemy evilToad;
    public Baymax player;
    public GameController gC;

    //Funktioner som Används på kanppar
    public void Punch()
    {
        evilToad.EvilMove();
        player.energy -= 10;

        if (evilToad.rangeDefense == true)
        {
            evilToad.health -= 10;
            evilToad.rangeDefense = false;

            print("The punched toad");
        }

        else if (evilToad.meleeDefense == true)
        {
            evilToad.meleeDefense = false;
            print("Toad dodged your punch!");
        }

        else if (evilToad.meleeAttack == true)
        {
            player.health -= 10;
            evilToad.health -= 10;
            evilToad.meleeAttack = false;

            print("You punched toad!");
            print("Toad stabbed you!");
        }

        else if (evilToad.rangeAttack == true)
        {
            player.health -= 20;
            evilToad.health -= 10;
            evilToad.rangeAttack = false;

            print("You punched toad!");
            print("Toad threw his knife at you!");
        }

        gC.TurnDone();
    }

    public void Kick()
    {
        evilToad.EvilMove();
        player.energy -= 30;

        if (evilToad.rangeDefense == true)
            evilToad.health -= 30;

        else if (evilToad.meleeDefense == true)
            evilToad.meleeDefense = false;

        else if (evilToad.meleeAttack == true)
        {
            player.health -= 10;
            evilToad.meleeAttack = false;
        }

        else if (evilToad.rangeAttack == true)
        {
            player.health -= 20;
            evilToad.rangeAttack = false;
        }

        gC.TurnDone();
    }

    public void FocusBlast()
    {
        evilToad.EvilMove();
        player.energy -= 20;
        evilToad.health -= 10;

        if (evilToad.meleeAttack == true)
        {
            player.health -= 10;
            evilToad.meleeAttack = false;
        }

        else if (evilToad.rangeAttack == true)
        {
            player.health -= 20;
            evilToad.rangeAttack = false;
        }

        gC.TurnDone();
    }

    public void BowAndArrow()
    {
        evilToad.EvilMove();
        player.energy -= 40;

        if (evilToad.meleeDefense == true)
            evilToad.health -= 40;

        else if (evilToad.rangeDefense == true)
            evilToad.rangeDefense = false;

        else if (evilToad.meleeAttack == true)
        {
            player.health -= 10;
            evilToad.meleeAttack = false;
        }

        else if (evilToad.rangeAttack == true)
        {
            player.health -= 20;
            evilToad.rangeAttack = false;
        }

        gC.TurnDone();
    }

    public void MeleeDefense()
    {
        evilToad.EvilMove();

        if (evilToad.rangeAttack == true)
            player.health -= 20;

        else if (evilToad.meleeDefense == true)
            player.energy += 20;

        if (player.energy > 200)
            player.energy = 200;

        gC.TurnDone();
    }

    public void RangeDefense()
    {
        evilToad.EvilMove();

        if (evilToad.meleeAttack == true)
            player.health -= 10;

        else if (evilToad.rangeAttack == true)
            player.energy += 20;

        if (player.energy > 200)
            player.energy = 200;

        gC.TurnDone();
    }

    public void Eat()
    {
        player.energy += 50;

        if (player.energy > 200)
            player.energy = 200;

        if (evilToad.meleeAttack == true)
        {
            player.health -= 10;
            evilToad.meleeAttack = false;
        }

        else if (evilToad.rangeAttack == true)
        {
            player.health -= 20;
            evilToad.rangeAttack = false;
        }

        gC.TurnDone();
    }
}
