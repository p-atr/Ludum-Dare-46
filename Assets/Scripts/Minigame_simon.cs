using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame_simon : MonoBehaviour
{
    public GameObject flash_red;
    public GameObject flash_green;
    public GameObject flash_blue;
    public GameObject flash_yellow;
    private int[] check = { 0, 1, 2, 3 };
    private int[] guess = new int[4];
    private int counter = 0;

    public GameObject puzzleConsole;

    // Start is called before the first frame update
    void OnEnable()
    {
        Debug.Log("simon_start");
        StartCoroutine(sequence_coroutine());
    }


    // Update is called once per frame
    void Update()
    {
        if (counter > 3)
        {
            counter = 0;
            Debug.Log("END");
            if ((guess[0] == check[0]) & (guess[1] == check[1]) & (guess[2] == check[2]) & (guess[3] == check[3]))
            {
                Debug.Log("TRUE");
                puzzleConsole.GetComponent<puzzleController>().success = 1;
            }
            else
            {
                Debug.Log("FALSE");
                puzzleConsole.GetComponent<puzzleController>().success = 2;
            }
        }
    }

    IEnumerator sequence_coroutine()
    {
        Debug.Log("Started Sequence at : " + Time.time);
        GameObject[] sequence = { flash_red, flash_green, flash_blue, flash_yellow };

        foreach (GameObject go in sequence)
        {
            go.SetActive(true);
            yield return new WaitForSeconds(1);
            go.SetActive(false);
            yield return new WaitForSeconds(1);
        }

        Debug.Log("Finished Sequence at : " + Time.time);
    }


    public void RED()
    {
        Debug.Log("RED = 0");
        guess[counter] = 0;
        counter += 1;
    }
    
    public void GREEN()
    {
        Debug.Log("GREEN = 1");
        guess[counter] = 1;
        counter += 1;
    }

    public void BLUE()
    {
        Debug.Log("BLUE = 2");
        guess[counter] = 2;
        counter += 1;
    }

    public void YELLOW()
    {
        Debug.Log("YELLOW = 3");
        guess[counter] = 3;
        counter += 1;

    }

}
