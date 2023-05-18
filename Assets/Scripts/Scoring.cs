using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Scoring : MonoBehaviour
{

    public TMP_Text  MyScoreText;
    private int ScoreNum;

    void Start()
    {
        ScoreNum=0;
        MyScoreText.text="Score:"+  ScoreNum;  
    }

      private void OnTriggerEnter2D(Collider2D Coin)
    {
        if(Coin.tag == "Coin")
        {
            
            Destroy(Coin.gameObject);
            ScoreNum ++;
            MyScoreText.text = "Score: " + ScoreNum;

            Debug.Log("works");
            Debug.Log("Score is = "+ ScoreNum.ToString());
        }
    }
}
