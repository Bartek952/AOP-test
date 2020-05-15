using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    Vector2 playerPos;
    Vector2 movement;
    public Rigidbody2D rb;
    public Transform player;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        playerPos = new Vector2(player.position.x, player.position.y);
        movement.x = 1f;
        movement.y = 0f;

    }
    private void FixedUpdate()
    {
        Vector2 lookDir = playerPos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
        rb.AddForce(new Vector2(speed, 0), ForceMode2D.Impulse);
    }
}
