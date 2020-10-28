using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public void StartGame()
    {
        if (FindObjectOfType<ScoreScript>().level == 10)
        {
            FindObjectOfType<ScoreScript>().GoodScore = 0;
            FindObjectOfType<ScoreScript>().StupidScore = 0;
            FindObjectOfType<ScoreScript>().EvilScore = 0;

            FindObjectOfType<ScoreScript>().brainScore = 0;

            FindObjectOfType<ScoreScript>().game1 = -1;
            FindObjectOfType<ScoreScript>().game2 = -1;
            FindObjectOfType<ScoreScript>().game3 = -1;
            FindObjectOfType<ScoreScript>().game4 = -1;
            FindObjectOfType<ScoreScript>().game5 = -1;

            FindObjectOfType<ScoreScript>().response = 0;
            FindObjectOfType<ScoreScript>().level = 0;
        }
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
