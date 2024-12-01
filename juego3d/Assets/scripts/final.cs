
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
     public GameObject ganaste;
     private void OnTriggerEnter(Collider other)
    {
       
        Time.timeScale = 0f;
        ganaste.SetActive(true);

    }

    public void salir(){
        SceneManager.LoadScene("menu");
    }
}


