using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject franky;
    private void Start()
    {

    }
    private void OnEnable()
    {
        player.GetComponent<playerController>().enabled = false;
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        franky.GetComponent<frankyScript>().enabled = false;
        GameObject[] pcs = GameObject.FindGameObjectsWithTag("Puzzle");
        for(int i = 0; i<pcs.Length; i++)
        {
            Debug.Log("i");
            pcs[i].SetActive(false);
            //pcs[i].GetComponent<puzzleController>().success = 2;
        }
    }

    private void OnDisable()
    {
        if(player != null && franky != null)
        {
            player.GetComponent<playerController>().enabled = true;
            franky.GetComponent<frankyScript>().enabled = true;
        }        
    }
}
