using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Scene: MonoBehaviour
{
    public void next()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
        int SceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneIndex + 1);
        }
    }
    public void nextscene()
    {
        SceneManager.LoadScene(0);
    }

    public void NexttoWorkshop()
    {
        SceneManager.LoadSceneAsync(4);
    }
}
