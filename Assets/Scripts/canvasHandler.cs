using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class canvasHandler : MonoBehaviour
{
    public GameObject MenuScreen;
    public GameObject DeathScreen;
    public GameObject WinScreen;

    void Start()
    {
        MenuScreen.SetActive(false);
        DeathScreen.SetActive(false);
        WinScreen.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.Escape) && !MenuScreen.activeSelf)
        {
            MenuScreen.SetActive(true);
        }

        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            MenuScreen.SetActive(false);
        }
    }
}
