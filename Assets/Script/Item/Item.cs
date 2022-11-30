using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float speed = 5.0f;//�������x
    private string DeadWall = "Down";//�G��Ă͂����Ȃ���
    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.up * speed * Time.deltaTime;//���ɗ����Ă�
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == DeadWall)
        {
            //���ǐڐG���������
            Object.Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            //�p�h���ڐG���������
            Object.Destroy(this.gameObject);
        }
    }
}
