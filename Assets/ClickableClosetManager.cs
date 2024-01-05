using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableClosetManager : MonoBehaviour
{
    [SerializeField] public bool hasPlayedHangBear;
    [SerializeField] GameObject beforeHangBear;
    [SerializeField] GameObject afterHangBear;

    void Start()
    {
        hasPlayedHangBear = false;
        beforeHangBear = GameObject.Find("ClickableCloset(BeforeHangBear)");
        afterHangBear = GameObject.Find("ClickableCloset(AfterHangBear)");
    }

    // Update is called once per frame
    void Update()
    {
        if (hasPlayedHangBear)
        {
            beforeHangBear.SetActive(false);
            afterHangBear.SetActive(true);
        }
        else
        {
            beforeHangBear.SetActive(true);
            afterHangBear.SetActive(false);
        }
    }
}
