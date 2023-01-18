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

    int scenenum;
    //public bool ballexistence = false;  //ボールの有無
    public int deadNum = 0; //ライフの数

    public float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        scenenum = SceneManager.GetActiveScene().buildIndex;
        OnBlock();
    }

    // Update is called once per frame
    void Update()
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
            
        }
        if (scenenum == 4)
        {

        }

        if (scenenum == 5)
        { 
            for (int i = 0; i < 10; i++)
            {
                obj = (GameObject)Instantiate(BlockBlue, new Vector3(-15.5f + i * 2.5f, 13, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
            }
            for (int i = 0; i < 5; i++)
            {
                obj = (GameObject)Instantiate(BlockGreen, new Vector3(-7.5f + i * 2.5f, 11.5f, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
            }
            for (int i = 0; i < 7; i++)
            {
                obj = (GameObject)Instantiate(BlockRed, new Vector3(-6.0f + i * 2.5f, 10, 0), Quaternion.identity);
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
            deadNum++;
            //ballexistence = false;
        }
    }

}
