using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpeedUp : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        Ball ballCon;
        GameObject obj = GameObject.Find("ballPrefab(Clone)");
        ballCon = obj.GetComponent<Ball>();
        if (collision.gameObject.tag == "Player")
        {
            //�i�s�����ɍ��̃X�s�[�h��3������
            ballCon.rb.AddForce(ballCon.rb.velocity.x * 2, ballCon.rb.velocity.y * 2, 0, ForceMode.VelocityChange);
        }
    }
}
