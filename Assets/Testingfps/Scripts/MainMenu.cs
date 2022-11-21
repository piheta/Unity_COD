using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene(1);
    }

    public void QuitGame() {
        Debug.Log("Button pressed");
        Application.Quit();
    }
}
