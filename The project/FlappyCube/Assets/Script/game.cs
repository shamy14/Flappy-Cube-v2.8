using UnityEngine;
using System.Collections;

public class game : MonoBehaviour {

public bool isQuit=false;

void  OnMouseOver (){
    //change text color
    renderer.material.color=Color.white;
}

void  OnMouseUp (){
    //is this quit
    if (isQuit == true) {
    //quit the game
        Application.Quit();
    }
    else {
    //load level
        Application.LoadLevel(1);
    }
}

void Start(){
    if (Input.GetKey(KeyCode.Escape))
    {
        Application.LoadLevel(0);
    }
}

void  Update (){
    //quit game if escape key is pressed
    if (Input.GetKey(KeyCode.Escape)) {
        Application.LoadLevel(0);
        }
    }
}
