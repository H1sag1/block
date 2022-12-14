using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChanegeScene : MonoBehaviour
{
    int scenenum;

    public StageSelect arrow;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scenenum = SceneManager.GetActiveScene().buildIndex;
        switch (scenenum)
        {
            case 0:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    StartCoroutine("LoadScene");
                }
                break;
            case 1:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (arrow.GetStageID() == 0)
                    {
                        StartCoroutine("LoadScene2");
                    }
                }
                break;
            case 2:
                if (Input.GetKeyDown(KeyCode.A))
                {
                        StartCoroutine("LoadScene3");
                }
                break;
            case 3:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    StartCoroutine("LoadScene");
                }
                break;
        }

    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("StageSelect");
    }
    IEnumerator LoadScene2()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("MainGame");
    }
    IEnumerator LoadScene3()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Rezalt");
    }
}
