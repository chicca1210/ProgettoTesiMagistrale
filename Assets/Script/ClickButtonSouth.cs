using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
 
public class ClickButtonSouth : MonoBehaviour {
 
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
        SceneManager.LoadScene(14);
    }
    public void Fix() {
        SceneManager.LoadScene(29);
    }
    public void NorthScene1() {
        SceneManager.LoadScene(4);
    }
    public void NorthScene2() {
        SceneManager.LoadScene(5);
    }
    public void NorthScene3Jpr1() {
        SceneManager.LoadScene(6);
    }
    public void NorthScene3Jpr2() {
        SceneManager.LoadScene(8);
    }
    public void NorthScene3Jpr3() {
        SceneManager.LoadScene(9);
    }
    public void NorthScene3Go() {
        SceneManager.LoadScene(7);
    }
    public void NorthScene5Fresco() {
        SceneManager.LoadScene(10);
    }
    public void NorthScene5Secco() {
        SceneManager.LoadScene(11);
    }
    public void NorthScene4Go()
    {
        SceneManager.LoadScene(12);
    }
    public void NorthScene8()
    {
        SceneManager.LoadScene(13);
    }
    public void Wall()
    {
        SceneManager.LoadScene(1);
    }
}