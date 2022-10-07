using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rigidBod;
    public int damage = 5;

    // Start is called before the first frame update
    void Start()
    {
        rigidBod.velocity = transform.right * speed;
    }

    
    void OnTriggerEnter2D (Collider2D hitInfo) {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        Player player = hitInfo.GetComponent<Player>();
        
        if (enemy != null) {
            enemy.TakeDamage(damage);
        }

        if (player != null) {
            player.TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}
