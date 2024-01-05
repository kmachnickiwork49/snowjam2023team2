using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableLaptopManager : MonoBehaviour
{
    [SerializeField] public bool hasPlayedHangBear;
    [SerializeField] bool hasPIN;
    [SerializeField] GameObject beforePIN;
    [SerializeField] GameObject afterPIN;
    [SerializeField] GameObject afterHangBear;

    void Start()
    {
        hasPlayedHangBear = false;
        hasPIN = false;
        beforePIN = GameObject.Find("ClickableLaptop(BeforePIN)");
        afterPIN = GameObject.Find("ClickableLaptop(AfterPIN)");
        afterHangBear = GameObject.Find("ClickableLaptop(AfterHangBear)");
    }

    // Update is called once per frame
    void Update()
    {
        if (hasPlayedHangBear)
        {
            beforePIN.SetActive(false);
            afterPIN.SetActive(false);
            afterHangBear.SetActive(true);
        }
        else
        {
            if (hasPIN)
            {
                beforePIN.SetActive(false);
                afterPIN.SetActive(true);
                afterHangBear.SetActive(false);
            }
            else
            {
                beforePIN.SetActive(true);
                afterPIN.SetActive(false);
                afterHangBear.SetActive(false);
            }

        }
    }
}
