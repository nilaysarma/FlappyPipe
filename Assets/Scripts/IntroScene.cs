using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    public float introTime = 3f;

    private void Start()
    {
        Time.timeScale = 1f;
        Invoke("LoadMainMenu", introTime);
    }

    private void LoadMainMenu()
    {
        SceneManager.LoadScene(1);
    }
}
