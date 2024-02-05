using UnityEngine;

public class LightController : MonoBehaviour
{
    private Light pointLight;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Light component of the GameObject
        pointLight = GetComponent<Light>();

    }

    // Update is called once per frame
    void Update()
    {
        // Check for input to change the light color
        if (Input.GetButtonDown("Fire1")) // You can replace "Fire1" with your designated input button
        {
            // Change the light color to a new color (e.g., red)
            pointLight.color = Color.green;

        }
    }
}
