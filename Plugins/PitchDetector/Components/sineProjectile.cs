using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sineProjectile : MonoBehaviour
{


    public float MoveSpeed = 5.0f;

    public float frequency = 10.0f;  // Speed of sine movement
    public float magnitude = 0.5f;   // Size of sine movement
    
    private Vector3 axis;

    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        Destroy(gameObject, 2.0f); // float is time till destroyed
        axis = Vector3.right;  // May or may not be the axis you want
    }

    // Update is called once per frame
    void Update()
    {
       
        pos += transform.up * Time.deltaTime * MoveSpeed;
        transform.position = pos + axis * Mathf.Sin(Time.time * frequency) * magnitude;
    }
}
