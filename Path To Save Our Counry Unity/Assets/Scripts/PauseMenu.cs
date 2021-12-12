using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
    private bool GameIsPaused;
    public GameObject Paused;
    public GameObject ResumeBtn;
    public Rigidbody Player;
    public Text Headertext;
    private bool Isdead;
    void Start()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        Paused.SetActive(false);

    }
    void Update()
    {
        if (Isdead)
        {
            ResumeBtn.SetActive(false);
            Time.timeScale = 0f;
            Player.velocity = new Vector3(0, 0, 0);
            Player.rotation = new Quaternion(0, 0, 0, 1);
            Paused.SetActive(true);
            Headertext.text = "GAMEOVER";
        }
        if (!Isdead)
        {
            ResumeBtn.SetActive(true);
            Headertext.text = "PAUSEMENU";
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Debug.Log("ESC");
                if (GameIsPaused)
                {
                    Resume();
                    GameIsPaused = false;
                }
                else if (GameIsPaused == false)
                {
                    Paused.SetActive(true);
                    GameIsPaused = true;
                    Time.timeScale = 0f;
                    Player.velocity = new Vector3(0, 0, 0);
                    Player.rotation = new Quaternion(0, 0, 0, 1);
                }
            }
        }
    }
    public void Resume()
    {
        GameIsPaused = false;
        Time.timeScale = 1f;
        Paused.SetActive(false);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
    public void Menu()
    {
        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1f;
    }
    public void Dead()
    {
        Isdead = true;
    }
    public bool Pausedbool()
    {
        return GameIsPaused;
    }

    


}
