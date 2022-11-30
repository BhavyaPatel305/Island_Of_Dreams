using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    const int m_buttonW = 200;
    const int m_buttonH = 50;
    string[] m_levelNames;
    public int m_nbButtons;

    Rect[] m_buttonsRect;
    // Start is called before the first frame update
    void Start()
    {

        m_buttonsRect = new Rect[2];
        for (int i = 0; i < m_nbButtons; i++)
        {
            m_buttonsRect[i] = new Rect(0, i * m_buttonH, m_buttonW, m_buttonH);
        }
        m_levelNames = new string[m_nbButtons];
        m_levelNames[0] = "Level1";
        m_levelNames[1] = "Quit";
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        int i = 0;
        for (i = 0; i < m_nbButtons; i++)
        {
            if (GUI.Button(m_buttonsRect[i], m_levelNames[i]))
            {
                SceneManager.LoadScene(m_levelNames[i]);
            }

        }

    }

    public void goBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
