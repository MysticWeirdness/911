using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] Slider healthBar;

    private float health;
    private float maxHealth = 5;

    private void Awake()
    {
        health = maxHealth;
    }

    private void Start()
    {
        UpdateHealthBar();
    }
    public void TakeDamage(float amt)
    {
        health -= amt;
        UpdateHealthBar();
        if(health <= 0)
        {
            Die();
        }
    }

    private void UpdateHealthBar()
    {
        healthBar.value = (health / maxHealth);
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
