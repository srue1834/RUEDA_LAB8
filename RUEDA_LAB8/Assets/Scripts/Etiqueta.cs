using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Etiqueta : MonoBehaviour
{
    public GameObject texto;

    public void Start()
    {
        texto.SetActive(false);
    }

    public void OnMouseOver()
    {
        texto.SetActive(true);
    }

    public void OnMouseExit()
    {
        texto.SetActive(false);
    }

}
