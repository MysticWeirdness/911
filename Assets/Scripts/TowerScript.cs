using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{
    [Header("Attacking")]
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float projectileDamage;
    // range is the radius 
    private float range = 2.5f;
    [SerializeField] float cooldownDuration;
    private float cooldown = 0f;
    private GameObject targettedEnemy;

    [Header("User Experience")]
    Camera cam;
    [SerializeField] private GameObject rangePreview;
    private bool showPreview = false;
    [SerializeField] private int towerValue;

    private void Start()
    {
        cam = Camera.main;
    }
    private void Update()
    {
        float shortestDistance = Mathf.Infinity;
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject enemy in enemies)
        {
            if(Vector3.Distance(transform.position, enemy.transform.position) < shortestDistance && Vector3.Distance(transform.position, enemy.transform.position) <= range)
            {
                shortestDistance = Vector3.Distance(transform.position, enemy.transform.position);
                targettedEnemy = enemy;
                LookAtEnemy(targettedEnemy.transform.position);
            }
            else if(Vector3.Distance(transform.position, enemy.transform.position) > shortestDistance && Vector3.Distance(transform.position, enemy.transform.position) <= range)
            {
                shortestDistance = Vector3.Distance(transform.position, enemy.transform.position);
                targettedEnemy = enemy;
                LookAtEnemy(targettedEnemy.transform.position);
            }
            if(shortestDistance > range)
            {
                targettedEnemy = null;
            }
        }

        if(cooldown <= 0 && targettedEnemy != null)
        {
            Shoot(targettedEnemy);
            cooldown += cooldownDuration;
        }

        cooldown -= Time.deltaTime;
    }

    private void Shoot(GameObject enemy)
    {
        enemy.gameObject.GetComponent<EnemyScript>().TakeDamage(projectileDamage);
    }

    private void LookAtEnemy(Vector3 enemyPosition)
    {
        transform.LookAt(enemyPosition);
    }

    public int GetTowerValue()
    {
        return towerValue;
    }
    public void TogglePreview()
    {
        showPreview = !showPreview;
        rangePreview.SetActive(showPreview);
    }
}
