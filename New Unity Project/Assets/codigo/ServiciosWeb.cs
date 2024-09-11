using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ServiciosWeb : MonoBehaviour
{
    public RespuestaRegistro respuestaRegistro;
    // Start is called before the first frame update
    void Start()
    {
        Usuario usuario =new Usuario();
        usuario.cedula="1053778651";
        usuario.nombre="Henry Cavil";
        usuario.email="henry@gmail.com";
        StartCoroutine(RegistrarUsuario(usuario));
    }

    public IEnumerator RegistrarUsuario(Usuario datosRegistro)
    {
        var registroJSON = JsonUtility.ToJson(datosRegistro);

        var solicitud = new UnityWebRequest();
        solicitud.url = "http://localhost:3000/api/jugador/registrar";

        byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(registroJSON);
        solicitud.uploadHandler = new uploadHandlerRaw(bodyRaw);
        soli
    }

}
