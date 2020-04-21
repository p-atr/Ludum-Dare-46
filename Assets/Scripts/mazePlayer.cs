using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mazePlayer : MonoBehaviour
{
    public float speed;
    public GameObject wall;
    //private Rigidbody2D rb;

    public GameObject puzzleConsole;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "mazeEnd")
        {
            Debug.Log("Maze won");
            puzzleConsole.GetComponent<puzzleController>().success = 1;
        } else if(collision.tag == "wallOpener")
        {
            collision.gameObject.SetActive(false);
            wall.SetActive(false);
        }
    }
}
