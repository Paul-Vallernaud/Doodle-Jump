using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public GameObject player;

    private Vector3 newPos;
    private Vector3 offset;
    private float horizontale;
    void Start()
    {
        //R�cup�ration de la position locale de d�part
        //offset = transform.position - player.transform.position;
        //R�cup�ration de la position x de d�part du personnage (puisque l'offset sera ajout�e par la suite)
        //horizontale = player.transform.position.y;
    }

    // Update is called once per frame
    void LateUpdate ()
    {
        //R�cup�ration de la position du personnage avec la position y initiale 
        //newPos = new Vector3(player.transform.position.x, horizontale, player.transform.position.z);
        //Affectation
        //transform.position = newPos + offset;
    }
}
