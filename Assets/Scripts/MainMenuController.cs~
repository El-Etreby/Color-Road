using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject howToPlayScreen;
    public GameObject creditsScreen;
    public Text soundText;
    public bool sound;

    // Use this for initialization
    void Start () {
        optionsMenu.SetActive(false);
        howToPlayScreen.SetActive(false);
        creditsScreen.SetActive(false);
        mainMenu.SetActive(true);
        if (AudioListener.volume == 1)
        {
            sound = true;
            soundText.text = "SOUND - ON";
        }
        else{
            sound = false;
            soundText.text = "SOUND - OFF";
        }
    }
	
	// Update is called once per frame
	void Update () {
	}

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void ChangeSound() {
        if(sound) {
            AudioListener.volume = 0f;
            sound = false;
            soundText.text = "SOUND - OFF";
        } else {
            AudioListener.volume = 1f;
            sound = true;
            soundText.text = "SOUND - ON";
        }
    }

    public void OpenOptionsMenu() {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void BackToMainMenu() {
        optionsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void OpenHowToPlayScreen() {
        optionsMenu.SetActive(false);
        howToPlayScreen.SetActive(true);
    }

    public void OpenCreditsScreen()
    {
        optionsMenu.SetActive(false);
        creditsScreen.SetActive(true);
    }

    public void BackToOptionsMenu()
    {
        howToPlayScreen.SetActive(false);
        creditsScreen.SetActive(false);
        optionsMenu.SetActive(true);
    }
}
