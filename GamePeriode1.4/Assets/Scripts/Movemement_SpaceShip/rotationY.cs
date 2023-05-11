using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationY : MonoBehaviour
{
    public float rotSpeed = 50;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(-rotSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(rotSpeed * Time.deltaTime, 0, 0);
        }
    }
}
