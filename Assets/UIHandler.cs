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
                    Quit();

                    break;
                }
            default:
                {
                    break;
                }


        }
    }
    public void Quit()
    {
        #if (UNITY_EDITOR || DEVELOPMENT_BUILD)
        Debug.Log(this.name + " : " + this.GetType() + " : " + System.Reflection.MethodBase.GetCurrentMethod().Name);
        #endif
        #if (UNITY_EDITOR)
        UnityEditor.EditorApplication.isPlaying = false;
        #elif (UNITY_STANDALONE)
            Application.Quit();
        #elif (UNITY_WEBGL)
            Application.OpenURL("https://learn.unity.com/");
        #endif
    }
}
