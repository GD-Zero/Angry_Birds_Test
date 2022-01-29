using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenu : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartL1()
    {
        SceneManager.LoadScene(1);
    }

    public void RestartL2()
    {
        SceneManager.LoadScene(2);
    }

    public void RestartL3()
    {
        SceneManager.LoadScene(3);
    }
}
