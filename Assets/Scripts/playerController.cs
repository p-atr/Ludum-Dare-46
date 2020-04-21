using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    public float ladderForce;
    public float ladderSpeed;
    private bool canJump = true;
    GameObject franky;
    public GameObject mainmenu;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        franky = GameObject.Find("Franky");
        //mainmenu = GameObject.Find("MainMenu");
        rb.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {   
        if (canJump && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)))
        {
            canJump = false;
            rb.velocity = Vector2.up * jumpForce;
        }

        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            franky.GetComponent<frankyScript>().speed = 0.8f;
        } else if(Input.GetKeyUp(KeyCode.Space))
        {
            franky.GetComponent<frankyScript>().speed = 0.2f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            mainmenu.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground" || collision.collider.tag == "Box")
        {
            canJump = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Trap")
        {
            GameObject resetButton = GameObject.Find("Reseter");
            transform.position = resetButton.GetComponent<resetLevel>().spawnPoints[resetButton.GetComponent<resetLevel>().currentSpawnPoint].position;
            rb.velocity = Vector2.zero;
        }
        if (collision.tag == "Spawnpoint")
        {
            GameObject.Find("Reseter").GetComponent<resetLevel>().currentSpawnPoint++;
            collision.GetComponent<BoxCollider2D>().enabled = false;
            GameObject.Find("Checkpoint Audio Source").GetComponent<Checkpoint>().playAudio(3f);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Ladder" && (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)))
        {
            SpriteRenderer sr = collision.GetComponent<SpriteRenderer>();
            transform.Translate(0, sr.bounds.max.y * ladderSpeed, 0);
            rb.velocity = Vector2.up * ladderForce + Vector2.right * ladderForce;
            canJump = false;
        }
    }
}