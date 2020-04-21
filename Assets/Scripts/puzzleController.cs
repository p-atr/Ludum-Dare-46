using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleController : MonoBehaviour
{

    public GameObject puzzle;
    public GameObject trap;

    public int success = 0; //not tried | success | failiure | already won
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (success == 1) {
            trap.SetActive(false);
            puzzle.SetActive(false);
            GameObject.FindGameObjectWithTag("Player").GetComponent<playerController>().enabled = true;
            success = 3;
        } else if (success == 2)
        {
            puzzle.SetActive(false);
            GameObject.FindGameObjectWithTag("Player").GetComponent<playerController>().enabled = true;
            success = 0;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player" && Input.GetKey(KeyCode.E))
        {
            puzzle.SetActive(true);
            collision.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            collision.GetComponent<playerController>().enabled = false;
        }
    }
}
