using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections.Generic;

public class SceneManagement : MonoBehaviour
{
    private void Awake()
    {
        Stack<string> scenes1 = new Stack<string>();
        //scenes.Push();
        string lastScene1 = scenes1.Pop();
    }

    public void GameScene()
    {
        SceneManager.LoadScene("GameplayScene");
    }
   
    public void OptionsScene()
    {
        SceneManager.LoadScene("OptionsScene");
    }

    public void CreditsScene()
    {
        SceneManager.LoadScene("CreditsScene");
    }
   
    public void ReturnToMenuScene()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
