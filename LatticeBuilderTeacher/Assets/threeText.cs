using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class threeText : MonoBehaviour
{
    public ButtonLoader3 ButtonLoader3;
    public TMP_Text canvas3;
    // Start is called before the first frame update
    
    void Awake(){
        ButtonLoader3 = GameObject.Find("ButtonLoader3").GetComponent<ButtonLoader3>();
    }
    // Update is called once per frame
    void Update()
    {
        canvas3.text = ButtonLoader3.Text3;
    }
}
