using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitingAroundSphere : MonoBehaviour
{
    public float radius = 5f; // Set your desired radius here
    public float speed = 1f;  // Set your desired speed here

    float timeCounter = 0;

    void Update()
    {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter) * radius;
        float y = 7.5f;
        //float y = ;
        float z = Mathf.Sin(timeCounter) * radius;

        transform.position = new Vector3(x, y, z);
    }
}