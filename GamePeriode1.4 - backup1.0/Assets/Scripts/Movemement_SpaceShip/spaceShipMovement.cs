using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class spaceShipMovement : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        transform.position =new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(0, 0, -speed * Time.deltaTime);
        }
    }
}
