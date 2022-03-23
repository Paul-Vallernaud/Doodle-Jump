using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRail : MonoBehaviour
{
    public float speed = 2f;


    void Start()
    {
        // Moves the object forward at two units per second.
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Move the object forward along its z axis 1 unit/second.
        transform.Translate(0, 0, Time.deltaTime);

        // Move the object upward in world space 1 unit/second.
        transform.Translate(0, Time.deltaTime, 0, Space.World);
    }
}


