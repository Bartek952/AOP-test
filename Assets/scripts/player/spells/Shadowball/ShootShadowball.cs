using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootShadowball : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce;
    public Button button;
    public float cooldown = 4f;
    public float timer = 0f;



    void Start()
    {
        ButtonColor2Black();
    }


    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= cooldown)
        {
            ButtonColor2Green();
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Shoot();
                ButtonColor2Black();
                timer = 0f;
            }
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);



    }

    void ButtonColor2Black()
    {
        ColorBlock colors = button.colors;
        colors.normalColor = Color.black;
        button.colors = colors;
    }

    void ButtonColor2Green()
    {
        ColorBlock colors = button.colors;
        colors.normalColor = Color.green;
        button.colors = colors;
    }
}
