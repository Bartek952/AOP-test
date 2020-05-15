using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI3 : MonoBehaviour
{
    public float speed;
    public Transform target;
    public Transform AgroArena;
    public Vector2 AgroArenaXY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target.position.x - 0.9 < transform.position.x && transform.position.x < target.position.x + 0.9 && target.position.y - 0.9 < transform.position.y && transform.position.y < target.position.y + 0.9)
        {

        }
        else
        {
            if(AgroArena.position.x - (AgroArenaXY.x / 2) < target.position.x && AgroArena.position.x + (AgroArenaXY.x / 2) > target.position.x && AgroArena.position.y - (AgroArenaXY.y / 2) < target.position.y && AgroArena.position.y + (AgroArenaXY.y / 2) > target.position.y)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }

        }
    }
}
