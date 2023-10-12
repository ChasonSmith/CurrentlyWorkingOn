using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonLoader2 : MonoBehaviour
{
    public List<int> latticeEntries = new List<int>() {12, 1, 2, 0};
    public Color C12Color = Color.white;
    public Color C1Color = Color.white;
    public Color C2Color = Color.white;
    public Color C0Color = Color.white;
    public string Text2;
    int randIndex;
    
    public void Menu(){
        C12Color = Color.white;
        C1Color = Color.white;
        C2Color = Color.white;
        C0Color = Color.white;
        SceneManager.LoadScene(0);
        Text2 = "";
    }

    public void Restart(){
        C12Color = Color.white;
        C1Color = Color.white;
        C2Color = Color.white;
        C0Color = Color.white;
        Text2 = "";
    }

    public void Proper(){
        int start;
        randIndex = Random.Range(0, 3);
        start = latticeEntries[randIndex];
        if(start == 1){
            C12Color = Color.green;
            C1Color = Color.green;
            C2Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 2){
            C12Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.green;
            C0Color = Color.red;
        }
        else if(start == 12){
            C12Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.red;
            C0Color = Color.red;
        }
        Text2 = "In a proper fillter the stipulation is that the filter is not equal to the lattice.";
    }

    public void Fixed(){
        int start;
        randIndex = Random.Range(0, 4);
        start = latticeEntries[randIndex];
        if(start == 1){
            C12Color = Color.green;
            C1Color = Color.green;
            C2Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 2){
            C12Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.green;
            C0Color = Color.red;
        }
        else if(start == 12){
            C12Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.red;
            C0Color = Color.red;
        }
        //the trivial fillter is principal
        else if(start == 0){
            C12Color = Color.green;
            C1Color = Color.green;
            C2Color = Color.green;
            C0Color = Color.green;
        }
        Text2 = "Since we are using a finite lattice all filters are fixed.";
    }

    public void Free(){
        C12Color = Color.red;
        C1Color = Color.red;
        C2Color = Color.red;
        C0Color = Color.red;
        Text2 = "Since we are using a finite lattice there are no free filter as those are in infinite lattices.";
    }

    public void Ultra(){
        int start;
        randIndex = Random.Range(1, 3);
        start = latticeEntries[randIndex];
        if(start == 1){
            C12Color = Color.green;
            C1Color = Color.green;
            C2Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 2){
            C12Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.green;
            C0Color = Color.red;
        }
        Text2 = "Ultra filters are maximal principal filters meaning that there is nothing else you can add to the filter and the filter would still be true.";
    }

    public void Principal(){
        int start;
        randIndex = Random.Range(0, 4);
        start = latticeEntries[randIndex];
        if(start == 1){
            C12Color = Color.green;
            C1Color = Color.green;
            C2Color = Color.red;
            C0Color = Color.red;
        }
        else if(start == 2){
            C12Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.green;
            C0Color = Color.red;
        }
        else if(start == 12){
            C12Color = Color.green;
            C1Color = Color.red;
            C2Color = Color.red;
            C0Color = Color.red;
        }
        //the trivial fillter is principal
        else if(start == 0){
            C12Color = Color.green;
            C1Color = Color.green;
            C2Color = Color.green;
            C0Color = Color.green;
        }
        Text2 = "Principal filters are the join or meet of two entries and their lower highest bound or greatest lower bound.";    
    }

    public void Trivial(){
        C12Color = Color.green;
        C1Color = Color.green;
        C2Color = Color.green;
        C0Color = Color.green;
        Text2 = "Trivial filters are filters that with the empty set.";
    }
    
}
