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
        YSpeed();
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameManager gameManager;
        GameObject obj = GameObject.Find("GameManager");
        gameManager = obj.GetComponent<GameManager>();

        // �v���C���[�ƐڐG������
        if (collision.gameObject.CompareTag("Player"))
        {
            // �v���C���[�̈ʒu���擾
            Vector3 playerPos = collision.transform.position;
            // �{�[���̈ʒu���擾
            Vector3 ballPos = tf.position;
            // �v���C���[���猩���{�[���̕������v�Z
            Vector3 direction = (ballPos - playerPos).normalized;
            float speed = rb.velocity.magnitude;
            // ���x��ύX
            rb.velocity = direction * speed;
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
        if(collision.gameObject.name == "block(Clone)")
        {
            HitAudio.PlayOneShot(BlockSE);
        }
        // �X�e�[�W���ƐڐG������
        if (collision.gameObject.CompareTag("Down"))
        {
            Object.Destroy(gameObject);
            gameManager.deadNum++;
            gameManager.ballexistence = false;
            Debug.Log(gameManager.deadNum);
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

    void YSpeed()
    {
        if (Mathf.Abs(rb.velocity.y) < 4)
        {
            float vec = rb.velocity.y > 0 ? 4 : -4;
            rb.velocity += new Vector3(0, vec, 0);
            Debug.Log("�ł���");
        }
    }
}
