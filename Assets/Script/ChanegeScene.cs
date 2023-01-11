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
                    if (arrow.GetStageID() == 1)
                    {
                        StartCoroutine("Stage2Scene");
                    }
                    if (arrow.GetStageID() == 2)
                    {
                        StartCoroutine("Stage3Scene");
                    }
                    if (arrow.GetStageID() == 3)
                    {
                        StartCoroutine("Stage4Scene");
                    }
                    if (arrow.GetStageID() == 4)
                    {
                        StartCoroutine("Stage5Scene");
                    }
                    if (arrow.GetStageID() == 5)
                    {
                        StartCoroutine("Stage6Scene");
                    }
                    if (arrow.GetStageID() == 6)
                    {
                        StartCoroutine("Stage7Scene");
                    }
                    if (arrow.GetStageID() == 7)
                    {
                        StartCoroutine("Stage8Scene");
                    }
                    if (arrow.GetStageID() == 8)
                    {
                        StartCoroutine("Stage9Scene");
                    }
                    if (arrow.GetStageID() == 9)
                    {
                        StartCoroutine("Stage10Scene");
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
    IEnumerator Stage2Scene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Stage2");
    }
    IEnumerator Stage3Scene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Stage3");
    }
    IEnumerator Stage4Scene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Stage4");
    }
    IEnumerator Stage5Scene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Stage5");
    }
    IEnumerator Stage6Scene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Stage6");
    }
    IEnumerator Stage7Scene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Stage7");
    }
    IEnumerator Stage8Scene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Stage8");
    }
    IEnumerator Stage9Scene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Stage9");
    }
    IEnumerator Stage10Scene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Stage10");
    }
    IEnumerator RezaltScene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Rezalt");
    }
}
