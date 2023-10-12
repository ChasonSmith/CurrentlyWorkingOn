using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class fourText : MonoBehaviour
{
    public ButtonLoader4 ButtonLoader4;
    public TMP_Text canvas4;
    // Start is called before the first frame update
    
    void Awake(){
        ButtonLoader4 = GameObject.Find("ButtonLoader4").GetComponent<ButtonLoader4>();
    }
    // Update is called once per frame
    void Update()
    {
        canvas4.text = ButtonLoader4.Text4;
    }
}
