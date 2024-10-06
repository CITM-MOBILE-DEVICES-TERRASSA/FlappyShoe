using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class GameManeger : MonoBehaviour
{
    // Start is called before the first frame update
    public NewBehaviourScript player; 
    public TextAlignment sc;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;


    private int score;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();
        playButton.SetActive(false);
        gameOver.SetActive(false);
        Time.timeScale = 1f;
        player.enabled = true;

        //Pipes pipes[] = FindObjectOfType<Pipes>();
        //for (int i = 0; i < pipes.length; i++)
        //{

        //}
        Pipes pipes = FindObjectOfType<Pipes>();

        Destroy(obj: pipes.gameObject);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Debug.Log("Game Over");
        Pause();

    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
