using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GreenScore : MonoBehaviour
{
    private int gPoints = 0;
    public Text gPointsText;
    public Text gFrogWins;

    private void OnTriggerEnter(Collider other){
        if(other.transform.tag == "GreenFrog"){
            gPoints++;
            gPointsText.text = "Green's Score: " + gPoints.ToString();
            Destroy(other.gameObject);

        }
    }
    void Update()
    {
        if (gPoints > 2)
        {
            gFrogWins.text = "Green Frog Wins!";
            Invoke("RestartLevel", 1f);
        }
    }
     private void RestartLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
