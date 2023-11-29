using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMultiply : MonoBehaviour
{
    public float timer;
    public int timeBetweenMultiple = 5;
    public GameObject bacteriaPrefab;

    public Transform spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = transform;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        Vector3 temp = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0);
        spawnPosition.position += temp;

        if(timer > timeBetweenMultiple)
        {
            timer = 0;
            GameObject newOval;
            newOval = Instantiate(bacteriaPrefab, spawnPosition.position, Quaternion.identity);
            newOval.transform.parent = transform;
            
        }

        spawnPosition = transform;
    }
}
