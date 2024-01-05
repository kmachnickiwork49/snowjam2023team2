using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorImgManager : MonoBehaviour
{
    [SerializeField] public bool hasKey;
    [SerializeField] GameObject beforeKey;
    [SerializeField] GameObject afterKey;

    void Start()
    {
        hasKey = false;
        beforeKey = GameObject.Find("DoorImg(BeforeKey)");
        afterKey = GameObject.Find("DoorImg(AfterKey)");
    }

    // Update is called once per frame
    void Update()
    {
        if (hasKey)
        {
            beforeKey.SetActive(false);
            afterKey.SetActive(true);
        }
        else
        {
            beforeKey.SetActive(true);
            afterKey.SetActive(false);
        }
    }
}
