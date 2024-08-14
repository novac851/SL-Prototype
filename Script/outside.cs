using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class outside : MonoBehaviour
{
    // inside
    private int doorout;
    void Start()
    {
        doorout = SceneManager.GetActiveScene().buildIndex + 1;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            SceneManager.LoadScene(doorout);
        }
    }
}