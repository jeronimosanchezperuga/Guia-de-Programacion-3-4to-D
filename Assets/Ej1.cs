//Definir una función que escriba en consola “Hola Mundo!” al ser invocada.
//    Invocar la función al presionar la barra espaciadora.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EscribirCadena("Mi cadena es esta");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HolaMundo();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ConcatenarYEscribir("Jeronimo",45);
        }
    }

    void HolaMundo()
    {
        Debug.Log("Hola mundo!");
    }

    //Definir una función que escriba en consola la cadena pasada por parámetro.

    void EscribirCadena(string cadena)
    {
        Debug.Log(cadena);
    }

    //Definir una función que concatene y muestre en consola un string y un int pasados por parámetros.
    void ConcatenarYEscribir(string cadena, int nro)
    {
        string mensaje = cadena + nro;
        Debug.Log(mensaje);
    }

}
