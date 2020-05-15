using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowBallController : MonoBehaviour
{
    public float time2destruction = 2f;
    public float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= time2destruction) Destroy(this.gameObject);
    }
}
