using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    public int SceneNumber_01;
    public int SceneNumber_02;

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneNumber_02);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneNumber_01);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
