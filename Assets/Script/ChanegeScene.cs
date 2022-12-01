using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChanegeScene : MonoBehaviour
{
    int scenenum;

    public GameObject arrow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scenenum = SceneManager.GetActiveScene().buildIndex;
        switch(scenenum)
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
                    if (arrow.transform.localPosition.x == -470 && arrow.transform.localPosition.y == 60)
                    {
                        StartCoroutine("LoadScene2");
                    }
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
}
