using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    public float turnSpeed = 20.0f;
    public float verticalInput;
    private float zMax = 450.0f;

    void Start()
    {
        //Posición 0,0,0.
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        //Ir hacia delante todo el tiempo.
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //Controlador.
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.left, turnSpeed * Time.deltaTime * verticalInput);

        //Límite Player.
        if (transform.position.z >= zMax)
        {
            Debug.Log("THE END");
            Time.timeScale = 0;
        }
    }
}
