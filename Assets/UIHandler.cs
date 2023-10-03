using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    //Select which scene to play
    public void OnButtonPress(string buttonValue)
    {
        switch (buttonValue)
        {

            case "Challenge":
                {
                    SceneManager.LoadScene("Challenge 1");
                    break;
                }
            case "Lab":
                {
                    SceneManager.LoadScene("Prototype 1");
                    break;
                }
            case "Exit":
                {
                    Application.Quit();
                    break;
                }
            default:
                {
                    break;
                }


        }
    }
}
