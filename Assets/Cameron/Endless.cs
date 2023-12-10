using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endless : MonoBehaviour
{
    public static int endlessEnemiesKilled = 0;
    public int enemygoal;
    public TMP_Text goalText;

    public string winSceneToLoad = "Beta Win Screen";


    // Start is called before the first frame update
    void Start()
    {
        endlessEnemiesKilled = 0;
    }

    // Update is called once per frame
    void Update()
    {
        goalText.text = $"Enemies Killed: {endlessEnemiesKilled}";
    }
}
