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
    //South wall
    public void Play() {
        SceneManager.LoadScene(30);
    }
    public void Fix() {
        SceneManager.LoadScene(29);
    }
    public void SouthScene1() {
        SceneManager.LoadScene(31);
    }
    public void SouthScene2() {
        SceneManager.LoadScene(32);
    }
    public void SouthScene3Jpr1() {
        SceneManager.LoadScene(33);
    }
    public void SouthScene3Jpr2() {
        SceneManager.LoadScene(34);
    }
    public void SouthScene3Jpr3() {
        SceneManager.LoadScene(35);
    }
    public void SouthScene3Go() {
        SceneManager.LoadScene(36);
    }
    public void SouthScene5Fresco() {
        SceneManager.LoadScene(37);
    }
    public void SouthScene5Secco() {
        SceneManager.LoadScene(38);
    }
    public void SouthScene4Go()
    {
        SceneManager.LoadScene(39);
    }
    public void SouthScene8()
    {
        SceneManager.LoadScene(40);
    }
    public void Wall()
    {
        SceneManager.LoadScene(1);
    }
}