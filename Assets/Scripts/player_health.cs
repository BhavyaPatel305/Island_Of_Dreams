using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_health : MonoBehaviour
{
    public static double health = 100000f; // Health of the character

    void FixedUpdate()
    {
        health -= 0.1f;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(600, 30, 273, 500), "Health");// TB[1][1]
        GUI.Label(new Rect(700, 30, 273, 500), health.ToString());// TB[1][2]
        if (health <= 0)
        {
            GUI.Label(new Rect(200, 250, 273, 500), "Lost the Game");
        }
    }


}
