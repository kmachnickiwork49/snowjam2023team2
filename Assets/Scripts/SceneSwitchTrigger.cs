using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchTrigger : MonoBehaviour
{

    // Code ripped from previous project, ACM Studio Team OMO

    // SerializeField means you can edit this attribute in the Unity editor! 
    // Will appear as a form-filling text box usually, or a drop-down menu (of objects)
    // Use this to customize script "settings" for each object
    [SerializeField] public string myScene;

    void OnMouseDown()
    {
        Debug.Log("BUTTON PRESSED");
        SceneManager.LoadScene(myScene);
        // Allows for scene switching
        // Whenever you load a scene, it will be like the scene just started, progress should reset
    }

    void OnMouseOver()
    {
        //Debug.Log("HIGHLIGHTED");
    }

    void OnMouseExit()
    {
        //Debug.Log("UNHIGHLIGHTED");
    }
}
