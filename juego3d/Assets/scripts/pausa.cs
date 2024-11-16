using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausa : MonoBehaviour
{
    [SerializeField] private GameObject menuPausa;
    public void Pausa(){
        Time.timeScale = 0f;
        menuPausa.SetActive(true);
    }

    public void reanudar(){
        Time.timeScale = 1f;
        menuPausa.SetActive(false);
    }

    public void reiniciar(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
