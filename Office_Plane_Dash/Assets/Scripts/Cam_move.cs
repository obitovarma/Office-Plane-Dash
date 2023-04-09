using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_move : MonoBehaviour
{
    public float speed = 2;
    void Update()
    {
        // Moves the object forward at two units per second.
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}



