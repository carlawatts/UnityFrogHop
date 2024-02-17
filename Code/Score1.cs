using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score1 : MonoBehaviour
{
    int P2Score = 0;

    public void AddPoint(){
        P2Score += 1;
        Debug.Log("P2 Score: "+ P2Score.ToString());
    }
    void OnTriggerEnter(Collider other)
    {
       AddPoint();
    }
}
