using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
    private Vector2 speed = new Vector2(0.05f, 0.05f);
    // Use this for initialization
    void Start()
    {
        
    }
    void Update()
    {
        Vector2 enemypos = transform.position;
        enemypos.x = enemypos.x - speed.x;
        transform.position = enemypos;
    }
}
