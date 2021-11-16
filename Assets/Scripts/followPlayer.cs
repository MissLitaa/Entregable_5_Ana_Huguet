using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
   
    public GameObject player;
    private Vector3 cameraRotation = new Vector3(0, 270, 0);
    private Vector3 offset = new Vector3(20, 0, 10);
 

    private void LateUpdate()
    {
        //Rotaci�n y posici�n de la c�mara
        transform.rotation = Quaternion.Euler(cameraRotation);
        transform.position = player.transform.position + offset;
    }
}
