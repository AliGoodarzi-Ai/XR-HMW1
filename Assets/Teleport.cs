using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    void Update()
    {
        // Check for input to change the light color
        if (Input.GetButtonDown("Fire3")) // You can replace "Fire1" with your designated input button
        {
        transform.position = new Vector3(5, 19, 0);

}
}
}
