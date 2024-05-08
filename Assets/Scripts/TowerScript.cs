using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{
    [Header("Attacking")]
    [SerializeField] private GameObject projectilePrefab;
    private float projectileSpeed = 1f;
    private float projectileDamage = 1f;
    private float range = 5f;
    private float cooldownDuration = 1f;
    private float cooldown = 0f;
    private GameObject targettedEnemy;

    private void Update()
    {
        float shortestDistance = Mathf.Infinity;
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject enemy in enemies)
        {
            if(Vector3.Distance(transform.position, enemy.transform.position) < shortestDistance && Vector3.Distance(transform.position, enemy.transform.position) <= range)
            {
                targettedEnemy = enemy;
            }
        }

        if(targettedEnemy != null && cooldown <= 0)
        {
            cooldown += cooldownDuration;
            Shoot(targettedEnemy);
        }
        cooldown -= Time.deltaTime;
    }

    private void Shoot(GameObject enemy)
    {

    }
}
