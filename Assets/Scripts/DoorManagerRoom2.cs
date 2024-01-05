using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManagerRoom2 : MonoBehaviour
{
    [SerializeField] bool hasKey;
    [SerializeField] GameObject noKey;
    [SerializeField] GameObject withKey;

    void Start()
    {
        hasKey = false;
        noKey = GameObject.Find("DoorImg(NoKey)");
        withKey = GameObject.Find("DoorImg(WithKey)");
    }

    // Update is called once per frame
    void Update()
    {
        if (hasKey)
        {
            noKey.SetActive(false);
            withKey.SetActive(true);
        }
        else
        {
            noKey.SetActive(true);
            withKey.SetActive(false);
        }
    }
}
