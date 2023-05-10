using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInMain : MonoBehaviour
{
    public GameObject firstPlay, gameMenu, PauseMenu, FailMenu, WinMenu;
    public GameObject StartMenu, goBackToMenuButton, musicButton;
    public GameObject SettingMenu, LevelsMenu, AboutGameMenu, MarketMenu, DeveloperInfoMenu;
    public GameObject MainMenuContentsMenu;

    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        

    }

    void Update()
    {
        
    }

    private void Awake()
    {
        Singleton();

    }

    #region Singleton

    public static MenuInMain Instance;

    public void Singleton()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }

        Instance = this;
    }
    #endregion
    public void FirstPlayButton()
    {
        //firstPlay.SetActive(false);
        StartMenu.SetActive(false);
        SceneManager.LoadScene(1);
        //LevelManager.Instance.Setlevel(1);
    }

    public void settingsButton()
    {
        StartMenu.SetActive(false);
        SettingMenu.SetActive(true);
        goBackToMenuButton.SetActive(true);
        //musicButton.SetActive(true);
    }

    public void levelsButton()
    {
        StartMenu.SetActive(false);
        LevelsMenu.SetActive(true);
        goBackToMenuButton.SetActive(true);
    }

    public void gameRulesButton()
    {
        StartMenu.SetActive(false);
        AboutGameMenu.SetActive(true);
        goBackToMenuButton.SetActive(true);

    }

    public void marketButton()
    {
        StartMenu.SetActive(false);
        MarketMenu.SetActive(true);
        goBackToMenuButton.SetActive(true);
    }

    public void developerInfoButton()
    {
        StartMenu.SetActive(false);
        DeveloperInfoMenu.SetActive(true);
        goBackToMenuButton.SetActive(true);
    }

    public void exitButton()
    {
        Time.timeScale = 1;
        Application.Quit();
    }
    public void closeMusicButton()
    {
        audioSource.Stop();
    }

    public void playMusicButton()
    {
        audioSource.Play();
    }


    public void backToMenuButton()
    {
        MainMenuContentsMenu.SetActive(true);
        goBackToMenuButton.SetActive(false);
        AboutGameMenu.SetActive(false);
        LevelsMenu.SetActive(false);
        MarketMenu.SetActive(false);
        DeveloperInfoMenu.SetActive(false);
        SettingMenu.SetActive(false);
        StartMenu.SetActive(true);
        
    }



    public void PauseButton()
    {
        Time.timeScale = 0;
        gameMenu.SetActive(false);
        PauseMenu.SetActive(true);
        FailMenu.SetActive(false);
    }

    public void PlayButton()
    {
        Time.timeScale = 1;
        gameMenu.SetActive(true);
        PauseMenu.SetActive(false);
        FailMenu.SetActive(false);
    }


    public void RestartButton()
    {
        Time.timeScale = 1;
        //SceneManager.LoadScene(1);

        float chapter = LevelManager.Instance.Getlevel();
        LevelManager.Instance.RePoint();
        Debug.Log("$chapter");
        if (chapter % 5 == 0)
            SceneManager.LoadScene(5);
        if (chapter % 5 == 4)
            SceneManager.LoadScene(4);
        if (chapter % 5 == 3)
            SceneManager.LoadScene(3);
        if (chapter % 5 == 2)
            SceneManager.LoadScene(2);
        if (chapter % 5 == 1)
            SceneManager.LoadScene(1);

    }

    public void MenuButton()
    {
        Time.timeScale = 1;
        Application.Quit();
    }

    public void ActiveFail()
    {
        FailMenu.SetActive(true);
        gameMenu.SetActive(true);
        
    }

    public void FailButton()
    {
        Time.timeScale = 1;
        gameMenu.SetActive(true);
        LevelManager.Instance.RePoint();

        float chapter = LevelManager.Instance.Getlevel();

        Debug.Log("$chapter");
        if (chapter % 5 == 0)
            SceneManager.LoadScene(5);
        if (chapter %5 == 4)
            SceneManager.LoadScene(4);
        if (chapter %5 == 3)
            SceneManager.LoadScene(3);
        if (chapter %5 == 2)
            SceneManager.LoadScene(2);
        if (chapter %5 == 1)
            SceneManager.LoadScene(1);
    }

    public void ActiveWin()
    {
        WinMenu.SetActive(true);
        gameMenu.SetActive(true);
    }

    public void WinButton()
    {
        Time.timeScale = 1;
        gameMenu.SetActive(true);
        WinMenu.SetActive(false);

        float chapter = LevelManager.Instance.Getlevel();
        LevelManager.Instance.Setlevel(1);
        Debug.Log("$chapter");
        if (chapter % 5 == 4)
            SceneManager.LoadScene(5);
        if (chapter %5 == 3)
            SceneManager.LoadScene(4);
        if (chapter %5  == 2)
            SceneManager.LoadScene(3);
        if (chapter % 5 == 1)
            SceneManager.LoadScene(2);
        if (chapter %5 == 0)
            SceneManager.LoadScene(1);
    }
}
