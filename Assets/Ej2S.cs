using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2S : MonoBehaviour
{
    public int edad;
    public float altura;

    // Start is called before the first frame update
    void Start()
    {
        if (altura > 1.2 | edad > 13)
        {
            Debug.Log("INGRESO PERMITIDO");
        }

        else if (edad < 1 | altura < 0)
        {
            Debug.Log("ERROR");
        }

        else
        {
            Debug.Log("INGRESO DENEGADO");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
