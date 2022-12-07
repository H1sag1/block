using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float speed = 5.0f;//落下速度
    private string DeadWall = "Down";//触れてはいけない壁
    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.up * speed * Time.deltaTime;//下に落ちてく
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == DeadWall)
        {
            //下壁接触したら消す
            Object.Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            //パドル接触したら消す
            Object.Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Down"))
        {
            Object.Destroy(gameObject);
        }
    }
}
