using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public Canvas menu;
    public Canvas settings;
    public void OnStartButton()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void OnQuitButton()
    {
        Application.Quit();
    }
    public void OnSettings()
    {
        settings.gameObject.SetActive(true);
        menu.gameObject.SetActive(false);
    }
    public void OnBack()
    {
        settings.gameObject.SetActive(false);
        menu.gameObject.SetActive(true);
    }
    public void OnPlayAgain()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
