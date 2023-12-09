using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class PlayerMultiply : MonoBehaviour
{
    public float timer;
    public int timeBetweenMultiple = 5;
    public int howManySpawn = 5;
    public GameObject bacteriaPrefab;

    public static int bacteriaCount = 1;
    public TMP_Text bacteriaCountText;

    // Start is called before the first frame update
    void Start()
    {
        bacteriaCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > timeBetweenMultiple)
        {
            timer = 0;

            for(int i = 0; i < howManySpawn; i++)
            {
                spawnNew();
            }
        }

        bacteriaCountText.text = $"Bacteria Cells: {bacteriaCount}";
    }

    public void spawnNew()
    {
        GameObject newOval;
        newOval = Instantiate(bacteriaPrefab, transform.position + new Vector3(Random.Range(-.5f, .5f), Random.Range(-.5f, .5f), 0), Quaternion.identity);
        newOval.transform.parent = transform;
        bacteriaCount++;
    }
}
