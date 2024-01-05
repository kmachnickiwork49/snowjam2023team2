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

    [SerializeField] public float INITIAL_TIME_VALUE = 90f;
    [SerializeField] private TMP_Text _timeText;
    [SerializeField] private bool clockRunning;
    private float timeValue;
    // Start is called before the first frame update
    void Start()
    {
        clockRunning = true; // PLEASE CHANGE AS NECESSARY
        timeValue = INITIAL_TIME_VALUE;
    }

    // Update is called once per frame
    void Update()
    {
        if (clockRunning)
        {
            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
            }
            else
            {
                timeValue = 0;
            }
        }
        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay){
        if (timeToDisplay <= 0) {
            timeToDisplay = 0;
            _timeText.text = "TIME'S UP!!"; // PLEASE CHANGE AS NECESSARY
            
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

    public void SetTimeToZero()
    {
        timeValue = 0;
    }

    public void AddTimeToTimer(float additionalTime)
    {
        timeValue += additionalTime;
    }

    public void ResetTime()
    {
        timeValue = INITIAL_TIME_VALUE;
    }

    public void resumeClock()
    {
        clockRunning = true;
    }

    public void stopClock()
    {
        clockRunning = false;
    }

    public int getMinutes()
    {
        float minutes = Mathf.FloorToInt(timeValue / 60);
        return (int)minutes;
    }

    public int getSeconds()
    {
        float seconds = Mathf.FloorToInt(timeValue % 60);
        return (int)seconds;
    }

}
