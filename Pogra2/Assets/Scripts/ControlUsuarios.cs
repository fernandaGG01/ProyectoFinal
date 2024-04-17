using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ControlUsuarios : MonoBehaviour
{
    public List<string> usuarios = new List<string>() { "fernanda", "marifer" };
    public TMP_InputField inputField;
    public TMP_InputField inputField2;

    public GameObject mensajeError;

    private void Start()
    {
        // Asegúrate de que el objeto del mensaje de error esté desactivado al inicio.
        if (mensajeError != null)
        {
            mensajeError.SetActive(false);
        }
    }


    public void Login()
    {
        if(usuarios.Contains(inputField.text))
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            // Si el usuario no existe, activa el mensaje de error.
            if (mensajeError != null)
            {
                mensajeError.SetActive(true);
            }

            Debug.Log("El usuario no existe");
        }
    }

    public void SingIn()
    {
        if (!usuarios.Contains(inputField2.text))
        {
            usuarios.Add(inputField2.text);
        }
        else
        {
            Debug.Log("El usuario se a creado");

        }
    }
}
