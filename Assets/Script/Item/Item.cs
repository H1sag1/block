using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float speed = 5.0f;//—‰º‘¬“x
    private string DeadWall = "Down";//G‚ê‚Ä‚Í‚¢‚¯‚È‚¢•Ç
    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.up * speed * Time.deltaTime;//‰º‚É—‚¿‚Ä‚­
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == DeadWall)
        {
            //‰º•ÇÚG‚µ‚½‚çÁ‚·
            Object.Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            //ƒpƒhƒ‹ÚG‚µ‚½‚çÁ‚·
            Object.Destroy(this.gameObject);
        }
    }
}
