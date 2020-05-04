using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOptions : MonoBehaviour { 

    public void TrackSelect ()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayGame () 
    {
        SceneManager.LoadScene(2);
    }

    public void MainMenu ()
    {
        SceneManager.LoadScene(0);
    }

    public void SettingsMenu ()
    {
        SceneManager.LoadScene(3);
    }

    //Below here are track selection buttons
    public void HillsideTrack ()
    {
        SceneManager.LoadScene(2);
    }
}
