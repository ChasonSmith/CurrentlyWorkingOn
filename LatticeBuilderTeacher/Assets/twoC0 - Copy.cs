using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class twoC0 : MonoBehaviour
{
    public ButtonLoader2 ButtonLoader2;
    SpriteRenderer rend;
    // Start is called before the first frame update
    
    void Awake(){
        ButtonLoader2 = GameObject.Find("ButtonLoader2").GetComponent<ButtonLoader2>();
    }
    // Update is called once per frame
    void Update()
    {
        rend = GetComponent<SpriteRenderer> ();
        rend.material.color = ButtonLoader2.C0Color;
        
    }
}

