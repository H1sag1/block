using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlocks : MonoBehaviour
{
    Transform tf;
    // Start is called before the first frame update
    void Start()
    {
        tf =  transform;
    }

    // Update is called once per frame
    void Update()
    {
        tf.Rotate(0.1f, 0.1f, 0.1f);
    }
}
