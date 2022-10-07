using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    public static bool GameWon = false;
    public static bool GameLost = false;
    public GameObject winMenuUI;
    public GameObject loseMenuUI;

    void Start() {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int dam) {
        FindObjectOfType<AudioManager>().Play("BulletHit");

        currentHealth = currentHealth - dam;

        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0) {
            Die();
        }
    }

    public void collectCrown (bool crownCollected) {
        if (crownCollected) {
            Win();
        }
    }

    public void Win () {
        FindObjectOfType<AudioManager>().Play("PlayerWin");

        winMenuUI.SetActive(true);
        Time.timeScale = 0f;
        PauseMenu.GamePaused = true;
    }

    public void Die() {

        FindObjectOfType<AudioManager>().Play("PlayerDeath");

        Destroy(gameObject);
        healthBar.Remove();

        loseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        PauseMenu.GamePaused = true;
    }
}
