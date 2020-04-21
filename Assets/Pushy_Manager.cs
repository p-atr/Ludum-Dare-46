using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pushy_Manager : MonoBehaviour
{
    public Pushy_Tiles[] pushies = new Pushy_Tiles[81];
    private int Tile = 1;
    private int Row = 0;
    [SerializeField] private GameObject[] placables;
    [SerializeField] private Transform Wall;


    void Start()
    {
        setTiles();
        setWalls();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void setTiles()
    {
        for (int i = 0; i < pushies.Length; i++)
        {
            if (Tile <= 9)
            {
                pushies[i].Position = new Vector2((0.11111111f) * 8, Row * (0.11111111f));
            }
            else if (Tile <= 18)
            {
                pushies[i].Position = new Vector2((0.11111111f) * 7, Row * (0.11111111f));
            }
            else if (Tile <= 27)
            {
                pushies[i].Position = new Vector2((0.11111111f) * 6, Row * (0.11111111f));
            }
            else if (Tile <= 36)
            {
                pushies[i].Position = new Vector2((0.11111111f) * 5, Row * (0.11111111f));
            }
            else if (Tile <= 45)
            {
                pushies[i].Position = new Vector2((0.11111111f) * 4, Row * (0.11111111f));
            }
            else if (Tile <= 54)
            {
                pushies[i].Position = new Vector2((0.11111111f) * 3, Row * (0.11111111f));
            }
            else if (Tile <= 63)
            {
                pushies[i].Position = new Vector2((0.11111111f) * 2, Row * (0.11111111f));
            }
            else if (Tile <= 72)
            {
                pushies[i].Position = new Vector2((0.11111111f) * 1, Row * (0.11111111f));
            }
            else if (Tile <= 81)
            {
                pushies[i].Position = new Vector2((0.11111111f) * 0, Row * (0.11111111f));
            }

            if (Tile % 9 == 0)
            {
                Row = 0;
            }
            else
            {
                Row += 1;
            }
            Tile += 1;
            Debug.Log(pushies[i].Position.x);
        }
    }

    private void setWalls()
    {
        for (int i = 0; i < pushies.Length; i++)
        {
            if(i <= 8)
            {
                pushies[i].Occupied = true;
                pushies[i].Occupier = Instantiate(placables[0], Wall, false);
                pushies[i].Occupier.transform.position = pushies[i].Position*4;
            }
            else if(i%9 == 8)
            {
                pushies[i].Occupied = true;
                pushies[i].Occupier = Instantiate(placables[0], Wall, false);
                pushies[i].Occupier.transform.position = pushies[i].Position*4;
            }
            else if(i%9 == 0)
            {
                pushies[i].Occupied = true;
                pushies[i].Occupier = Instantiate(placables[0], Wall, false);
                pushies[i].Occupier.transform.position = pushies[i].Position*4;
            }
            else if(i >= 72)
            {
                pushies[i].Occupied = true;
                pushies[i].Occupier = Instantiate(placables[0], Wall, false);
                pushies[i].Occupier.transform.position = pushies[i].Position*4;
            }
        }
    }
}
