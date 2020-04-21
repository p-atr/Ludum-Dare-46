using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimManager : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
            animator.SetBool("Is Running", true);
        }
        else if(Input.GetAxis("Horizontal") < 0)
        {
            transform.rotation = new Quaternion(0, 180, 0, 0);
            animator.SetBool("Is Running", true);
        }
        else
        {
            animator.SetBool("Is Running", false);
        }
    }
}
