using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed;
    private float Move;

    public float jump;
    public bool isJump;

    private Rigidbody2D rigidBod;
    // Start is called before the first frame update
    void Start()
    {
        rigidBod = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rigidBod.velocity = new Vector2(speed * Move, rigidBod.velocity.y);

        if (PauseMenu.GamePaused == false) {
            if (Input.GetButtonDown("Jump") && isJump == false) {
                FindObjectOfType<AudioManager>().Play("PlayerJump");
                rigidBod.AddForce(new Vector2(rigidBod.velocity.x, jump));
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Ground")) {
            FindObjectOfType<AudioManager>().Play("PlayerLand");
            isJump = false;
        }
    }
    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.CompareTag("Ground")) {
            isJump = true;
        }
    }
}
