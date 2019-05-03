using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsToMainMenu : MonoBehaviour
{
    


    public void accessCredits()
    {
   
        SceneManager.LoadScene("MazeTest",LoadSceneMode.Single);
    }

  
}