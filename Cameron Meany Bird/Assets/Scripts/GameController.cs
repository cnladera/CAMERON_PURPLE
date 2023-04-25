using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Speed for the game is at playing state
        Time.timeScale = 1;
        //Score in visible
        scoreCanvas.SetActive(true);
        //Game Over UI is invisible
        gameOverCanvas.SetActive(false);
        //The spawner is shown in the game
        spawner.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
    //Game Over Canvas that is used for the game
    [Header("Game Over UI Object for displaying Game Over Screen")]
    public GameObject gameOverCanvas;
    //Score Canvas that is used for the game
    [Header("Score UI Object for displaying Score")]
    public GameObject scoreCanvas;
    //Spawner object that is used for the game
    [Header("Spawner Object for spawning object in game")]
    public GameObject spawner;

    public void GameOver()
    {
        //Game Over UI is visible 
        gameOverCanvas.SetActive(true);
        //The spawner is now invisible in the game
        spawner.SetActive(false);
        //The speed for the game is now at stopping state
        Time.timeScale = 0;
    }
}
