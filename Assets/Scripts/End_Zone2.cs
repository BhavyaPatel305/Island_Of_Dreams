using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End_Zone2 : MonoBehaviour
{
    [SerializeField] Material mat;

    // Update is called once per frame

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Stat");
            gameObject.GetComponent<Renderer>().material = mat;

        }
    }
}
