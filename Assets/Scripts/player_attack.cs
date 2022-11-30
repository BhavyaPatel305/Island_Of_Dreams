using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_attack : MonoBehaviour
{
    public static int score = 0;
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            score = score + 1;
            Debug.Log(score);
            Destroy(gameObject);
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(600, 50, 273, 500), "Killed");// TB[1][1]
        GUI.Label(new Rect(700, 50, 273, 500), score.ToString());// TB[1][2]
    }

    //if score =6
    //save star count
    //go to next level
}
