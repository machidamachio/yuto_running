using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;    //TextMeshproを扱うときに追記します

public class ScoreCounter : MonoBehaviour
{
    public TextMeshProUGUI scoreText; //得点の変数
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Player.scoreCount);
        scoreText.text = "Score " + Player.scoreCount.ToString();
    }
}
