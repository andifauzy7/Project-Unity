using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAquanus : MonoBehaviour
{

    public int enemyhealth = 100;
    public GameObject deathEffect;

    public void TakeDamage (int damage)
    {
        enemyhealth -= damage;
        if (enemyhealth <= 0)
            Die();
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
