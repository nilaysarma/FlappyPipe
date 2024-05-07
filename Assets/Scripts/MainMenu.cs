using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject gameplayTransition;
    public float transitionTime = 3.8f;

    private void Start()
    {
        Time.timeScale = 1f;    
    }

    public void PlayGame()
    {
        gameplayTransition.SetActive(true);
        Invoke("LoadGameplay", transitionTime);
    }

    private void LoadGameplay()
    {
        SceneManager.LoadScene(2);
    }
}
