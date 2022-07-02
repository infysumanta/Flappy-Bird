using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{
    BoxCollider2D box;
    float totalLength;
    void Start()
    {
        box=GetComponent<BoxCollider2D>();
        totalLength = box.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -totalLength) 
        {
            transform.position = (Vector2)transform.position + Vector2.right * totalLength * 2f;
        }
    }
}
