using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject pauseMenu;

    void Start()
    {
        ResumeGame();
    }

    void ResumeGame()
    {
        pauseMenu.SetActive(true);
    }
}
