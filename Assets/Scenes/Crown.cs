using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crown : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D playerTouch) {
        Player player = playerTouch.GetComponent<Player>();
        
        if (player != null) {
            player.collectCrown(true);

            Destroy(gameObject);
        }
    }
}
