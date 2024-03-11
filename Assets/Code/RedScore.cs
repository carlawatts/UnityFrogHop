using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class RedScore : MonoBehaviour
{
     private int rPoints = 0;
    public Text rPointsText;
        public Text rFrogWins;

    private void OnTriggerEnter(Collider other){
        if(other.transform.tag == "RedFrog"){
            rPoints++;
            rPointsText.text = "Red's Score: " + rPoints.ToString();
            Destroy(other.gameObject);

        }
    }

     void Update()
    {
        if (rPoints > 2)
        {
            rFrogWins.text = "Red Frog Wins!";
            Invoke("RestartLevel", 1f);
        }
    }
     private void RestartLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
