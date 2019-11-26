using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* In the Menu class we deal with loading into the AR scene
 * We also deal with quitting the game
 */ 
public class Menu : MonoBehaviour {

    // Load a new Scene
    public void Play() {
        SceneManager.LoadScene(1);
    }// play game
    
    // Close the application
    public void Quit() {
        Debug.Log("Exiting game");
        Application.Quit();
    }
    //  Load a new Scene
    public void Info() {
        SceneManager.LoadScene(25);
    }
}
