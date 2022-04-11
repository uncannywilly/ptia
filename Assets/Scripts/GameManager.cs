using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver;
    public bool gameWon;
    public GameObject gameOverText;
    public GameObject gameWonText;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            GameOver();
        }

        if (gameWon)
        {
            GameWon();
        }
    }

    private void GameWon()
    {
        gameWonText.SetActive(true);
    }

    public void GameOver()
    {
        gameOverText.SetActive(true);
    }
}
