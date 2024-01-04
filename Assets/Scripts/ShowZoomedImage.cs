using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowZoomedImage : MonoBehaviour
{

    [SerializeField] private GameObject my_go;

    // Start is called before the first frame update
    void Start()
    {
        my_go.SetActive(false);
    }

    void OnMouseDown()
    {
        Debug.Log("BUTTON PRESSED");
        my_go.SetActive(true);
    }

}
