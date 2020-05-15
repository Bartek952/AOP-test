using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI2 : MonoBehaviour
{
    public Transform player;
    Vector2 playerPos;
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        //float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;
        //playerBody.Rotate(Vector2.up * mouseY);
        playerPos = new Vector2(player.position.x, player.position.y);
    }

    private void FixedUpdate()
    {
        Vector2 lookDir = playerPos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;

    }
}
