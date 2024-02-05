using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Quit : MonoBehaviour
{
    public string quitButtonName = "Fire2"; // Change this based on your controller input configuration

    void Update()
    {
        // Check if the specified button is pressed
        if (Input.GetButtonDown(quitButtonName))
        {
            // Call the function to quit the game
            QuitGameFunction();
          

        }
    }

    void QuitGameFunction()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }


}
