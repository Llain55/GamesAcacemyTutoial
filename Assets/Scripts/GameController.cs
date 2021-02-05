using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int coins = 0;
    public Text coinsLabel;
    public GameObject gameOver;
    public bool hasKey;
    // Start is called before the first frame update
    void Start()
    {
        coinsLabel.text = "Coins: 0";
        gameOver.SetActive(false);
        hasKey = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void UpdateCoin()
    {
        coins++;
        coinsLabel.text = "Coins: " + coins;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }
}
