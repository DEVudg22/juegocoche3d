using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class fail : MonoBehaviour
{

  public GameObject menuFail;

   private void OnTriggerEnter(Collider other)
    {
        
       Time.timeScale = 0f;
        menuFail.SetActive(true);
    }

     public void reiniciar(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("DemoLevel");
    }

    public void salir(){
        SceneManager.LoadScene("menu");
    }
}
