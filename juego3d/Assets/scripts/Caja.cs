using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caja : MonoBehaviour
{
    [SerializeField] private float cantidadPuntos;
    [SerializeField] private Puntaje puntaje;

    private void OnTriggerEnter(Collider other)
    {
        
       puntaje.SumarPuntos(cantidadPuntos);
       Destroy(gameObject);
        
    }
}
