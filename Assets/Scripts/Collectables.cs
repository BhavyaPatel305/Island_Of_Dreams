using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public static int collect = 0; // Number of stars collected
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            collect = collect + 1;
            Destroy(gameObject);
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(600, 70, 273, 500), "Stars Collected");
        GUI.Label(new Rect(700, 70, 273, 500), collect.ToString());
    }

}

