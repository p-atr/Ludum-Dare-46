using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resetLevel : MonoBehaviour
{

    public Transform[] spawnPoints;
    public Transform[] boxSpawnPoints;
    public int currentSpawnPoint;
    public Text startbuttontext;
    GameObject player;
    GameObject franky;
    GameObject[] boxes;
    GameObject mainmenu;
    [SerializeField]GameObject[] puzzles;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        franky = GameObject.Find("Franky");
        boxes = GameObject.FindGameObjectsWithTag("Box");
        mainmenu = GameObject.Find("MainMenu");
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    public void died()
    {
        Debug.Log("Franky dead");
        GameObject.Find("Died").GetComponent<Reset>().show(2f);
        this.reset();
    }

    public void firststart()
    {
        startbuttontext.text = "restart game";
    }
    public void reset()
    {
        player.transform.position = spawnPoints[currentSpawnPoint].position;
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        player.GetComponent<playerController>().enabled = true;
        franky.transform.position = spawnPoints[currentSpawnPoint].position;
        for (int i = 0; i < boxes.Length; i++)
        {
            boxes[i].transform.position = boxSpawnPoints[i].position;
        }

        for (int i = 0; i < puzzles.Length; i++)
        {
            puzzles[i].SetActive(false);
            Debug.Log("deactivated");
        }
        mainmenu.SetActive(false);
    }

    public void resetFull()
    {
        currentSpawnPoint = 0;
        reset();
    }
}
