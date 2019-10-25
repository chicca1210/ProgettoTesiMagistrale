using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAfter : MonoBehaviour
{
    public float time = 1f;
    void Start()
    {
        gameObject.SetActive(false);
        Invoke("HideShowGameobject", 5);
    }
 
    void HideShowGameobject()
    {
        gameObject.SetActive(true);
    }
}