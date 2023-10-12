using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class threeC0 : MonoBehaviour
{
    public ButtonLoader3 ButtonLoader3;
    SpriteRenderer rend;
    // Start is called before the first frame update
    
    void Awake(){
        ButtonLoader3 = GameObject.Find("ButtonLoader3").GetComponent<ButtonLoader3>();
    }
    // Update is called once per frame
    void Update()
    {
        rend = GetComponent<SpriteRenderer> ();
        rend.material.color = ButtonLoader3.C0Color;
        
    }
}
