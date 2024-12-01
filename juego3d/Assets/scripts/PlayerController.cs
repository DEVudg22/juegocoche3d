using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad;

    public float turnSpeed = 0.0f;
    public float horizontalInput = 0.0f;
    
    void Start()
    {
        Time.timeScale = 1f;
    }

    void Update()
    {   
        
        horizontalInput = Input.GetAxis("Horizontal");
        //mover hacia adelante
         transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
         
         //modificar el giro
         //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
          transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}

