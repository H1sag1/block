using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Rank : MonoBehaviour
{
    public TextMeshProUGUI TimeScore;
    public TextMeshProUGUI LifeScore;
    public TextMeshProUGUI AllScore;

    float time;
    int Life;
    int total = 0;//合計スコア
    string alphabet = "S";//スコアアルファベット換算

    float count = 0;

    // Start is called before the first frame update
    void Start()
    {
        time = RankManager.time;
        Life = RankManager.Life;
        totalscore();
        Alfabet();
    }

    // Update is called once per frame
    void Update()
    {
        if (count >= 1f)
        {
            TimeScore.text = "TIME " + time.ToString("F2");
        }
        if (count >= 2f)
        {
            LifeScore.text = "LIFE " + Life.ToString("F0");
        }
        if (count >= 3f)
        {
            AllScore.text = "RANK " + alphabet;
        }
        
        count += Time.deltaTime;
    }

 void totalscore()
    {
        if (time <= 60)
        {
            total += 70;
        }else
        {
            total += 70 - ((int)time - 60);
        }
        total += Life * 10;
    }
    void Alfabet()
    {
        if (total >= 95)
        {
            alphabet = "S";
        }else if (total >=85)
        {
            alphabet = "A";
        }
        else if (total >=70)
        {
            alphabet = "B";
        }
        else if (total >=50)
        {
            alphabet = "C";
        }
        else if (total >= 30)
        {
            alphabet = "D";
        }
        else
        {
            alphabet = "E";
        }
    }
}


