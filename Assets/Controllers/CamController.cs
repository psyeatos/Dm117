using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public Transform alvo; 
    public Vector3 offset; 
    public float suavidade = 0.125f;

    void LateUpdate()
    {
        // Calcula a posi��o desejada da c�mera
        Vector3 posicaoDesejada = alvo.position + offset;

        // Suaviza a transi��o da posi��o atual para a posi��o desejada
        Vector3 posicaoSuavizada = Vector3.Lerp(transform.position, posicaoDesejada, suavidade);

        // Atualiza a posi��o da c�mera
        transform.position = posicaoSuavizada;
    }
}
