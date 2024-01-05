using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableFridgeManager : MonoBehaviour
{
    [SerializeField] public bool hasPlayedHangBear;
    [SerializeField] bool usedPapers;
    [SerializeField] GameObject beforePapers;
    [SerializeField] GameObject afterPapers;
    [SerializeField] GameObject afterHangBear;

    void Start()
    {
        hasPlayedHangBear = false;
        usedPapers = false;
        beforePapers = GameObject.Find("ClickableFridge(BeforePapers)");
        afterPapers = GameObject.Find("ClickableFridge(AfterPapers)");
        afterHangBear = GameObject.Find("ClickableFridge(AfterHangBear)");
    }

    // Update is called once per frame
    void Update()
    {
        if (hasPlayedHangBear)
        {
            beforePapers.SetActive(false);
            afterPapers.SetActive(false);
            afterHangBear.SetActive(true);
        }
        else
        {
            if (usedPapers)
            {
                beforePapers.SetActive(false);
                afterPapers.SetActive(true);
                afterHangBear.SetActive(false);
            }
            else
            {
                beforePapers.SetActive(true);
                afterPapers.SetActive(false);
                afterHangBear.SetActive(false);
            }

        }
    }
}
