using UnityEngine;
using System.Collections;

public class spon : MonoBehaviour
{
    public GameObject enemyPrefab;
    // Use this for initialization
    int cnt = 0;
    void Start()
    {
        StartCoroutine(Proc());
    }
    IEnumerator Proc()
    {

        while (true)
        {
            float x = 5;
            float y = 5;
            
            Vector2 pos = new Vector2(x, y);
            pos = Camera.main.ScreenToWorldPoint(pos);
            CreateEnemy(pos);
            cnt++;
            yield return new WaitForSeconds(60f);
            if (cnt < 10) break;
            
        }
    }

    void CreateEnemy(Vector2 position)
    {
        Instantiate(enemyPrefab, position, transform.rotation);
    }
}

