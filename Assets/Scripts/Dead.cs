using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    //public GameObject player;
    //public GameObject deadZone;
    void onTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.name == "Gribouilleur");
        print("Le player est dans la dead Zone");
    }

    /*void Die()
    {
        Object.DestroyImmediate(player);
    }*/
}
