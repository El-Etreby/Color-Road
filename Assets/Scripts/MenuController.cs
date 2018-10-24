using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public string mainMenuScene;
    public GameObject pauseMenu;
    public GameObject gameOverMenu;
    public bool isPaused;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(isPaused) {
                ResumeGame();
            } else {
                isPaused = true;
                pauseMenu.SetActive(true);
                Time.timeScale = 0f;
            }
        }
	}

    public void ResumeGame () {
        isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RestartGame() {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
    }

    public void QuitGame() {

    }

    public void LoadGameOverMenu() {
        gameOverMenu.SetActive(true);
        Time.timeScale = 0f;
    }
}
