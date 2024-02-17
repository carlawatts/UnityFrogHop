using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score2 : MonoBehaviour
{
    
    int P1Score = 0;

    public void AddPoint(){
        P1Score += 1;
        Debug.Log("P1 Score: "+ P1Score.ToString());
    }
    void OnTriggerEnter(Collider other)
    {
       AddPoint();
    }
}
