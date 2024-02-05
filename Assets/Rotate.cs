using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 10.0f;

    void Update()
    {
        // Rotate the sphere around its own up axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
