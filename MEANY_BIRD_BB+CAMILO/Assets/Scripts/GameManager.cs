using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject scoreCanvas;
    public GameObject spawner;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        scoreCanvas.SetActive(true);
        spawner.SetActive(true);
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        scoreCanvas.SetActive(false);
        spawner.SetActive(false);
        Time.timeScale = 0;
    }
}
