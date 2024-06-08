using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public GameObject balaPrefab; // Prefab da bala de canhão
    public Transform pontoDeDisparo; // Ponto de onde a bala será disparada
    public float intervaloDeDisparo = 2.0f; // Intervalo de tempo entre disparos

    void Start()
    {
        // Inicia o disparo repetitivo
        InvokeRepeating("Disparar", 0.0f, intervaloDeDisparo);
    }

    void Disparar()
    {
        // Instancia a bala na posição e rotação do ponto de disparo
        Instantiate(balaPrefab, pontoDeDisparo.position, pontoDeDisparo.rotation);
    }
}
