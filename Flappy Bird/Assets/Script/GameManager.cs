using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    // Start is called before the first frame update
    private int score;

    public void GameOver()
    {
        Debug.Log("Game Over");

    }
    public void IncreaseScore()
    {
        score++;
    }
}
