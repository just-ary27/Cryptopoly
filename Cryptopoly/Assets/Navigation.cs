using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene(3);
    }

    public void BackToMain()
    {
        SceneManager.LoadScene(0);
    }

    public void game()
    {
        SceneManager.LoadScene(5);
    }

    public void pauseMenu()
    {
        SceneManager.LoadScene(4);
    }

    public void quit()
    {
        SceneManager.LoadScene(0);
    }
}
