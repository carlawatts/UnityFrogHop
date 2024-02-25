using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score1 : MonoBehaviour
{
     public Text scoreText1;
       public Text p2Wins;
    int p2Score = 0;

 void Start(){
        scoreText1.text = "Green Frog's Score: " + p2Score.ToString();
    }

      void Update(){
        if (p2Score > 4){
            p2Wins.text = "Green Frog Wins!";
            Invoke("RestartLevel", 1f);
        }
    }

    private void RestartLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void AddPoint(){
        p2Score += 1;
        scoreText1.text = "Green Frog's Score: " + p2Score.ToString();
    }
    void OnTriggerEnter(Collider other)
    {
       AddPoint();
    }
}
