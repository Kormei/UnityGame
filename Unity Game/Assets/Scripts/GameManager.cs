using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // Start is called before the first frame update
    private void Awake()
    {
        if (instance)
        {
            Destroy(this);
        }
        else{
            instance = this;
            DontDestroyOnLoad(this);
        }
    }

    public static void LoadScene(string newSceneName)
    {
        SceneManager.LoadScene(newSceneName);
    }

    public static void Quit()
    {
        Application.Quit();
    }
}
