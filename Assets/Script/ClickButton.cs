using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
 
public class ClickButton : MonoBehaviour {
 
    public GameObject definedButton;
    public UnityEvent OnClick = new UnityEvent();
 
    // Use this for initialization
    void Start () {
        definedButton = this.gameObject;
    }
     
    // Update is called once per frame
    void Update () {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit Hit;
         
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
            {
                Debug.Log("Button Clicked");
                OnClick.Invoke();
            }
        }    
    }
    //North wall
    public void Play() {
        SceneManager.LoadScene(3);
    }
    public void NorthScene1() {
        SceneManager.LoadScene(4);
    }
    public void NorthScene2() {
        SceneManager.LoadScene(5);
    }
    public void NorthScene3() {
        SceneManager.LoadScene(6);
    }
    public void NorthScene4() {
        SceneManager.LoadScene(5);
    }


}