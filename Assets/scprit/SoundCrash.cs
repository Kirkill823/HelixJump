using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCrash : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }
}
