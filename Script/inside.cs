
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inside : MonoBehaviour
{
    // inside
    private int doorin;
    void Start()
    {
        doorin = SceneManager.GetActiveScene().buildIndex - 1;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            SceneManager.LoadScene(doorin);
        }
    }
}

