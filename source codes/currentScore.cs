using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class currentScore : MonoBehaviour
{
    public Text nowScore;

    // Update is called once per frame
    void Update()
    {
        
        nowScore.text = "Current Score: " + runnin.score.ToString();

    }
}
