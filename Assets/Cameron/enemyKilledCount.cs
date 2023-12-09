using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class enemyKilledCount : MonoBehaviour
{
    public static int enemiesKilled = 0;
    public int enemygoal;
    public TMP_Text goalText;

    public string winSceneToLoad = "Beta Win Screen";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        goalText.text = $"Enemies Killed {enemiesKilled}/{enemygoal}";

        if (enemiesKilled >= enemygoal)
        {
            enemiesKilled = 0;
            SceneManager.LoadScene(winSceneToLoad);
        }
    }
}
