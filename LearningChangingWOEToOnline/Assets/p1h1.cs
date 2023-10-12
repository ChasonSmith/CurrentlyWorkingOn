using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class p1h1 : Photon.MonoBehaviour
{
    public Sprite card1;
    public Sprite card2;
    public Sprite alligator;
    public Sprite cardBack;
    // Start is called before the first frame update
    
    void Awake()
    {
        //thisPhotonView = GetComponent();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.GetComponent<PhotonView>().viewID == 1001)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = alligator;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = cardBack;
        }
    }
}
