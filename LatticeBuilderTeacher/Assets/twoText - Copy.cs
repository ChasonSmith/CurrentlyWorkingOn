using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class twoText : MonoBehaviour
{
    public ButtonLoader2 ButtonLoader2;
    public TMP_Text canvas2;
    // Start is called before the first frame update
    
    void Awake(){
        ButtonLoader2 = GameObject.Find("ButtonLoader2").GetComponent<ButtonLoader2>();
    }
    // Update is called once per frame
    void Update()
    {
        canvas2.text = ButtonLoader2.Text2;
    }
}
