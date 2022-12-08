using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float speed = 5.0f;//�������x
    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.up * speed * Time.deltaTime;//���ɗ����Ă�
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Down"))
        {
            //���ǐڐG���������
            Object.Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            //�p�h���ڐG���������
            Object.Destroy(this.gameObject);
        }
    }
}
