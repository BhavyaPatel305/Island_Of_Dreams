using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_zone : MonoBehaviour
{
    [SerializeField] Material mat;

    // Update is called once per frame

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material = mat;

        }
    }
}
