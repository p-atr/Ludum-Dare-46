using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Pushy_Tiles
{

    [SerializeField] private bool occupied;

    [SerializeField] private GameObject occupier;

    [SerializeField] private Vector2 position;

    [SerializeField] private string type;


    public Pushy_Tiles(bool Aoccupied, GameObject Aoccupier, Vector2 Aposition)
    {
        Occupied = Aoccupied;
        Occupier = Aoccupier;
        Position = Aposition;
    }


    public bool Occupied
    {
        get { return occupied; }
        set { occupied = value; }
    }

    public GameObject Occupier
    {
        get { return occupier; }
        set { occupier = value; }
    }

    public Vector2 Position
    {
        get { return position; }
        set { position = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }
}
