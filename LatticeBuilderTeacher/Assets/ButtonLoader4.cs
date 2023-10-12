using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonLoader4 : MonoBehaviour
{
    public List<int> latticeEntries = new List<int>() {1234, 234, 134, 124, 123, 34, 24, 23, 14, 13, 12, 4, 3, 2, 1, 0};
    public Color C0Color = Color.white;
    public Color C1Color = Color.white;
    public Color C2Color = Color.white;
    public Color C3Color = Color.white;
    public Color C4Color = Color.white;
    public Color C12Color = Color.white;
    public Color C13Color = Color.white;
    public Color C14Color = Color.white;
    public Color C23Color = Color.white;
    public Color C24Color = Color.white;
    public Color C34Color = Color.white;
    public Color C123Color = Color.white;
    public Color C124Color = Color.white;
    public Color C134Color = Color.white;
    public Color C234Color = Color.white;
    public Color C1234Color = Color.white;
    public string Text4;
    int randIndex;
    
    public void Menu(){
        C1234Color = Color.white;
        C123Color = Color.white;
        C124Color = Color.white;
        C134Color = Color.white;
        C234Color = Color.white;
        C12Color = Color.white;
        C13Color = Color.white;
        C14Color = Color.white;
        C23Color = Color.white;
        C24Color = Color.white;
        C34Color = Color.white;
        C1Color = Color.white;
        C2Color = Color.white;
        C3Color = Color.white;
        C4Color = Color.white;
        C0Color = Color.white;
        SceneManager.LoadScene(0);
        Text4 = "";
    }

    public void Restart(){
        C1234Color = Color.white;
        C123Color = Color.white;
        C124Color = Color.white;
        C134Color = Color.white;
        C234Color = Color.white;
        C12Color = Color.white;
        C13Color = Color.white;
        C14Color = Color.white;
        C23Color = Color.white;
        C24Color = Color.white;
        C34Color = Color.white;
        C1Color = Color.white;
        C2Color = Color.white;
        C3Color = Color.white;
        C4Color = Color.white;
        C0Color = Color.white;
        Text4 = "";
    }

    public void Proper(){
        int start;
        randIndex = Random.Range(0, 15);
        start = latticeEntries[randIndex];
        if(start == 1){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.green;
            C134Color = Color.green;
            C234Color = Color.red;
            C12Color = Color.green;
            C13Color = Color.green;
            C14Color = Color.green;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.green;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 2){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.green;
            C134Color = Color.red;
            C234Color = Color.green;
            C12Color = Color.green;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.green;
            C24Color = Color.green;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.green;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 3){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.red;
            C134Color = Color.green;
            C234Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.green;
            C14Color = Color.red;
            C23Color = Color.green;
            C24Color = Color.red;
            C34Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.green;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 4){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.green;
            C134Color = Color.green;
            C234Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.green;
            C23Color = Color.red;
            C24Color = Color.green;
            C34Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.green;
            C0Color = Color.red;
        }
        else if(start == 12){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.green;
            C134Color = Color.red;
            C234Color = Color.red;
            C12Color = Color.green;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 13){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.red;
            C134Color = Color.green;
            C234Color = Color.red;
            C12Color = Color.red;
            C13Color = Color.green;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 14){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.green;
            C134Color = Color.green;
            C234Color = Color.red;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.green;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 23){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.red;
            C134Color = Color.red;
            C234Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.green;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 24){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.green;
            C134Color = Color.red;
            C234Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.green;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 34){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.red;
            C134Color = Color.green;
            C234Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 123){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.red;
            C134Color = Color.red;
            C234Color = Color.red;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 124){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.green;
            C134Color = Color.red;
            C234Color = Color.red;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 134){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.red;
            C134Color = Color.green;
            C234Color = Color.red;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 234){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.red;
            C134Color = Color.red;
            C234Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 1234){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.red;
            C134Color = Color.red;
            C234Color = Color.red;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        Text4 = "In a proper fillter the stipulation is that the filter is not equal to the lattice.";
    }

    public void Fixed(){
        int start;
        randIndex = Random.Range(0, 16);
        start = latticeEntries[randIndex];
        if(start == 1){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.green;
            C134Color = Color.green;
            C234Color = Color.red;
            C12Color = Color.green;
            C13Color = Color.green;
            C14Color = Color.green;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.green;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 2){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.green;
            C134Color = Color.red;
            C234Color = Color.green;
            C12Color = Color.green;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.green;
            C24Color = Color.green;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.green;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 3){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.red;
            C134Color = Color.green;
            C234Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.green;
            C14Color = Color.red;
            C23Color = Color.green;
            C24Color = Color.red;
            C34Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.green;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 4){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.green;
            C134Color = Color.green;
            C234Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.green;
            C23Color = Color.red;
            C24Color = Color.green;
            C34Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.green;
            C0Color = Color.red;
        }
        else if(start == 12){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.green;
            C134Color = Color.red;
            C234Color = Color.red;
            C12Color = Color.green;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 13){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.red;
            C134Color = Color.green;
            C234Color = Color.red;
            C12Color = Color.red;
            C13Color = Color.green;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 14){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.green;
            C134Color = Color.green;
            C234Color = Color.red;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.green;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 23){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.red;
            C134Color = Color.red;
            C234Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.green;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 24){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.green;
            C134Color = Color.red;
            C234Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.green;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 34){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.red;
            C134Color = Color.green;
            C234Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 123){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.red;
            C134Color = Color.red;
            C234Color = Color.red;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 124){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.green;
            C134Color = Color.red;
            C234Color = Color.red;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 134){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.red;
            C134Color = Color.green;
            C234Color = Color.red;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 234){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.red;
            C134Color = Color.red;
            C234Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 1234){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.red;
            C134Color = Color.red;
            C234Color = Color.red;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 0){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.green;
            C134Color = Color.green;
            C234Color = Color.green;
            C12Color = Color.green;
            C13Color = Color.green;
            C14Color = Color.green;
            C23Color = Color.green;
            C24Color = Color.green;
            C34Color = Color.green;
            C1Color = Color.green;
            C2Color = Color.green;
            C3Color = Color.green;
            C4Color = Color.green;
            C0Color = Color.green;
        }
        Text4 = "Since we are using a finite lattice all filters are fixed.";
    }

    public void Free(){
        C1234Color = Color.red;
        C123Color = Color.red;
        C124Color = Color.red;
        C134Color = Color.red;
        C234Color = Color.red;
        C12Color = Color.red;
        C13Color = Color.red;
        C14Color = Color.red;
        C23Color = Color.red;
        C24Color = Color.red;
        C34Color = Color.red;
        C1Color = Color.red;
        C2Color = Color.red;
        C3Color = Color.red;
        C4Color = Color.red;
        C0Color = Color.red;
        Text4 = "Since we are using a finite lattice there are no free filter as those are in infinite lattices.";
    }

    public void Ultra(){
        int start;
        randIndex = Random.Range(11, 15);
        start = latticeEntries[randIndex];
        if(start == 1){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.green;
            C134Color = Color.green;
            C234Color = Color.red;
            C12Color = Color.green;
            C13Color = Color.green;
            C14Color = Color.green;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.green;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 2){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.green;
            C134Color = Color.red;
            C234Color = Color.green;
            C12Color = Color.green;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.green;
            C24Color = Color.green;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.green;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 3){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.red;
            C134Color = Color.green;
            C234Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.green;
            C14Color = Color.red;
            C23Color = Color.green;
            C24Color = Color.red;
            C34Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.green;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 4){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.green;
            C134Color = Color.green;
            C234Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.green;
            C23Color = Color.red;
            C24Color = Color.green;
            C34Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.green;
            C0Color = Color.red;
        }
        Text4 = "Ultra filters are maximal principal filters meaning that there is nothing else you can add to the filter and the filter would still be true.";
    }

    public void Principal(){
        int start;
        randIndex = Random.Range(0, 16);
        start = latticeEntries[randIndex];
        if(start == 1){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.green;
            C134Color = Color.green;
            C234Color = Color.red;
            C12Color = Color.green;
            C13Color = Color.green;
            C14Color = Color.green;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.green;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 2){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.green;
            C134Color = Color.red;
            C234Color = Color.green;
            C12Color = Color.green;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.green;
            C24Color = Color.green;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.green;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 3){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.red;
            C134Color = Color.green;
            C234Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.green;
            C14Color = Color.red;
            C23Color = Color.green;
            C24Color = Color.red;
            C34Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.green;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 4){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.green;
            C134Color = Color.green;
            C234Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.green;
            C23Color = Color.red;
            C24Color = Color.green;
            C34Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.green;
            C0Color = Color.red;
        }
        else if(start == 12){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.green;
            C134Color = Color.red;
            C234Color = Color.red;
            C12Color = Color.green;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 13){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.red;
            C134Color = Color.green;
            C234Color = Color.red;
            C12Color = Color.red;
            C13Color = Color.green;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 14){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.green;
            C134Color = Color.green;
            C234Color = Color.red;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.green;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 23){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.red;
            C134Color = Color.red;
            C234Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.green;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 24){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.green;
            C134Color = Color.red;
            C234Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.green;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 34){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.red;
            C134Color = Color.green;
            C234Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 123){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.red;
            C134Color = Color.red;
            C234Color = Color.red;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 124){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.green;
            C134Color = Color.red;
            C234Color = Color.red;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 134){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.red;
            C134Color = Color.green;
            C234Color = Color.red;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 234){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.red;
            C134Color = Color.red;
            C234Color = Color.green;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 1234){
            C1234Color = Color.green;
            C123Color = Color.red;
            C124Color = Color.red;
            C134Color = Color.red;
            C234Color = Color.red;
            C12Color = Color.red;
            C13Color = Color.red;
            C14Color = Color.red;
            C23Color = Color.red;
            C24Color = Color.red;
            C34Color = Color.red;
            C1Color = Color.red;
            C2Color = Color.red;
            C3Color = Color.red;
            C4Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 0){
            C1234Color = Color.green;
            C123Color = Color.green;
            C124Color = Color.green;
            C134Color = Color.green;
            C234Color = Color.green;
            C12Color = Color.green;
            C13Color = Color.green;
            C14Color = Color.green;
            C23Color = Color.green;
            C24Color = Color.green;
            C34Color = Color.green;
            C1Color = Color.green;
            C2Color = Color.green;
            C3Color = Color.green;
            C4Color = Color.green;
            C0Color = Color.green;
        }
        Text4 = "Principal filters are the join or meet of two entries and their lower highest bound or greatest lower bound.";    
    }

    public void Trivial(){
        C1234Color = Color.green;
        C123Color = Color.green;
        C124Color = Color.green;
        C134Color = Color.green;
        C234Color = Color.green;
        C12Color = Color.green;
        C13Color = Color.green;
        C14Color = Color.green;
        C23Color = Color.green;
        C24Color = Color.green;
        C34Color = Color.green;
        C1Color = Color.green;
        C2Color = Color.green;
        C3Color = Color.green;
        C4Color = Color.green;
        C0Color = Color.green;
        Text4 = "Trivial filters are filters that with the empty set.";
    }
    
}
