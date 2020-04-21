using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineLogic : MonoBehaviour
{
    public GameObject[] goa;
    public GameObject[] lines;
    public GameObject correct;
    public GameObject l0;
    private int Progress = 0;
    private bool Interupt = false;
    private bool reset = false;

    public GameObject puzzleConsole;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Sequence_coroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator coorect()
    {
        correct.SetActive(true);
        yield return new WaitForSeconds(0.75f);
        correct.SetActive(false);
    }

    IEnumerator Sequence_coroutine()
    {
        while ((Progress < goa.Length) & !reset)
        {
            int i = Random.Range(Progress, goa.Length);
            goa[i].SetActive(true);
            yield return new WaitForSeconds(0.75f);
            if (Interupt)
            {
                Interupt = false;
            }
            else
            {
                goa[i].SetActive(false);
            }
        }
    }

    private void ResetLine()
    {
        reset = true;
        Progress = 0;
        Debug.Log("123");

        for (int i = 0; i < goa.Length; i++)
        {
            Debug.Log(i);
            goa[i].SetActive(false);
            lines[i].SetActive(false);
        }
        l0.SetActive(false);
        reset=false;
    }

    public void background()
    {
        Debug.Log("BACKGROUND");
        ResetLine();
    }


    public void n1()
    {
        Debug.Log("n1");
        Interupt = true;
        if (Progress == 0)
        {
            StartCoroutine(coorect());
            goa[Progress].SetActive(false);
            l0.SetActive(true);
            Progress += 1;
            
        }
        else
        {
            Debug.Log("FAIL -> RESTART");
            ResetLine();
        }
    }

    public void n2()
    {
        Debug.Log("n2");
        Interupt = true;
        if (Progress == 1)
        {
            StartCoroutine(coorect());
            lines[Progress-1].SetActive(true);
            goa[Progress].SetActive(false);
            Progress += 1;
        }
        else
        {
            Debug.Log("FAIL -> RESTART");
            ResetLine();
        }
    }

    public void n3()
    {
        Debug.Log("n3");
        Interupt = true;
        if (Progress == 2)
        {
            StartCoroutine(coorect());
            lines[Progress - 1].SetActive(true);
            goa[Progress].SetActive(false);
            Progress += 1;
        }
        else
        {
            Debug.Log("FAIL -> RESTART");
            ResetLine();
        }
    }

    public void n4()
    {
        Debug.Log("n4");
        Interupt = true;
        if (Progress == 3)
        {
            StartCoroutine(coorect());
            lines[Progress - 1].SetActive(true);
            goa[Progress].SetActive(false);
            Progress += 1;
        }
        else
        {
            Debug.Log("FAIL -> RESTART");
            ResetLine();
        }
    }

    public void n5()
    {
        Debug.Log("n5");
        Interupt = true;
        if (Progress == 4)
        {
            StartCoroutine(coorect());
            lines[Progress - 1].SetActive(true);
            goa[Progress].SetActive(false);
            Progress += 1;
        }
        else
        {
            Debug.Log("FAIL -> RESTART");
            ResetLine();
        }
    }

    public void n6()
    {
        Debug.Log("n6");
        Interupt = true;
        if (Progress == 5)
        {
            StartCoroutine(coorect());
            lines[Progress - 1].SetActive(true);
            goa[Progress].SetActive(false);
            Progress += 1;
        }
        else
        {
            Debug.Log("FAIL -> RESTART");
            ResetLine();
        }
    }

    public void n7()
    {
        Debug.Log("n7");
        Interupt = true;
        if (Progress == 6)
        {
            StartCoroutine(coorect());
            lines[Progress - 1].SetActive(true);
            goa[Progress].SetActive(false);
            Progress += 1;
            lines[Progress - 1].SetActive(true);
            Debug.Log("LineGame TRUE");
            puzzleConsole.GetComponent<puzzleController>().success = 1;
        }
        else
        {
            Debug.Log("FAIL -> RESTART");
            ResetLine();
            puzzleConsole.GetComponent<puzzleController>().success = 2;
        }
    }
}
