using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
 
public class ScoreScript : MonoBehaviour
{
    public int homeGoals;
    public TMP_Text scoreText;

    void Start()
    {
        
        homeGoals = 0;
    }

    public void AddScore(int homeGoal)
    {
        homeGoals = homeGoals + homeGoal;
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + homeGoals + " - ";

        
    }

    

    void Update()
    {
        UpdateScore();
    }

}
