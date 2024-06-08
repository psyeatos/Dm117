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
        // Calcula a posição desejada da câmera
        Vector3 posicaoDesejada = alvo.position + offset;

        // Suaviza a transição da posição atual para a posição desejada
        Vector3 posicaoSuavizada = Vector3.Lerp(transform.position, posicaoDesejada, suavidade);

        // Atualiza a posição da câmera
        transform.position = posicaoSuavizada;
    }
}
