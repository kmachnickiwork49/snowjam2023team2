using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableBoxManager : MonoBehaviour
{
    [SerializeField] public bool hasPlayedHangBear;
    [SerializeField] bool hasKey;
    [SerializeField] GameObject doesntHaveKey;
    [SerializeField] GameObject doesHaveKey;
    [SerializeField] GameObject afterHangBear;

    void Start()
    {
        hasPlayedHangBear = false;
        hasKey = false;
        doesntHaveKey = GameObject.Find("ClickableBox(DoesntHaveKey)");
        doesHaveKey = GameObject.Find("ClickableBox(HasKey)");
        afterHangBear = GameObject.Find("ClickableBox(AfterHangBear)");
    }

    // Update is called once per frame
    void Update()
    {
        if (hasPlayedHangBear)
        {
            doesntHaveKey.SetActive(false);
            doesHaveKey.SetActive(false);
            afterHangBear.SetActive(true);
        }
        else
        {
            if (hasKey)
            {
                doesntHaveKey.SetActive(false);
                doesHaveKey.SetActive(true);
                afterHangBear.SetActive(false);
            }
            else
            {
                doesntHaveKey.SetActive(true);
                doesHaveKey.SetActive(false);
                afterHangBear.SetActive(false);
            }
            
        }
    }
}
