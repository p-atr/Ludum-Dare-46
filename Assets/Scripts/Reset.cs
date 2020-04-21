using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour {

    private float duration;
    private float startTime;

    private RawImage image;

    private void Awake()
    {
        this.image = this.GetComponent<RawImage>();
    }

    public void show(float duration)
    {
        this.duration = duration;
        this.startTime = Time.time;
        this.image.enabled = true;
    }


    private void Update() {
        if (Time.time > this.startTime + this.duration) // evtl check if already disabled
        {
            this.image.enabled = false;
        }
    }

}
