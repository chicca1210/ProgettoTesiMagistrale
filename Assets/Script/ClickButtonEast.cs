using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
 
public class ClickButtonEast : MonoBehaviour {
 
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
    public void EastScene1() {
        SceneManager.LoadScene(15);
    }
    public void EastScene2() {
        SceneManager.LoadScene(16);
    }
    public void EastScene3Jpr1() {
        SceneManager.LoadScene(17);
    }
    public void EastScene3Jpr2() {
        SceneManager.LoadScene(18);
    }
    public void EastScene3Jpr3() {
        SceneManager.LoadScene(19);
    }
    public void EastScene3Go() {
        SceneManager.LoadScene(20);
    }
    public void NorthScene5Fresco() {
        SceneManager.LoadScene(21);
    }
    public void NorthScene5Secco() {
        SceneManager.LoadScene(22);
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