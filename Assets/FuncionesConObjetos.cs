using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionesConObjetos : MonoBehaviour
{
    public GameObject miObj;
    public GameObject otroObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PosicionarObjetoEnOrigen(miObj);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (PosicionYNoNegativa(miObj))
            {
                Debug.Log("Y no es negativa");
            }
            else
            {
                Debug.Log("Y es negativa");
            }
            
        }

    }

    //Recibe como parámetro un objeto y lo posiciona en el origen del espacio.
    void PosicionarObjetoEnOrigen(GameObject obj)
    {
        obj.transform.position = Vector3.zero;
    }

    //Devuelve true si el valor de Y de la posición de un GameObject 
    //    recibido como parámetro no es negativo, false si lo es.

    bool PosicionYNoNegativa(GameObject obj)
    {
        bool yNoNegativa = false;

        if (obj.transform.position.y >= 0)
        {
            yNoNegativa = true;
        }

        return yNoNegativa;
    }

}
