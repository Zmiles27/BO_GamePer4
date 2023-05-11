using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class spaceShipMovement : MonoBehaviour
{
    public float speed = 2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
    }
}
