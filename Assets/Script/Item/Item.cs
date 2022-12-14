using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float speed = 5.0f;//落下速度
    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.up * speed * Time.deltaTime;//下に落ちてく
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Down"))
        {
            //下壁接触したら消す
            Object.Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            //パドル接触したら消す
            Object.Destroy(this.gameObject);
        }
    }
}
