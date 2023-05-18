using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameMenu : MonoBehaviour
{

    [SerializeField] public GameObject PauseMenuPanel;
    // [SerializeField] public GameObject SettingMenuPanel;

    public void Pause()
    {
        PauseMenuPanel.SetActive(true);
        Time.timeScale = 0f;
    }
    //  public void Setting()
    // {
    //     SettingMenuPanel.SetActive(true);
    //     Time.timeScale = 0f;
    // }


    public void Exit(){
     
        SceneManager.LoadScene("MainMenu");
    }
    

    public void Resume()
    {
        PauseMenuPanel.SetActive(false);
        // SettingMenuPanel.SetActive(false);
        Time.timeScale = 1f;
    }
    // public void Restart()
    // {
    //     Time.timeScale = 1f;
    //     SceneManager.LoadScene("SampleScene");
    // }
   
}

