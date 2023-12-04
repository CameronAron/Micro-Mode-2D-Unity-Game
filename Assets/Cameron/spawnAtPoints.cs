using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAtPoints : MonoBehaviour
{
    public Transform[] spawnPoints;

    public float timer;

    public GameObject enemyPrefab;

    public float spawnTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnTime)
        {
            Instantiate(enemyPrefab, spawnPoints[Random.Range(0, 7)].position, Quaternion.identity);
            timer = 0;
        }
    }
}
