using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    public GameObject DeathScreen;
    public GameObject WinScreen;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Laser" || other.tag == "Lvl")
        {
            Destroy(this.gameObject);
            DeathScreen.SetActive(true);
        }

        if (other.tag == "Goal")
        {
            WinScreen.SetActive(true);
        }
    }
}
