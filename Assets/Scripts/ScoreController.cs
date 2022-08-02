using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text leftText;
    public Text rightText;
    public ScoreManager manager;

    void Update() 
    { 
        leftText.text = manager.leftScore.ToString(); 
        rightText.text = manager.rightScore.ToString(); 
    } 
}
