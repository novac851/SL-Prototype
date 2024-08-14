using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Game : MonoBehaviour
{
    public void startgame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void exitgame()
    {
        Application.Quit();
    }

}
