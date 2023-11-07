using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateNewStar : MonoBehaviour
{
    Rigidbody rb;
    float height;
    public float reversegravity;
    void Start()
    {
        height = Random.Range(3, 10);
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.AddForce(Vector3.up * reversegravity);
        //if(GetComponent<Rigidbody>().velocity)
        {

        }
    }
}
