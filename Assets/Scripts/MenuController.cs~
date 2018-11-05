using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public bool isPaused;
    public GameObject pauseMenu;
    public GameObject gameOverMenu;
    public AudioSource gameSoundTrack;

	// Use this for initialization
	void Start () {
        gameSoundTrack = GameObject.Find("Sound Controller").GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(isPaused) {
                ResumeGame();
            } else {
                PauseGame();
            }
        }
	}

    public void PauseGame() {
        gameSoundTrack.Pause();
        isPaused = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame () {
        gameSoundTrack.UnPause();
        isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RestartGame() {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
    }

    public void QuitGame() {
        SceneManager.LoadScene("Main Menu");
    }

    public void LoadGameOverMenu() {
        gameSoundTrack.Pause();
        gameOverMenu.SetActive(true);
        Time.timeScale = 0f;
    }
}
