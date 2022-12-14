using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    TextMeshProUGUI timerText;
    TextMeshProUGUI death;
    
    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        death = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        GameManager gameManager;
        GameObject obj = GameObject.Find("GameManager");
        gameManager = obj.GetComponent<GameManager>();

        if (gameObject.name == "Time")
        {
            timerText.text = "TIME : " + gameManager.time.ToString("F2");
        }
        if (gameObject.name == "Death")
        {
            death.text = "DEATH : " + gameManager.deadNum.ToString("");
        }
       
    }
}
