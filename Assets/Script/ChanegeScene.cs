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
        if (scenenum >= 1 && scenenum <= 10)
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
                if (myTransform.childCount == 0)
                {
                    StartCoroutine("RezaltScene");
                }
                break;
            case 2:
                if (myTransform.childCount == 0)
                {
                    StartCoroutine("RezaltScene");
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
            case 5:
                if (myTransform.childCount == 0)
                {
                    StartCoroutine("RezaltScene");
                }
                break;
            case 6:
                if (myTransform.childCount == 0)
                {
                    StartCoroutine("RezaltScene");
                }
                break;
            case 7:
                if (myTransform.childCount == 0)
                {
                    StartCoroutine("RezaltScene");
                }
                break;
            case 8:
                if (myTransform.childCount == 0)
                {
                    StartCoroutine("RezaltScene");
                }
                break;
            case 9:
                if (myTransform.childCount == 0)
                {
                    StartCoroutine("RezaltScene");
                }
                break;
            case 10:
                if (myTransform.childCount == 0)
                {
                    StartCoroutine("RezaltScene");
                }
                break;
            case 11:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (arrow.GetStageID() == 0)
                    {
                        StartCoroutine("Stage1Scene");
                    }
                    if (arrow.GetStageID() == 2)
                    {
                        StartCoroutine("Stage3Scene");
                    }
                }
                break;
            case 12:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    StartCoroutine("StageSelectScene");
                }
                break;

        }

    }

    IEnumerator StageSelectScene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("StageSelect");
    }
    IEnumerator Stage1Scene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Stage1");
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
