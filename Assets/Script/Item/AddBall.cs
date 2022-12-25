using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBall : MonoBehaviour
{
     void OnTriggerEnter(Collider collision)
    {
        GameManager BallAdd;
        GameObject obj = GameObject.Find("GameManager");
        BallAdd = obj.GetComponent<GameManager>();
        if (collision.gameObject.tag == "Player")
        {
            GameObject ball = GameObject.Instantiate(BallAdd.ballPrefab);
            ball.transform.parent = BallAdd.Balls.transform;
        }
    }
}
