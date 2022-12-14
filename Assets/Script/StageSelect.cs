using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class StageSelect : MonoBehaviour
{
    private RectTransform arrows;
    public GameObject[] buttons;
    private int stageID = 0;

    static int iconXNum = 5;
    static int stageMax = 10;
    // Start is called before the first frame update
    void Start()
    {
        Transform transform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0.5f, 0, 0, Space.World);

        //下矢印キーが押されたら
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            stageID += iconXNum;
            if (stageID > stageMax - 1) { stageID = stageID - stageMax; }
        }
        //上矢印キーが押されたら
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            stageID -= iconXNum;
            if (stageID < 0) { stageID = stageMax + stageID; }
        }
        //左矢印キーが押されたら
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            stageID -= 1;
            if (stageID == -1 || stageID == 4) { stageID += iconXNum; }
        }
        //右矢印キーが押されたら
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            stageID += 1;
            if (stageID == 5 || stageID == 10) { stageID -= iconXNum; }
        }

        transform.localPosition = new Vector3(buttons[stageID].transform.localPosition.x - 90, buttons[stageID].transform.localPosition.y, 0);

    }

    public int GetStageID()
    {
        return stageID;
    }

}
