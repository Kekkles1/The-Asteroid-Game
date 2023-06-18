using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;

    public Text Score;
    int scoreCount = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Score.text=scoreCount.ToString()+" POINTS";
    }
    
    public void AddPoints()
    {
        scoreCount++;
        Score.text = scoreCount.ToString() + " POINTS";
    }
}
