using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int enemiesReached = 0;
    public void EnemyReachedTheEnd()
    {
        enemiesReached++;
        if(enemiesReached >= 3)
        {
            Restart();
        }
    }

    private void Restart()
    {

    }
}