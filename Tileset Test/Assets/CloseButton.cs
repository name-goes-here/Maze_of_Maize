using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This will close the game
public class CloseButton : MonoBehaviour
{
    
    public void doExitGame() 
    {
    Application.Quit();
    Debug.Log("quits game");
    }
}