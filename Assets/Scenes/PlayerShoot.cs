using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject BulletPrefab;

    public int count = 0;

    // Update is called once per frame
    void Update()
    {
        if (PauseMenu.GamePaused == false) {
            if (Input.GetButtonDown("Fire1") && count >= 20) {
                Fire();
                count = 0;
            }
            count++;
        }
    }

    void Fire() {
        Instantiate(BulletPrefab, firePoint.position, firePoint.rotation);
    }
}
