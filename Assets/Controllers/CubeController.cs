using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float velocidade;
    public float amplitude;

    void Update()
    {
        // Calcula a nova posi��o x usando Mathf.PingPong
        float novaPosicaoX = Mathf.PingPong(Time.time * velocidade, amplitude * 2) - amplitude;

        // Atualiza a posi��o do GameObject
        transform.position = new Vector3(novaPosicaoX, transform.position.y, transform.position.z);
    }
}
