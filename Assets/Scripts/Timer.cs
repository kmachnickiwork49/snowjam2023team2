using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

//reference from: https://www.youtube.com/watch?v=HmHPJL-OcQE&t=572s

public class Timer : MonoBehaviour
{

    [SerializeField] public string myScene;

    public float timeValue = 90;
    public TMP_Text _timeText;
    // Start is called before the first frame update
    void Start()
    {
        //timeValue = 90f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0){
            timeValue -= Time.deltaTime;
        }else {
            timeValue = 0;
        }
        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay){
        if (timeToDisplay <= 0) {
            timeToDisplay = 0;
            _timeText.text = "TIME'S UP!!";
            
            // Scene transition instantly, should have a delay in final product
            if (myScene != "") {
                SceneManager.LoadScene(myScene);
            }

            return;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        _timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
