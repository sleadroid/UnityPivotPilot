using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(GameObject.FindWithTag("Laser"));
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
