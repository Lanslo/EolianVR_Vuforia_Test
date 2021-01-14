using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Change : MonoBehaviour
{

    public Material first;
    public Material second;


    public void Start()
    {
        first = gameObject.GetComponent<MeshRenderer>().material;
    }

    public void Change()
    {
        if (gameObject.GetComponent<MeshRenderer>().material == first)
        {
            gameObject.GetComponent<MeshRenderer>().material = second;
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material = first;
        }
    }
}
