using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneOnClick : MonoBehaviour
{
    public GameObject reportPanels;
    public GameObject signUpPanel;
    public GameObject signInPanel;
    public GameObject accountPanel;
    public GameObject audioPanel;
    public GameObject graphicsPanel;

    // public Color greenColor = new Color(0,200,92);
    // public Color blueColor = new Color(0,169,92);
    // public Color orangeColor = new Color(0.3f, 0.4f, 0.6f, 0.9f);



    public void LoadSceneByName()
    {
        SceneManager.LoadScene("SceneNameHere");
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
        // reportButton.GetComponent<Image>().color = orangeColor;
 
        
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
}
