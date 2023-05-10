using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
 
public class AwayScoreScript : MonoBehaviour
{
    public int awayGoals;
    public TMP_Text scoreText;


    void Start()
    {
        awayGoals = 0;
    }

    public void AddScore(int awayGoal)
    {
        awayGoals = awayGoals + awayGoal;
    }

    public void UpdateScore()
    {
        scoreText.text = "" + awayGoals;
    }

    

    void Update()
    {
        UpdateScore();
    }

}
