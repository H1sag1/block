using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Speed = 15f;     //�ړ����x
    public float minSpeed = 15f;  //�����̍ŏ��l
    public float maxSpeed = 30f; //�����̍ő�l


    public Rigidbody rb;
    Transform tf;

    private AudioSource HitAudio;
    public AudioClip BallSE;
    public AudioClip BlockSE;
    // Start is called before the first frame update
    void Start()
    {
        HitAudio = gameObject.AddComponent<AudioSource>();
        BallStart();
    }

    public void BallStart()
    {
        rb = GetComponent<Rigidbody>();
        tf = transform;
        rb.AddForce(-Speed, -Speed, 0, ForceMode.VelocityChange);

        //rb = GetComponent<Rigidbody>();
        //rb.velocity = new Vector3(speed + 20, -speed, 0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        MaxMinSpeed();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // �v���C���[�ƐڐG������
        if (collision.gameObject.CompareTag("Player"))
        {
            // �v���C���[�̈ʒu���擾
            Vector3 playerPos = collision.transform.position;
            // �{�[���̈ʒu���擾
            Vector3 ballPos = tf.position;
            // �v���C���[���猩���{�[���̕������v�Z
            Vector3 direction = (ballPos - playerPos).normalized;
            // ���x��ύX
            rb.AddForce((-transform.up + transform.right) * 0.5f, ForceMode.VelocityChange);
        }
        //�v���C���[�܂��͕ǂɐڐG������
        if(collision.gameObject.name == "Player" ||
           collision.gameObject.name == "Up"     ||
           collision.gameObject.name == "Left"   ||
           collision.gameObject.name == "Right")
        {
            HitAudio.PlayOneShot(BallSE);
        }
        //�u���b�N�ɐڐG������
        if(collision.gameObject.name == "block")
        {
            HitAudio.PlayOneShot(BlockSE);
        }
        // �X�e�[�W���ƐڐG������
        if (collision.gameObject.CompareTag("Down"))
        {
            Object.Destroy(gameObject);
            BallStart();
        }
    }
    void MaxMinSpeed() //�{�[���̑��x�������߂�
    {
        // ���݂̑��x���擾
        Vector3 velocity = rb.velocity;
        // �������v�Z
        float clampedSpeed = Mathf.Clamp(velocity.magnitude, minSpeed, maxSpeed);
        // ���x��ύX
        rb.velocity = velocity.normalized * clampedSpeed;
    }
}
