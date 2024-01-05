using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowZoomedImage : MonoBehaviour
{

    [SerializeField] private GameObject my_go;
    public GameObject go_object{
        get{return my_go;}
        set{}
    }

    // Start is called before the first frame update
    void Start()
    {
        if (my_go != null) {
            my_go.SetActive(false);
        }
    }

    void OnMouseDown()
    {
        Debug.Log("BUTTON PRESSED");
        if (my_go != null) {
            my_go.SetActive(true);
        }
    }

    public void SwitchActive() {
        if (my_go != null) {
            my_go.SetActive(!(my_go.activeSelf));
        }
    }

}
