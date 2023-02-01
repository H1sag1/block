using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    TextMeshProUGUI timerText;
    TextMeshProUGUI Life;
    TextMeshProUGUI PushSpace;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        Life = GetComponent<TextMeshProUGUI>();
        PushSpace = GetComponent<TextMeshProUGUI>();
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
        if (gameObject.name == "Life")
        {
            Life.text = "LIFE : " + gameManager.Life.ToString("");
        }
        if (gameObject.name == "Push")
        {
            if (gameManager.Balls.transform.childCount == 0)
            {
                PushSpace.enabled = true;
            }
            else
            {
                PushSpace.enabled = false;
            }
        }
       
    }
}
