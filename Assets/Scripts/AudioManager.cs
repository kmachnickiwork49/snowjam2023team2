using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
    {
    [SerializeField] public AudioSource audioSound;

    public void StartAudio(Audio audio)
    {
        GetComponent<AudioSource>().clip = Resources.Load<AudioClip>("audioFile");
        GetComponent<AudioSource>().Play();
    }

       public void MuteAllSound()
    {
        AudioListener.volume = 0;
    }

    public void UnMuteAllSound()
    {
        AudioListener.volume = 1;
    }
}
 