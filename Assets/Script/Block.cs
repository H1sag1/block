using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public GameObject[] itemPrefabs;//�o���A�C�e���̑q��
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
        number = Random.Range(0, itemPrefabs.Length);�@//�q�ɂ̒����烉���_����
        Instantiate(itemPrefabs[number], this.transform.position, Quaternion.identity);
    }
}
