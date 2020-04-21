using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public int type;
    public int rotation;
    SpriteRenderer sr;
    public Sprite[] forms = new Sprite[4];
    public int currentSprite = 0;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        currentSprite = type;
        spriteChange();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spriteChange()
    {
        sr.sprite = forms[currentSprite];
    }

    public int direction(int previousDirection)
    {
        if (type == 0) //straigt
        {
            if(transform.rotation.eulerAngles.z == 180f || transform.rotation.eulerAngles.z == 0f)
            {
                if(previousDirection == 2)
                {
                    currentSprite += 2;
                    spriteChange();
                    return 2;
                } else if(previousDirection == 4)
                {
                    currentSprite += 2;
                    spriteChange();
                    return 4;
                }
                else
                {
                    return 0;
                }
            } else
            {
                if (previousDirection == 1)
                {
                    currentSprite += 2;

                    spriteChange();
                    return 1;
                }
                else if (previousDirection == 3)
                {
                    currentSprite += 2;
                    spriteChange();
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        } else if (type == 1)//curve
        {
            float rot = transform.rotation.eulerAngles.z;
            if (rot == 0f)
            {
                if (previousDirection == 1)
                {
                    currentSprite += 2;
                    spriteChange();
                    return 2;
                }
                else if (previousDirection == 4)
                {
                    currentSprite += 2;
                    spriteChange();
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
            else if (rot == 90f)
            {
                if (previousDirection == 3)
                {
                    currentSprite += 2;
                    spriteChange();
                    return 2;
                }
                else if (previousDirection == 4)
                {
                    currentSprite += 2;
                    spriteChange();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else if (rot == 180f)
            {
                if (previousDirection == 2)
                {
                    currentSprite += 2;
                    spriteChange();
                    return 1;
                }
                else if (previousDirection == 3)
                {
                    currentSprite += 2;
                    spriteChange();
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
            else if (rot == 270f)
            {
                if (previousDirection == 2)
                {
                    currentSprite += 2;
                    spriteChange();
                    return 3;
                }
                else if (previousDirection == 1)
                {
                    currentSprite += 2;
                    spriteChange();
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
        return -1;
    }
}
