using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {
    public void Startgame()
    {
        PlayerPrefs.SetInt("Demo",0);
        PlayerPrefs.SetFloat("Score",0);
        SceneManager.LoadScene("Loading Scene");
    }
    public void Option()
    {
        PlayerPrefs.SetInt("Demo",1);
        PlayerPrefs.SetFloat("Score",0);
        SceneManager.LoadScene("Loading Scene");
    }
    public void Quitgame()
    {
        PlayerPrefs.SetFloat("Score",0);
	    Application.Quit();
    }
}
