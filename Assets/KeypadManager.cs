using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadManager : MonoBehaviour
{
    [SerializeField] public bool hasAllKeys;
    [SerializeField] GameObject withoutKey;
    [SerializeField] GameObject withKey;

    void Start()
    {
        hasAllKeys = true;
        withoutKey = GameObject.Find("Keypad (without key)");
        withKey = GameObject.Find("Keypad (with key)");
    }

    // Update is called once per frame
    void Update()
    {
        if (hasAllKeys)
        {
            withoutKey.SetActive(false);
            withKey.SetActive(true);
        }
        else
        {
            withoutKey.SetActive(true);
            withKey.SetActive(false);
        }
    }
}
