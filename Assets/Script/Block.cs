using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public GameObject[] itemPrefabs;//出現アイテムの倉庫
    private int number;
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
        Object.Destroy(this.gameObject);
        number = Random.Range(0, itemPrefabs.Length);　//倉庫の中からランダムで
        Instantiate(itemPrefabs[number], this.transform.position, Quaternion.identity);
    }
}
