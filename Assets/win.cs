﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Franky")
        {
            GameObject.Find("Lived").GetComponent<Reset>().show(10f);
        }
    }
}
