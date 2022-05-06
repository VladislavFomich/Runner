using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
   public void PauseOn()
    {
        Time.timeScale = 0;
    }
    public void PauseOff()
    {
        Time.timeScale = 1;
    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
