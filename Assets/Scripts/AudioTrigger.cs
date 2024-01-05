using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    [SerializeField] public AudioSource audio;


    public void OnMouseDown(){
        audio.Play();
    }
}