using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    [SerializeField] public bool isAlarmOff;
    [SerializeField] GameObject beforeAlarmOff;
    [SerializeField] GameObject afterAlarmOff;

    void Start()
    {
        isAlarmOff = false;
        beforeAlarmOff = GameObject.Find("Door(BeforeAlarmOff)");
        afterAlarmOff = GameObject.Find("Door(AfterAlarmOff)");
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlarmOff)
        {
            beforeAlarmOff.SetActive(false);
            afterAlarmOff.SetActive(true);
        }
        else
        {
            beforeAlarmOff.SetActive(true);
            afterAlarmOff.SetActive(false);
        }
    }
}
