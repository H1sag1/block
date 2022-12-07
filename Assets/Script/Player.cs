using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f; //移動速度
    Rigidbody rb;

    public Vector3 scale = new Vector3(5, 1, 1); //バーの大きさ
    public float count = 10f;//アイテム効果時間

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, 0f, 0f);
        ScaleChange();
    }
    private void ScaleChange()//バーの大きさを元のサイズに
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
