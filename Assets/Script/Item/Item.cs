using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float speed = 5.0f;//—‰º‘¬“x
    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.up * speed * Time.deltaTime;//‰º‚É—‚¿‚Ä‚­
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Down"))
        {
            //‰º•ÇÚG‚µ‚½‚çÁ‚·
            Object.Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            //ƒpƒhƒ‹ÚG‚µ‚½‚çÁ‚·
            Object.Destroy(this.gameObject);
        }
    }
}
