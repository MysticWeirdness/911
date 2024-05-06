using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenu;
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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    private void Pause()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
    }

    public void Unpause()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
    }
}