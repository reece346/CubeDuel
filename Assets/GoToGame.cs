using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGame : MonoBehaviour
{
    public void PlayGame() {
        PauseMenu.GamePaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game Scene");
        
    }
}
