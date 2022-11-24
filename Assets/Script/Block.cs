using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        GameObject obj = (GameObject)Resources.Load("Item");
        Instantiate(obj, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
