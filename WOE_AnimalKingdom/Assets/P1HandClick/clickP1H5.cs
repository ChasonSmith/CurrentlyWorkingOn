using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickP1H5 : MonoBehaviour
{
    public CardMaker card5;
    public int numClicks;

 
    

    void Start()
    {
        numClicks = 0;
       
    }
    void OnMouseDown()
    {
        numClicks++;
    }
    void Update()
    {
        if(numClicks % 2 == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
            card5.p1Hand[4].cardToPlay = true;
        }
        else{
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
             card5.p1Hand[4].cardToPlay = false;
        }
    }
}


