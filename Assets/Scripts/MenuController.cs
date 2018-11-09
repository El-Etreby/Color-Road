using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public bool isPaused;
    public GameObject pauseMenu;
    public GameObject gameOverMenu;
    public AudioSource gameSoundTrack;
    public AudioSource menuSoundTrack;

    // Use this for initialization
    void Start () {
        gameSoundTrack = GameObject.Find("Sound Controller").GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            Pause();
        }
	}

    public void Pause() {
        if (isPaused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }

    public void PauseGame() {
        gameSoundTrack.Pause();
        menuSoundTrack.Play();
        isPaused = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame () {
        menuSoundTrack.Pause();
        gameSoundTrack.Play();
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
        menuSoundTrack.Play();
        gameOverMenu.SetActive(true);
        Time.timeScale = 0f;
    }
}
