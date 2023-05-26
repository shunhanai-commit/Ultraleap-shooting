using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountText : MonoBehaviour
{
    int score = 0;
    public Text scoreText;

    public void AddScore()
    {
        score += 10;
    }
   

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE: " + score.ToString();
    }
}
