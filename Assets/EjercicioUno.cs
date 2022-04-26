using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioUno : MonoBehaviour
{
    public int numeroa, numerollego;
    // Start is called before the first frame update
    void Start()
    {
        if(numeroa != numerollego && numeroa > numerollego)
        {
            while(numeroa >= numerollego)
            {
                Debug.Log(numeroa);
                numeroa--;
            }
        }
        else
        {
        Debug.Log("Los numeros son iguales o el numeroa es menor que el numero a llegar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
