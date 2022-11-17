using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class StageSelect : MonoBehaviour
{
    private RectTransform arrows;
    // Start is called before the first frame update
    void Start()
    {
        Transform transform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0.5f, 0, 0,Space.World);

        //�����L�[�������ꂽ��
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.localPosition += new Vector3(0, -140,0);
        }
        //��ʊO�����Ȃ����߂̏���
        if(transform.localPosition.y < -80)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, -80, transform.localPosition.z);
        }

        //����L�[�������ꂽ��
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.localPosition += new Vector3(0, 140, 0);
        }
        //��ʊO�����Ȃ����߂̏���
        if (transform.localPosition.y  > 60)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, 60, transform.localPosition.z);
        }

        //�����L�[�������ꂽ��
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localPosition += new Vector3(-190, 0, 0);
        }
        //��ʊO�����Ȃ����߂̏���
        if (transform.localPosition.x < -470)
        {
            transform.localPosition = new Vector3(-470, transform.localPosition.y, transform.localPosition.z);
        }

        //�E���L�[�������ꂽ��
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localPosition += new Vector3(190, 0, 0);
        }
        //��ʊO�����Ȃ����߂̏���
        if (transform.localPosition.x > 290)
        {
            transform.localPosition = new Vector3(290, transform.localPosition.y, transform.localPosition.z);
        }

       
    }
    

}
