using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarLong : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        Player playerCon;
        GameObject obj = GameObject.Find("Player");
        playerCon = obj.GetComponent<Player>();
        if (collision.gameObject.tag == "Player")
        {
            playerCon.scale = new Vector3(7, 1, 1);//バーのx方向の大きさを７に
            playerCon.count = 10;//効果時間10秒に
            Debug.Log("sizeUp");
        }
    }
}
