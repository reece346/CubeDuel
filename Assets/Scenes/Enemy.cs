using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Enemy : MonoBehaviour
{
    public GameObject deathEffect;
    public int maxHealth = 1000;
    public int currentHealth;

    public HealthBar healthBar;

    void Start() {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage (int dam) {
        currentHealth = currentHealth - dam;

        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0) {
            Die();
        }
    }

    public void Die() {
        Instantiate(deathEffect, transform.position, transform.rotation);

        FindObjectOfType<AudioManager>().Play("EnemyDeath");

        Destroy(gameObject);
        healthBar.Remove();
    }
}
