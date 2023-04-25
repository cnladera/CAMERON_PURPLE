using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject timerCanvas;

    private Text timerText;
    private int timerCount;

    // Start is called before the first frame update
    void Start()
    {
        timerCanvas.SetActive(true);
        StartCoroutine(CountTime());
        Time.timeScale = 1f;
        timerText = GameObject.Find("Score").GetComponent<Text>();
    }

    IEnumerator CountTime()
    {
        yield return new WaitForSeconds(1f);
        timerCount++;
        timerText.text = "Score: " + timerCount;
        StartCoroutine(CountTime());
    }
}
