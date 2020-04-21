using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurePlate : MonoBehaviour
{
    public GameObject trap;
    public Sprite up, down;
    public int mode = 1; //false
    SpriteRenderer sr;
    public int objectsOnPlate = 0;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        objectsOnPlate++;
        trap.GetComponent<trap>().activated-=mode;
        trap.GetComponent<trap>().check();
        sr.sprite = down;
    }   

    private void OnTriggerExit2D(Collider2D collision)
    {
        objectsOnPlate--;
        trap.GetComponent<trap>().activated += mode;
        trap.GetComponent<trap>().check();
        sr.sprite = up;
        //if (objectsOnPlate <= 0)
        //{

        //}
    }
    
}
