using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Validar : MonoBehaviour
{
    string contraseña;
    string contraseñausuario;
    public Text Ingresousuario;
    public GameObject cartelitomsj;
    public Text textomsj;
    // Start is called before the first frame update
    void Start()
    {
        contraseña = "12345";
        cartelitomsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validar()
    {
        contraseñausuario = Ingresousuario.text;
        if(contraseñausuario == contraseña)
        {
            cartelitomsj.SetActive(true);
            Debug.Log("Bienvenido.");
            textomsj.text = "Bienvenido.";
        }
        else
        {
            cartelitomsj.SetActive(true);
            textomsj.text = "Contraseña Incorrecta.";
            Debug.Log("Contraseña Incorrecta");
        }
    }
}
