using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenutoGame : MonoBehaviour
{
    


    public void accessGame()
    {
   
        SceneManager.LoadScene("MazeTest",LoadSceneMode.Single);
    }

  
}