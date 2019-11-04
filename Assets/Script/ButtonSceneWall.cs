using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSceneWall : MonoBehaviour
{
    public void PlayVideo() {
        SceneManager.LoadScene(2);
    }
    public void Home() {
        SceneManager.LoadScene(1);
    }
    public void Menu() {
        SceneManager.LoadScene(0);
    }

    public void exit()
    {
        Debug.Log("Exiting game");
        Application.Quit();
    }
    

}
