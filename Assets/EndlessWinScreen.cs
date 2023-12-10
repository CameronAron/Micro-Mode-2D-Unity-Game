using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndlessWinScreen : MonoBehaviour
{
    public TMP_Text resultText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        resultText.text = $"You got a score of {Endless.endlessEnemiesKilled}";
    }
}
