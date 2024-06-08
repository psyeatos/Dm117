using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float velocidade;
    public float amplitude;

    void Update()
    {
        // Calcula a nova posição x usando Mathf.PingPong
        float novaPosicaoX = Mathf.PingPong(Time.time * velocidade, amplitude * 2) - amplitude;

        // Atualiza a posição do GameObject
        transform.position = new Vector3(novaPosicaoX, transform.position.y, transform.position.z);
    }
}
