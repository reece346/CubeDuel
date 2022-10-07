using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject BulletPrefab;

    public int counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseMenu.GamePaused == false) {
            if (counter == 100) {
                Fire();
                counter = 0;
            }
            counter++;
        }
    }

    void Fire() {
        Instantiate(BulletPrefab, firePoint.position, firePoint.rotation);
    }
}