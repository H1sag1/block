using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarLong : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        Player playerCon;
        GameObject obj = GameObject.Find("Player");
        playerCon = obj.GetComponent<Player>();
        if (collision.gameObject.tag == "Player")
        {
            playerCon.scale = new Vector3(7, 1, 1);//ƒo[‚Ìx•ûŒü‚Ì‘å‚«‚³‚ğ‚V‚É
            playerCon.count = 10;//Œø‰ÊŠÔ10•b‚É
            Debug.Log("sizeUp");
        }
    }
}
