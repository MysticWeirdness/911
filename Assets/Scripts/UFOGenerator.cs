using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class UFOGenerator : MonoBehaviour
{
    [SerializeField] private GameObject UFO;

    [SerializeField] private int enemiesPerWave;

    private int enemiesSpawned = 0;
    private int wavesFinished = 0;
    private async void Start()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
        await TimeBetweenEnemySpawns();
    }

    private async Task TimeBetweenEnemySpawns()
    {
        await Task.Delay(1000);
        Instantiate(UFO);
        enemiesSpawned++;
        if(enemiesSpawned >= enemiesPerWave)
        {

        }
        else
        {
            await TimeBetweenEnemySpawns();
        }
    }

    public async Task NewWave()
    {
        await Task.Delay(5000);
        enemiesSpawned = 0;
        await TimeBetweenEnemySpawns();
    }

}
