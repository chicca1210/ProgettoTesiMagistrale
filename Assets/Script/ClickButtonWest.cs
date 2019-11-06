using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
 
public class ClickButtonWest : MonoBehaviour {
 
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
    //West wall
    public void Play() {
        SceneManager.LoadScene(41);
    }
    public void Fix() {
        SceneManager.LoadScene(28);
    }
    public void WestScene1() {
        SceneManager.LoadScene(42);
    }
    public void WestScene2() {
        SceneManager.LoadScene(43);
    }
    public void WestScene3Jpr1() {
        SceneManager.LoadScene(44);
    }
    public void WestScene3Jpr2() {
        SceneManager.LoadScene(45);
    }
    public void WestScene3Jpr3() {
        SceneManager.LoadScene(46);
    }
    public void WestScene3Go() {
        SceneManager.LoadScene(47);
    }
    public void WestScene5Fresco() {
        SceneManager.LoadScene(48);
    }
    public void WestScene5Secco() {
        SceneManager.LoadScene(49);
    }
    public void WestScene4Go()
    {
        SceneManager.LoadScene(50);
    }
    public void WestScene8()
    {
        SceneManager.LoadScene(51);
    }
    public void Wall()
    {
        SceneManager.LoadScene(1);
    }
}