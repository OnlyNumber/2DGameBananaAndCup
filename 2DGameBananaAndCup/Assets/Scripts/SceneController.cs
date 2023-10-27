using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneController : MonoBehaviour
{
    public Action OnSceneLoad;

    private void LoadScene(string sceneName)
    {
        OnSceneLoad?.Invoke();

        SceneManager.LoadScene(sceneName);
    }


    public void GoToGame()
    {
        LoadScene(StaticFields.GAME_SCENE);
    }

    public void GoToMenu()
    {
        LoadScene(StaticFields.MAIN_MENU_SCENE);
    }

}
