using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frankyScript : MonoBehaviour
{
    public float speed;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Trap")
        {
            GameObject.Find("Reseter").GetComponent<resetLevel>().died();
        }
    }
}
    