using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChanegeScene : MonoBehaviour
{
    int scenenum;
    Transform myTransform;
    public StageSelect arrow;
    // Start is called before the first frame update
    void Start()
    {
        scenenum = SceneManager.GetActiveScene().buildIndex;
        if (scenenum == 3 || scenenum == 4)
        {
            GameObject block = GameObject.Find("Blocks");
            myTransform = block.transform;
        }

    }

    // Update is called once per frame
    void Update()
    {
        switch (scenenum)
        {
            case 0:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    StartCoroutine("StageSelectScene");
                }
                break;
            case 1:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (arrow.GetStageID() == 0)
                    {
                        StartCoroutine("MainGameScene");
                    }
                    if (arrow.GetStageID() == 2)
                    {
                        StartCoroutine("Stage3Scene");
                    }
                }
                break;
            case 2:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    StartCoroutine("StageSelectScene");
                }
                break;
            case 3:
                if (myTransform.childCount == 0)
                {
                    StartCoroutine("RezaltScene");
                }
                break;
            case 4:
                if (myTransform.childCount == 0)
                {
                    StartCoroutine("RezaltScene");
                }
                break;

        }

    }

    IEnumerator StageSelectScene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("StageSelect");
    }
    IEnumerator MainGameScene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("MainGame");
    }
    IEnumerator Stage3Scene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Stage3");
    }
    IEnumerator RezaltScene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Rezalt");
    }
}
