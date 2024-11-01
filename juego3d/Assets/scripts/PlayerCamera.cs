using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3(0f, 5.03f, -13.39f);
   
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
