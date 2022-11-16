using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;     //移動速度
    public float minSpeed = 5f;  //速さの最小値
    public float maxSpeed = 10f; //速さの最大値

    Rigidbody rb;
    Transform tf;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(speed, speed, 0f);
        tf = transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = rb.velocity;
        float clampedSpeed = Mathf.Clamp(velocity.magnitude, minSpeed, maxSpeed);
        rb.velocity = velocity.normalized * clampedSpeed;
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
            rb.velocity = direction * speed;
        }
        // ステージ床と接触したら
        if (collision.gameObject.CompareTag("Down"))
        {
            Object.Destroy(gameObject);
        }
    }
}
