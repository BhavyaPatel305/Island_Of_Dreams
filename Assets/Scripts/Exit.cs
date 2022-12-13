using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    void Start()
    {
        exit();
    }
    
    // Start is called before the first frame update
    void exit()
    {
        Application.Quit();
    }
}
