using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void Level01()
    {
        SceneManager.LoadScene("level01");
    }
     public void exitFromGame()
    {
       Application.Quit();
       Debug.Log("Exit is working just fine !");
    }

}
