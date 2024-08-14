using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class StartMenu : MonoBehaviour
{
    public void startgame()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public void options()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void credit()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void back()
    {
        SceneManager.LoadSceneAsync(0);
    }

}
