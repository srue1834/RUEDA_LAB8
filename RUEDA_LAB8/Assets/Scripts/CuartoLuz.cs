using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuartoLuz : MonoBehaviour
{
    public GameObject pared1;
    public GameObject pared2;
    public GameObject pared3;
    public GameObject pared4;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Luz"))
        {
            Debug.Log("apagado");
            other.GetComponent<Light>().enabled = true;
            pared1.GetComponent<Light>().enabled = true;
            pared2.GetComponent<Light>().enabled = true;
            pared3.GetComponent<Light>().enabled = true;
            pared4.GetComponent<Light>().enabled = true;
        }
    }
}
