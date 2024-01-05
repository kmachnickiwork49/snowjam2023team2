using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableBooksManager : MonoBehaviour
{
    [SerializeField] public bool hasPlayedHangBear;
    [SerializeField] bool usedLaptop;
    [SerializeField] GameObject beforeLaptop;
    [SerializeField] GameObject afterLaptop;
    [SerializeField] GameObject afterHangBear;

    void Start()
    {
        hasPlayedHangBear = false;
        usedLaptop = false;
        beforeLaptop = GameObject.Find("ClickableBooks(BeforeLaptop)");
        afterLaptop = GameObject.Find("ClickableBooks(AfterLaptop)");
        afterHangBear = GameObject.Find("ClickableBooks(AfterHangBear)");
    }

    // Update is called once per frame
    void Update()
    {
        if (hasPlayedHangBear)
        {
            beforeLaptop.SetActive(false);
            afterLaptop.SetActive(false);
            afterHangBear.SetActive(true);
        }
        else
        {
            if (usedLaptop)
            {
                beforeLaptop.SetActive(false);
                afterLaptop.SetActive(true);
                afterHangBear.SetActive(false);
            }
            else
            {
                beforeLaptop.SetActive(true);
                afterLaptop.SetActive(false);
                afterHangBear.SetActive(false);
            }

        }
    }
}
