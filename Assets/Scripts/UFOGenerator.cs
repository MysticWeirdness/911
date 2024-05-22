using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UFOGenerator : MonoBehaviour
{
    [SerializeField] private GameObject UFO;
    [SerializeField] private TextMeshProUGUI waveDisplay;
    [SerializeField] private GameObject WinMenu;

    private int enemiesSpawned = 0;
    [SerializeField] private int maxWaves; 
    [SerializeField] private int[] enemiesPerWaves;
    private int currentWave = 1;
    private void Start()
    {
        PlayerPrefs.SetInt("L1", 0);
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
        StartCoroutine(TimeBetweenEnemySpawns());
    }

    private IEnumerator TimeBetweenEnemySpawns()
    {
        yield return new WaitForSeconds(1);
        Instantiate(UFO);
        enemiesSpawned++;
        if(enemiesSpawned >= enemiesPerWaves[currentWave - 1])
        {
            StartCoroutine(ListenForNewWave());
        }
        else
        {
            StartCoroutine(TimeBetweenEnemySpawns());
        }
    }

    private IEnumerator ListenForNewWave()
    {
        yield return null;
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if(enemies.Length <= 0)
        {
            TriggerNewWave();
        }
        else
        {
            StartCoroutine(ListenForNewWave());
        }
    }
    public void TriggerNewWave()
    {
        currentWave++;
        if(currentWave >= maxWaves + 1)
        {
            PlayerPrefs.SetInt("L1", 1);
            waveDisplay.text = "Level Completed";
            WinMenu.SetActive(true);
            return;
        }
        waveDisplay.text = "Wave " + currentWave;
        StartCoroutine(TimeBetweenEnemySpawns());
        enemiesSpawned = 0;
    }

}
