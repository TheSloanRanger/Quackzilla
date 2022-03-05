using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void MenuScreen()
    {
        SceneManager.LoadScene("MenuScreen");
    }

    public void GameScreen()
    {
        SceneManager.LoadScene("GameScreen");
    }

    public void GameOverScreen()
    {
        SceneManager.LoadScene("GameOverScreen");
    }
}