using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SimpleVRButton : MonoBehaviour
{
    public AudioSource voiceoverAudio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!voiceoverAudio.isPlaying)
                voiceoverAudio.Play();
        }
    }
}
