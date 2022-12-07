using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleBall : MonoBehaviour
{
    Rigidbody rb;
    float Speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(-Speed, -Speed, 0, ForceMode.VelocityChange);
    }
}
