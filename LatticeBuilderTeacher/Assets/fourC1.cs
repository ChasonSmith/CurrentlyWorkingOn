using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class fourC1 : MonoBehaviour
{
    public ButtonLoader4 ButtonLoader4;
    SpriteRenderer rend;
    // Start is called before the first frame update
    
    void Awake(){
        ButtonLoader4 = GameObject.Find("ButtonLoader4").GetComponent<ButtonLoader4>();
    }
    // Update is called once per frame
    void Update()
    {
        rend = GetComponent<SpriteRenderer> ();
        rend.material.color = ButtonLoader4.C1Color;
        
    }
}
