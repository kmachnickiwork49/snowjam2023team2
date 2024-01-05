using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireplaceManage : MonoBehaviour
{
    [SerializeField] public bool fireOn;
    [SerializeField] GameObject onFire;
    [SerializeField] GameObject offFire;

    void Start()
    {
        fireOn = true;
        onFire = GameObject.Find("Fireplace (on)");
        offFire = GameObject.Find("Fireplace (off)");
    }

    // Update is called once per frame
    void Update()
    {
        if(fireOn){
            onFire.SetActive(true);
            offFire.SetActive(false);
        }else{
            onFire.SetActive(false);
            offFire.SetActive(true);
        }
    }
}
