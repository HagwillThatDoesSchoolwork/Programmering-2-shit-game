using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Enemy evilToad;
    public Baymax player;

    public void TurnDone()
    {
        ClearConsole();
        Stats();

        if (evilToad.health <= 0)
        {
            print("Congratz!!! You killed the evil Toad and saved the earth!");
            Application.Quit();
        }
        else if (player.health <= 0)
        {
            print("You have now died. The Earth is now doomed forever!");
        }
    }

    private void Stats()
    {
        evilToad.EnemyStats();
        player.BaymaxStats();
    }

    void Start()
    {
        StartCoroutine(ClearConsole());
    }

    IEnumerator ClearConsole()
    {
        // wait until console visible
        while (!Debug.developerConsoleVisible)
        {
            yield return null;
        }
        yield return null; // this is required to wait for an additional frame, without this clearing doesn't work (at least for me)
        Debug.ClearDeveloperConsole();
    }
}
