using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }
    public void playGame(){
        Screen.orientation = ScreenOrientation.LandscapeRight;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

  public void credits(){
    SceneManager.LoadScene("Menu");
  }

  public void quitGame(){
    Application.Quit();
  }

  public void playAgain(){

        Screen.orientation = ScreenOrientation.LandscapeRight;
        SceneManager.LoadScene("Level 1");

	}
}
