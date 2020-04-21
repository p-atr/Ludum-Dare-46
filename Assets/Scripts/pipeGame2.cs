using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeGame2 : MonoBehaviour
{
    GameObject[,] tiles = new GameObject[5, 5];
    int[,] tileTypes = new int[,] { { 1, 1, 0, 0, 1 }, { 0, 1, 0, 1, 0 }, { 1, 1, 0, 0, 1 }, { 0, 0, 0, 1, 1 }, { 0, 1, 0, 0, 1 } };
    public GameObject tile;
    public float tileSize;

    public GameObject puzzleConsole;
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                tiles[i, j] = Instantiate(tile, transform.position + Vector3.right * i * tileSize + Vector3.down * j * tileSize, Quaternion.identity);
                tiles[i, j].transform.parent = gameObject.transform;
                tiles[i, j].GetComponent<move>().type = tileTypes[i, j];
            }
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 10, 1 << 10);
            try
            {
                hit.transform.Rotate(0f, 0f, 90f);
                if (checkIfSolved())
                {
                    Debug.Log("Pipe Won");
                    puzzleConsole.GetComponent<puzzleController>().success = 1;
                }
            }
            catch
            {

            }

        }
    }

    bool checkIfSolved()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (tiles[i, j].GetComponent<move>().currentSprite >= 2)
                {
                    tiles[i, j].GetComponent<move>().currentSprite -= 2;
                }
                tiles[i, j].GetComponent<move>().spriteChange();
            }
        }

        int lastDirection = 4;
        int tilePosX = 0, tilePosY = 4;
        int pipePassedThrough = 0;
        while (lastDirection > 0 && pipePassedThrough <= 25)
        {
            //Debug.Log(tilePosX + "x" + tilePosY + "y");

            if (tilePosX == 5 && tilePosY == 0) { return true; }

            lastDirection = tiles[tilePosX, tilePosY].GetComponent<move>().direction(lastDirection);
            switch (lastDirection)
            {

                case 1:
                    if (tilePosY < 5)
                    {
                        tilePosY++;
                    }
                    break;
                case 2:
                    if (tilePosX > 0)
                    {
                        tilePosX--;
                    }
                    break;
                case 3:
                    if (tilePosY > 0)
                    {
                        tilePosY--;
                    }
                    break;
                case 4:
                    if (tilePosX < 5)
                    {
                        tilePosX++;
                    }
                    break;
                default:
                    Debug.Log(lastDirection);
                    break;
            }

            pipePassedThrough++;
        }

        return false;
    }
}
