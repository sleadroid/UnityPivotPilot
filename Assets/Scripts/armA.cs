using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armA : MonoBehaviour
{
    private float speed = 40.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(Vector3.back * speed * Time.deltaTime);
        }
    }
}
