using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class UIMenu : ScriptableObject
{
    public void Play()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void Pause()
    {
        SceneManager.LoadScene("Menu Pause", LoadSceneMode.Additive);
    }

    public void Continue()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void RetourMainMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void Exit()
    {
        EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
