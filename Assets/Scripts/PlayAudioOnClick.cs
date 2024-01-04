using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnClick : MonoBehaviour
{
    [SerializeField] private AudioSource audio;
    private int numPlayed = 0;
    [SerializeField] private int numActivations = 1;

    void Start() {
        numPlayed = 0;
    }

    private void OnMouseDown()
    {
        if (numPlayed >= numActivations) {
            audio.Play();
        }
        numPlayed = numPlayed + 1;
    }
}
