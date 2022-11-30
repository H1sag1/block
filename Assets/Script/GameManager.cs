using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lifeNum = 3; //ÉâÉCÉtÇÃêî

    public GameObject Blocks;
    public GameObject block;
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        OnBlock();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnBlock()
    {
        //for (int i = 0; i < 7; i++)
        //{
        //    obj = (GameObject)Instantiate(BlockBrue, new Vector3(-7.5f + i * 2.5f, 13, 0), Quaternion.identity);
        //    obj.transform.parent = Blocks.transform;
        //    itemNum++;
        //    //GameObject Blocks = (GameObject)Instantiate(BlockBrue, transform.position, Quaternion.identity);
        //    //Blocks.transform.position = new Vector3(-7.5f + i * 2.5f, 13, 0);
        //    //Blocks.transform.parent = transform;
        //}
        //for (int i = 0; i < 7; i++)
        //{
        //    obj = (GameObject)Instantiate(BlockGreen, new Vector3(-7.5f + i * 2.5f, 11.5f, 0), Quaternion.identity);
        //    obj.transform.parent = Blocks.transform;
        //    itemNum++;
        //    //GameObject blockG = GameObject.Instantiate(BlockGreen);
        //    //blockG.transform.position = new Vector3(-7.5f + i * 2.5f, 11.5f, 0);
        //}
        //for (int i = 0; i < 7; i++)
        //{
        //    obj = (GameObject)Instantiate(BlockYellow, new Vector3(-7.5f + i * 2.5f, 10, 0), Quaternion.identity);
        //    obj.transform.parent = Blocks.transform;
        //    itemNum++;
        //    //GameObject blockY = GameObject.Instantiate(BlockYellow);
        //    //blockY.transform.position = new Vector3(-7.5f + i * 2.5f, 10, 0);
        //}
        for(int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                obj = (GameObject)Instantiate(block, new Vector3(-7.5f + i * 2.5f, 16f - j * 1.5f, 0), Quaternion.identity);
                obj.transform.parent = Blocks.transform;
            }
        }
    }
}
