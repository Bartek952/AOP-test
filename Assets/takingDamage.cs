using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takingDamage : MonoBehaviour
{
    public float hp = 10f;
    private float startHP;
    public float ShadowballDamage = 2f;
    public GameObject HPplate;
    // Start is called before the first frame update
    void Start()
    {
        startHP = hp;
        HPplate.transform.localScale = new Vector2(hp / startHP, 0.04f);
    }

    // Update is called once per frame
    void Update()
    {
        if(hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D c)
    {
        if(c.tag == "shadowball")
        {
            hp -= ShadowballDamage;
            HPplate.transform.localScale = new Vector2(hp / startHP, 0.04f);
        }
    }
}
