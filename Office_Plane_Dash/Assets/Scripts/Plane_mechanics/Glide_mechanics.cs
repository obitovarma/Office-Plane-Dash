using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glide_mechanics : MonoBehaviour
{
    public float forceMagnitude = 10f;

    private Rigidbody rb;
    public float speed = 2;
    void Update()
    {
        // Moves the object forward at two units per second.
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        // Apply negative force on y-axis
        rb.AddForce(Vector3.down * forceMagnitude, ForceMode.Force);
    }
}



