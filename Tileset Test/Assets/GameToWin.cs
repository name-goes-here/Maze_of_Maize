using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameToWin : MonoBehaviour
{
    


    public void accessWin()
    {
   
        SceneManager.LoadScene("Winning Screen",LoadSceneMode.Single);
    }

  
}