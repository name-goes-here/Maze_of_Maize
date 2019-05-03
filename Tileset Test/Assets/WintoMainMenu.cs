using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WintoMainMenu : MonoBehaviour
{
    


    public void accessMenu()
    {
   
        SceneManager.LoadScene("MenuScreen",LoadSceneMode.Single);
    }

  
}