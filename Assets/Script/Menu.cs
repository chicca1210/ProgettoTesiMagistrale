using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* In the Menu class we deal with loading into the AR scene
 * We also deal with quitting the game
 */ 
public class Menu : MonoBehaviour {

    // start a new game
    public void Play() {
        SceneManager.LoadScene(1);
    }// play game
    
    // Close the application
    public void Quit() {
        Debug.Log("Exiting game");
        Application.Quit();
    }// Quit
    
    public void Info() {
        SceneManager.LoadScene(25);
    }
}
