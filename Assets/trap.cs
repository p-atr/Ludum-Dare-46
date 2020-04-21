using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    public int activated;
    public bool animation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void check()
    {
        if (activated <= 0)
        {
            if (animation) {gameObject.GetComponent<Animator>().SetBool("spike DOWN", true); gameObject.GetComponent<Animator>().SetBool("spike UP", false); }
            else {gameObject.GetComponent<SpriteRenderer>().enabled = false;}
            gameObject.GetComponent<Collider2D>().enabled = false;
        }
        else
        {
            if (animation) { gameObject.GetComponent<Animator>().SetBool("spike UP", true); gameObject.GetComponent<Animator>().SetBool("spike DOWN", false); }
            else { gameObject.GetComponent<SpriteRenderer>().enabled = true; }
            gameObject.GetComponent<Collider2D>().enabled = true;
        }
        Debug.Log(activated);
    }
}
