using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class p1PointsText : MonoBehaviour
{
    public CardMaker CardMaker;
    public TMP_Text canvas;
    // Start is called before the first frame update
    
    void start(){
        CardMaker = GameObject.Find("CardMaker").GetComponent<CardMaker>();
    }
    // Update is called once per frame
    void Update()
    {
        canvas.text = CardMaker.pointsText;
    }
}
