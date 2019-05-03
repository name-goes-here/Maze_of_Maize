using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void win() {
        SceneManager.LoadScene("Winning Screen");
    }

    public void play() {
        SceneManager.LoadScene("MazeTest");
    }
}
