using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        // FIX: Use the standard "Player" tag
        // Ensure your Player object is tagged "Player" in the Inspector!
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 1. Logic to destroy the obstacle when it hits the "Border"
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        // 2. Logic to destroy the player when hit by the obstacle
        else if (collision.tag == "Player")
        {
            // This destroys the player object.
            Destroy(player.gameObject);

            // NOTE: Your separate GameOver script (like the one you showed) 
            // will detect that the player is gone and show the Game Over Panel.
        }
    }
}