using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class ButtonLoader3 : MonoBehaviour
{
    public List<int> latticeEntries = new List<int>() {123, 12, 13, 23, 1, 2, 3, 0};
    public Color C123Color = Color.white;
    public Color C12Color = Color.white;
    public Color C13Color = Color.white;
    public Color C23Color = Color.white;
    public Color C1Color = Color.white;
    public Color C2Color = Color.white;
    public Color C3Color = Color.white;
    public Color C0Color = Color.white;
    public string Text3;
    int randIndex;
    
    public void Menu(){
        C123Color = Color.white;
        C12Color = Color.white;
        C13Color = Color.white;
        C23Color = Color.white;
        C1Color = Color.white;
        C2Color = Color.white;
        C3Color = Color.white;
        C0Color = Color.white;
        Text3 = "";
        SceneManager.LoadScene(0);
    }

    public void Restart(){
        C123Color = Color.white;
        C12Color = Color.white;
        C13Color = Color.white;
        C23Color = Color.white;
        C1Color = Color.white;
        C2Color = Color.white;
        C3Color = Color.white;
        C0Color = Color.white;
        Text3 = "";
    }

    public void Proper(){
        int start;
        randIndex = Random.Range(0, 7);
        start = latticeEntries[randIndex];
        if(start == 1){
            C123Color = Color.green;
            C12Color = Color.green;
            C13Color = Color.green;
            C23Color = Color.red;
            C1Color = Color.green;
            C2Color = Color.red;
            C3Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 2){
            C123Color = Color.green;
            C12Color = Color.green;
            C13Color = Color.red;
            C23Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.green;
            C3Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 3){
            C123Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.green;
            C23Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.green;
            C0Color = Color.red;
        }
        else if(start == 123){
            C123Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C23Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 12){
            C123Color = Color.green;
            C12Color = Color.green;
            C13Color = Color.red;
            C23Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 13){
            C123Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.green;
            C23Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 23){
            C123Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C23Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C0Color = Color.red;
        }
        Text3 = "In a proper fillter the stipulation is that the filter is not equal to the lattice.";
    }

    public void Fixed(){
        int start;
        randIndex = Random.Range(0, 8);
        start = latticeEntries[randIndex];
        if(start == 1){
            C123Color = Color.green;
            C12Color = Color.green;
            C13Color = Color.green;
            C23Color = Color.red;
            C1Color = Color.green;
            C2Color = Color.red;
            C3Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 2){
            C123Color = Color.green;
            C12Color = Color.green;
            C13Color = Color.red;
            C23Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.green;
            C3Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 3){
            C123Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.green;
            C23Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.green;
            C0Color = Color.red;
        }
        else if(start == 123){
            C123Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C23Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 12){
            C123Color = Color.green;
            C12Color = Color.green;
            C13Color = Color.red;
            C23Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 13){
            C123Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.green;
            C23Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 23){
            C123Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C23Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C0Color = Color.red;
        }
        //the trivial fillter is fixed
        else if(start == 0){
            C123Color = Color.green;
            C12Color = Color.green;
            C13Color = Color.green;
            C23Color = Color.green;
            C1Color = Color.green;
            C2Color = Color.green;
            C3Color = Color.green;
            C0Color = Color.green;
        }
        Text3 = "Since we are using a finite lattice all filters are fixed.";
    }

    public void Free(){
        C123Color = Color.red;
        C12Color = Color.red;
        C13Color = Color.red;
        C23Color = Color.red;
        C1Color = Color.red;
        C2Color = Color.red;
        C3Color = Color.red;
        C0Color = Color.red;
        Text3 = "Since we are using a finite lattice there are no free filter as those are in infinite lattices.";
    }

    public void Ultra(){
        int start;
        randIndex = Random.Range(4, 7);
        start = latticeEntries[randIndex];
        if(start == 1){
            C123Color = Color.green;
            C12Color = Color.green;
            C13Color = Color.green;
            C23Color = Color.red;
            C1Color = Color.green;
            C2Color = Color.red;
            C3Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 2){
            C123Color = Color.green;
            C12Color = Color.green;
            C13Color = Color.red;
            C23Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.green;
            C3Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 3){
            C123Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.green;
            C23Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.green;
            C0Color = Color.red;
        }
        Text3 = "Ultra filters are maximal principal filters meaning that there is nothing else you can add to the filter and the filter would still be true.";
    }

    public void Principal(){
        int start;
        randIndex = Random.Range(0, 8);
        start = latticeEntries[randIndex];
        if(start == 1){
            C123Color = Color.green;
            C12Color = Color.green;
            C13Color = Color.green;
            C23Color = Color.red;
            C1Color = Color.green;
            C2Color = Color.red;
            C3Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 2){
            C123Color = Color.green;
            C12Color = Color.green;
            C13Color = Color.red;
            C23Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.green;
            C3Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 3){
            C123Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.green;
            C23Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.green;
            C0Color = Color.red;
        }
        else if(start == 123){
            C123Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C23Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 12){
            C123Color = Color.green;
            C12Color = Color.green;
            C13Color = Color.red;
            C23Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 13){
            C123Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.green;
            C23Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 23){
            C123Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C23Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C0Color = Color.red;
        }
        //the trivial fillter is principal
        else if(start == 0){
            C123Color = Color.green;
            C12Color = Color.green;
            C13Color = Color.green;
            C23Color = Color.green;
            C1Color = Color.green;
            C2Color = Color.green;
            C3Color = Color.green;
            C0Color = Color.green;
        }
        Text3 = "Principal filters are the join or meet of two entries and their lower highest bound or greatest lower bound.";
    }

    public void Trivial(){
        C123Color = Color.green;
        C12Color = Color.green;
        C13Color = Color.green;
        C23Color = Color.green;
        C1Color = Color.green;
        C2Color = Color.green;
        C3Color = Color.green;
        C0Color = Color.green;
        Text3 = "Trivial filters are filters that with the empty set.";
    }
}
