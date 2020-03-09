using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Linterna;
    public AudioSource audioS;



    private void Update()
    {
        LinSwitch();
    }


    public void LinSwitch()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            GetComponent<AudioSource>().Play();
            Linterna.SetActive(true);
            

        }

        if (Input.GetKeyDown(KeyCode.P))

        {
            GetComponent<AudioSource>().Play();
            Linterna.SetActive(false);
            

        }

    }

    
}

