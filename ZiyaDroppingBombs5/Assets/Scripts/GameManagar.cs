using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagar : MonoBehaviour
{

    private Spawner spawner;
    public GameObject title;
    private Vector2 screenBounds;
    public GameObject playerPrefab;
    public GameObject splash;
    private GameObject player;
    private bool gameStarted = false;
    public GameObject scoreSystem;
    public Text scoreText;
    public int pointsWorth = 1;
    private int score;

    private bool smokeCleared = true;



    void Awake()
    {
        spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        player = playerPrefab;
    }
    // Start is called before the first frame update
    void Start()
    {
        spawner.active = true;
        title.SetActive(false);
        splash.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)
        {
            Debug.Log("Player death");
            if (Input.anyKeyDown)
            {
                smokeCleared = false;
                ResetGame();
            }
        }
       
        if (!player)
        {
            Debug.Log("Player death");
            OnPlayerKilled();
        }
        
        if (Input.anyKeyDown)
        {
            spawner.active = true;
            title.SetActive(false);
        }

        var nextBomb = GameObject.FindGameObjectsWithTag("Bomb");

        foreach(GameObject bombObject in nextBomb)
        {
            if (!gameStarted)
            {
                Destroy(bombObject);
            }else if (bombObject.transform.position.y < (-screenBounds.y) && gameStarted)
            {
                scoreSystem.GetComponent<Score>().AddScore(pointsWorth);
                Destroy(bombObject);
            }
        }

    }

    void ResetGame()
    {
        spawner.active = true;
        title.SetActive(false);
        splash.SetActive(false);
        player = Instantiate(playerPrefab, new Vector3(0, 0, 0), playerPrefab.transform.rotation);
        gameStarted = true;

        scoreText.enabled = true;
        scoreSystem.GetComponent<Score>().score = 0;
        scoreSystem.GetComponent<Score>().Start();
    }

    void OnPlayerKilled()
    {
        spawner.active = false;
        gameStarted = false;

        splash.SetActive(true);

        Invoke("SplashScreen", 2f);
    }

    void SplashScreen()
    {
        smokeCleared = true;
        splash.SetActive(true);
    }
}
