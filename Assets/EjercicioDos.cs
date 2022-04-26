using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EjercicioDos : MonoBehaviour
{
    public int edadUsuario;
    public Text eso;
    // Start is called before the first frame update
    void Start()
    {
        if (edadUsuario >= 18)
        {
            Debug.Log("Es mayor de edad");
            eso.text = "Es mayor de edad";
        }

        else
        {
            Debug.Log("No es mayor de edad");
            eso.text = "Es mayor de edad";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
