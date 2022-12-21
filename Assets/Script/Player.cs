using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f; //�ړ����x
    Rigidbody rb;

    public Vector3 scale = new Vector3(5, 1, 1); //�o�[�̑傫��
    public float count = 10f;//�A�C�e�����ʎ���

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector3(speed, 0, 0);
            Debug.Log("right");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector3(-speed, 0, 0);
            Debug.Log("left");
        }

        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
        ScaleChange();
    }
    private void ScaleChange()//�o�[�̑傫�������̃T�C�Y��
    {
        gameObject.transform.localScale = scale;

        if (gameObject.transform.localScale.x > 5 || gameObject.transform.localScale.x < 5)
        {
            count -= Time.deltaTime;
        }
        if (count < 0)
        {
            scale = new Vector3(5, 1, 1);
        }
    }
}
