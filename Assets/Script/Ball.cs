using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Speed = 15f;     //移動速度
    public float minSpeed = 15f;  //速さの最小値
    public float maxSpeed = 30f; //速さの最大値


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
        // プレイヤーと接触したら
        if (collision.gameObject.CompareTag("Player"))
        {
            // プレイヤーの位置を取得
            Vector3 playerPos = collision.transform.position;
            // ボールの位置を取得
            Vector3 ballPos = tf.position;
            // プレイヤーから見たボールの方向を計算
            Vector3 direction = (ballPos - playerPos).normalized;
            // 速度を変更
            rb.AddForce((-transform.up + transform.right) * 0.5f, ForceMode.VelocityChange);
        }
        //プレイヤーまたは壁に接触したら
        if(collision.gameObject.name == "Player" ||
           collision.gameObject.name == "Up"     ||
           collision.gameObject.name == "Left"   ||
           collision.gameObject.name == "Right")
        {
            HitAudio.PlayOneShot(BallSE);
        }
        //ブロックに接触したら
        if(collision.gameObject.name == "block")
        {
            HitAudio.PlayOneShot(BlockSE);
        }
        // ステージ床と接触したら
        if (collision.gameObject.CompareTag("Down"))
        {
            Object.Destroy(gameObject);
            BallStart();
        }
    }
    void MaxMinSpeed() //ボールの速度幅を決める
    {
        // 現在の速度を取得
        Vector3 velocity = rb.velocity;
        // 速さを計算
        float clampedSpeed = Mathf.Clamp(velocity.magnitude, minSpeed, maxSpeed);
        // 速度を変更
        rb.velocity = velocity.normalized * clampedSpeed;
    }
}
