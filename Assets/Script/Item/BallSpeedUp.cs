using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpeedUp : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        Ball ballCon;
        GameObject obj = GameObject.Find("Ball");
        ballCon = obj.GetComponent<Ball>();
        if (collision.gameObject.tag == "Player")
        {
            //進行方向に今のスピードに3かける
            ballCon.rb.AddForce(ballCon.rb.velocity.x * 3, ballCon.rb.velocity.y * 3, 0, ForceMode.VelocityChange);
        }
    }
}
