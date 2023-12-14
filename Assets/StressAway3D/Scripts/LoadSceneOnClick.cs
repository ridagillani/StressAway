using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class LoadSceneOnClick : MonoBehaviour
{
    public GameObject reportPanels;
    public GameObject signUpPanel;
    public GameObject signInPanel;
    public GameObject accountPanel;
    public GameObject pausePanel;
    public GameObject errorPanel;
    public GameObject storyPanel;

    int _messageCounter = 0;
    [SerializeField] TextMeshProUGUI dialogue;

    public Button manageAccount;
    public Button newGame;
    public Button pauseButton;


    public GameObject audioPanel;
    public GameObject graphicsPanel;

    public GameObject mainMenu;
    public GameObject gameMenu;
    public GameObject optionsMenu;

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadNextInBuild()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

     public void reportsPan()
    {
         signUpPanel.SetActive(false);
         signInPanel.SetActive(false);
        reportPanels.SetActive(true);
    }

     public void newGamePan()
    {
        reportPanels.SetActive(false);
        signInPanel.SetActive(false);
        signUpPanel.SetActive(true);
 
       
    }
     public void signInPan()
    {
        signUpPanel.SetActive(false);
        reportPanels.SetActive(false);
        signInPanel.SetActive(true);
    }

     public void managePan()
    {
        audioPanel.SetActive(false);
        graphicsPanel.SetActive(false);
        accountPanel.SetActive(true);
    }

    public void audioPan()
    {
        graphicsPanel.SetActive(false);
        accountPanel.SetActive(false);
        audioPanel.SetActive(true);
    }
    public void graphicsPan()
    {
        audioPanel.SetActive(false);
        accountPanel.SetActive(false);
        graphicsPanel.SetActive(true);
    }

    public void mainMenuf()
    {
        gameMenu.SetActive(false);
        optionsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void gameMenuf()
    {
        newGame.Select();
        optionsMenu.SetActive(false);
        mainMenu.SetActive(false);
        gameMenu.SetActive(true);
    }
     public void optionsMenuf()
    {
        manageAccount.Select();
        mainMenu.SetActive(false);
        gameMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }
    public void pauseClicked()
    {
        pauseButton.Select();
    }
    public void resumeClicked()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
     public void tryClicked()
    {
        errorPanel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            pausePanel.SetActive(true);
            Debug.Log(Time.timeScale);
            Time.timeScale = 0;
            Debug.Log(Time.timeScale);
            Cursor.visible = true;
        }
        // if (Input.GetKeyDown(KeyCode.Return)){
        //    if (_messageCounter == 0) {
        //        dialogue.text = "You've just woken up to a blaring alarm in a slightly messy room. Oh no! You're running late, and there's a big exam in just 40 minutes! Yikes!" ;
        //     storyPanel.SetActive(false);
        //    } 
        // //    else if (_messageCounter == 1) {
        // //        dialogue.text = "The room feels tense, and you know you're not ready. Your task is simple but speedy: grab your important stuff - ID card, admit card, notes, and pens - in just 15 seconds. ";
        // //        _messageCounter++;
        // //    }
        // }
    }
}
