using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Blocks;
    public GameObject BlockRed;
    public GameObject BlockGreen;
    public GameObject BlockBlue;
    public GameObject obj;
    public GameObject Balls;
    public GameObject ballPrefab;
    public GameObject gameOverUI;
    int scenenum;
    //public bool ballexistence = false;  //ボールの有無
    public int Life = 3; //ライフの数

    public float time = 0;
    public bool GameOverflag = false;
    // Start is called before the first frame update
    void Start()
    {
        scenenum = SceneManager.GetActiveScene().buildIndex;
        OnBlock();
    }

    // Update is called once per frame
    void Update()
    {

        IsGameover();
        if (GameOverflag == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (Balls.transform.childCount == 0)
                {
                    GameObject ball = GameObject.Instantiate(ballPrefab);
                    ball.transform.parent = Balls.transform;
                    //ballexistence = false;
                }
            }
            if (Balls.transform.childCount >= 1)
            {
                time += Time.deltaTime;
            }
        }
    }
    private void OnBlock()
    {
        if (scenenum == 1)
        {
            for (int i = 0; i < 7; i++)
            {
                obj = (GameObject)Instantiate(BlockBlue, new Vector3(-7.5f + i * 2.5f, 13, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
                //itemNum++;
                //GameObject Blocks = (GameObject)Instantiate(BlockBrue, transform.position, Quaternion.identity);
                //Blocks.transform.position = new Vector3(-7.5f + i * 2.5f, 13, 0);
                //Blocks.transform.parent = transform;
            }
            for (int i = 0; i < 7; i++)
            {
                obj = (GameObject)Instantiate(BlockGreen, new Vector3(-7.5f + i * 2.5f, 11.5f, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
                //itemNum++;
                //GameObject blockG = GameObject.Instantiate(BlockGreen);
                //blockG.transform.position = new Vector3(-7.5f + i * 2.5f, 11.5f, 0);
            }
            for (int i = 0; i < 7; i++)
            {
                obj = (GameObject)Instantiate(BlockRed, new Vector3(-7.5f + i * 2.5f, 10, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
                //itemNum++;
                //GameObject blockY = GameObject.Instantiate(BlockYellow);
                //blockY.transform.position = new Vector3(-7.5f + i * 2.5f, 10, 0);
            }
        }
        if (scenenum == 2) //ステージ２のブロックはいちい
        {
            for (int i = 0; i < 6; i++)
            {
                obj = (GameObject)Instantiate(BlockRed, new Vector3(-6.0f + i * 2.5f, 14.5f, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
            }
            for (int i = 0; i < 7; i++)
            {
                obj = (GameObject)Instantiate(BlockBlue, new Vector3(-7.5f + i * 2.5f, 13, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
            }
            for (int i = 0; i < 7; i++)
            {
                obj = (GameObject)Instantiate(BlockGreen, new Vector3(-7.5f + i * 2.5f, 11.5f, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;  
            }
            for (int i = 0; i < 6; i++)
            {
                obj = (GameObject)Instantiate(BlockRed, new Vector3(-6.0f + i * 2.5f, 10, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
            }
        }
        if (scenenum == 3)
        {
            for (int i = 0; i < 7; i++)
            {
                obj = (GameObject)Instantiate(BlockRed, new Vector3(-7.5f + i * 2.5f, 14.5f, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
            }
            for (int i = 0; i < 6; i++)
            {
                obj = (GameObject)Instantiate(BlockBlue, new Vector3(-6.5f + i * 2.5f, 13, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
            }
            for (int i = 0; i < 5; i++)
            {
                obj = (GameObject)Instantiate(BlockGreen, new Vector3(-5.5f + i * 2.5f, 11.5f, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
            }
            for (int i = 0; i < 4; i++)
            {
                obj = (GameObject)Instantiate(BlockRed, new Vector3(-4.5f + i * 2.5f, 10.0f, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
            }
        }
        if (scenenum == 4)
        {
            for (int i = 0; i < 5; i++)
            {
                obj = (GameObject)Instantiate(BlockBlue, new Vector3(-2.5f + i * 2.5f, 14.5f, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
            }
            for (int i = 0; i < 7; i++)
            {
                obj = (GameObject)Instantiate(BlockGreen, new Vector3(-5.0f + i * 2.5f, 13, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
            }
            for (int i = 0; i < 9; i++)
            {
                obj = (GameObject)Instantiate(BlockRed, new Vector3(-7.5f + i * 2.5f, 11.5f, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
            }
            for (int i = 0; i < 7; i++)
            {
                obj = (GameObject)Instantiate(BlockGreen, new Vector3(-5.0f + i * 2.5f, 10.0f, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
            }
            for (int i = 0; i < 5; i++)
            {
                obj = (GameObject)Instantiate(BlockBlue, new Vector3(-2.5f + i * 2.5f, 8.5f, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
            }
        }

        if (scenenum == 5)
        { 
            for (int i = 0; i < 3; i++)
            {
                obj = (GameObject)Instantiate(BlockBlue, new Vector3(-2.5f + i * 2.5f, 14.5f, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
            }
            for (int i = 0; i < 5; i++)
            {
                obj = (GameObject)Instantiate(BlockGreen, new Vector3(-5.0f + i * 2.5f, 13, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
            }
            for (int i = 0; i < 7; i++)
            {
                obj = (GameObject)Instantiate(BlockRed, new Vector3(-7.5f + i * 2.5f, 11.5f, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
            }
            for (int i = 0; i < 5; i++)
            {
                obj = (GameObject)Instantiate(BlockGreen, new Vector3(-5.0f + i * 2.5f, 10.0f, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
            }
            for (int i = 0; i < 3; i++)
            {
                obj = (GameObject)Instantiate(BlockBlue, new Vector3(-2.5f + i * 2.5f, 8.5f, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
            }
        }
        if (scenenum == 6)
        {

        }
        if (scenenum == 7)
        {

        }
        if (scenenum == 8)
        {

        }
        if (scenenum == 9)
        {

        }
        if (scenenum == 10)
        {

        }
   
}
    public void Balldeath()
    {
        if (Balls.transform.childCount == 1)
        {
            Life--;
            //ballexistence = false;
        }
    }
    public void IsGameover()
    {
        if(Life <= 0)
        {
            GameOverflag = true;
        }
        if(GameOverflag == true)
        {
            Invoke("showGameoverUI", 0.3f);
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    private void showGameoverUI()
    {
        gameOverUI.SetActive(true);
    }
}
