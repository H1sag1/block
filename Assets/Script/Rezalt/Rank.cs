using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Rank : MonoBehaviour
{
    public TextMeshProUGUI TimeScore;
    public TextMeshProUGUI DeathScore;
    public TextMeshProUGUI AllScore;

    float time = 10.5f;
    int deathNum = 2;
    //int total = 0;//���v�X�R�A
    string alphabet = "S";//�X�R�A�A���t�@�x�b�g���Z

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        TimeScore.text = "TIME " + time.ToString("F2");
        DeathScore.text ="DEATH " +  deathNum.ToString("F0");
        AllScore.text =  "RANK " + alphabet;
    }
}
