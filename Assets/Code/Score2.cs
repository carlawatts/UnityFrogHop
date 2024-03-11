using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score2 : MonoBehaviour
{
    public Text scoreText1;
    public Text p1Wins;
    int p1Score = 0;

    void Start()
    {
        scoreText1.text = "Red Frog's Score: " + p1Score.ToString();
    
    }

    void Update()
    {
        if (p1Score > 4)
        {
            p1Wins.text = "Red Frog Wins!";
            Invoke("RestartLevel", 1.5f);

        }
    }
    private void RestartLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void AddPoint()
    {
        p1Score += 1;
        scoreText1.text = "Red Frog's Score: " + p1Score.ToString();
    }
    void OnTriggerEnter(Collider other)
    {
        AddPoint();
    }
}
