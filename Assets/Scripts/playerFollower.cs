using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFollower : MonoBehaviour
{
    public GameObject follow;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos.z = -10;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        pos.x = follow.transform.position.x;
        pos.y = follow.transform.position.y;

        transform.position = pos;
    }
}
