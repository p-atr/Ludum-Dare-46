using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private float duration;
    private float startTime;

    private AudioSource audio;

    private void Awake()
    {
        this.audio = this.GetComponent<AudioSource>();
    }

    public void playAudio(float duration)
    {
        this.duration = duration;
        this.startTime = Time.time;
        this.audio.enabled = true;
    }


    private void Update()
    {
        if (Time.time > this.startTime + this.duration) // evtl check if already disabled
        {
            this.audio.enabled = false;
        }
    }
}
