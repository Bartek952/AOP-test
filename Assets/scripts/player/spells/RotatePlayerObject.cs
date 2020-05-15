using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayerObject : MonoBehaviour
{
    //public Transform playerBody;
    //public float mouseSensivity;
    public Camera cam;
    Vector2 mousePos;
    public Rigidbody2D rb;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.transform.position;
        //float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        //float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;
        //playerBody.Rotate(Vector2.up * mouseY);

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;

    }
}
