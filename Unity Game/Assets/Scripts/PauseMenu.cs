   using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject particles;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            } else {
                Pause();
            }
        }
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        particles.SetActive(true);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        particles.SetActive(false);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
}
