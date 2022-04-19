using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1S : MonoBehaviour
{
    public int cantidadgramos;
    public string gustodehelado;

    // Start is called before the first frame update
    void Start()
    {
        int preciokilo = 500;
        int kilo = 1000;
        int kilodivido = kilo / cantidadgramos;
        int precioporgramo = preciokilo / kilodivido;
        int descuentofurtiila = precioporgramo / 100;
        int descuentofrutilla2 = descuentofurtiila * 10;

        int descuentofinal = precioporgramo - descuentofrutilla2;

        if (gustodehelado == "DDL")
        {
            Debug.Log("El precio final es: " + precioporgramo);
        }

        else if (gustodehelado == "CHO")
        {
            Debug.Log("El precio final es: " + precioporgramo);
        }

        else if (gustodehelado == "FRU")
        {
            Debug.Log("El precio final es: " + descuentofinal);

        }

        else if (cantidadgramos < 250 | cantidadgramos > 3000 )
        {
            Debug.Log("ERROR");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
