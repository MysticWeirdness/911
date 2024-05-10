using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private float speed = 0.05f;
    private float damage = 0.1f;
    private void FixedUpdate()
    {
        transform.position += transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<EnemyScript>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
