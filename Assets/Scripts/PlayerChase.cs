using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChase : MonoBehaviour
{
    public float minSpeed = 2f;
    public float maxSpeed = 5f;
    public float directionChangeInterval = 2f; // initial time between direction changes
    private float speed;
    private Vector2 direction;
    private float nextChangeTime;

    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-0.5f, 0.5f)).normalized;
        nextChangeTime = Time.time + directionChangeInterval;
    }

    void Update()
    {
        // Move obstacle
        transform.Translate(direction * speed * Time.deltaTime);

        // Change direction at intervals
        if (Time.time >= nextChangeTime)
        {
            direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-0.5f, 0.5f)).normalized;

            // Make game harder: decrease interval over time (min 0.2f)
            directionChangeInterval = Mathf.Max(0.2f, directionChangeInterval * 0.98f);

            nextChangeTime = Time.time + directionChangeInterval;
        }

        // Optional: bounce off screen edges
        Vector3 pos = transform.position;
        if (pos.x > 10f || pos.x < -10f) direction.x *= -1;
        if (pos.y > 5f || pos.y < -5f) direction.y *= -1;
    }
}

