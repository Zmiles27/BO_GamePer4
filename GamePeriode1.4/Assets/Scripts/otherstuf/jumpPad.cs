using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpPad : MonoBehaviour
{
    public float jumpHight = 5f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "bouncePad")
        {
            this.transform.Translate(jumpHight * Time.deltaTime, 0, 0);
        }
    }
}
