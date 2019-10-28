using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAfter : MonoBehaviour
{
    public float time;
    void Start()
    {
        gameObject.SetActive(false);
        Invoke("HideShowGameobject", time);
    }
 
    void HideShowGameobject()
    {
        gameObject.SetActive(true);
    }
}