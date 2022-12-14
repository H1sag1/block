using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Rank : MonoBehaviour
{
    public TextMeshProUGUI TimeScore;
    public TextMeshProUGUI DeathScore;
    public TextMeshProUGUI AllScore;

    float time;
    int deathNum;
    int total = 0;//合計スコア
    string alphabet;//スコアアルファベット換算

    // Start is called before the first frame update
    void Start()
    {
        time = ScoreManager.time;
        deathNum = ScoreManager.life;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
