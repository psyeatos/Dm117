using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapController : MonoBehaviour
{
    public float velocidadeDeTransicao = 5.0f; 

    private bool resetandoPosicao = false;

    public GameObject uiCanvas; // Referência ao GameObject do Canvas

    void Start()
    {
        // Inicialmente desativa a UI
        uiCanvas.SetActive(false);
    }

    void Update()
    {
        if (transform.position.y <= -5 && !resetandoPosicao)
        {
            resetandoPosicao = true;
            StartCoroutine(MoverParaOrigem());
        }
    }

    IEnumerator MoverParaOrigem()
    {
        Vector3 posicaoInicial = transform.position;
        Vector3 posicaoFinal = new Vector3(0, 0.225f, 0);
        float tempoDecorrido = 0;

        while (tempoDecorrido < 1)
        {
            tempoDecorrido += Time.deltaTime * velocidadeDeTransicao;
            transform.position = Vector3.Lerp(posicaoInicial, posicaoFinal, tempoDecorrido);
            yield return null;
        }

        transform.position = posicaoFinal;
        resetandoPosicao = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Verifica se a colisão foi com o objeto desejado (Player)
        if (collision.gameObject.CompareTag("Finish"))
        {
            Time.timeScale = 0;
            // Ativa a UI
            uiCanvas.SetActive(true);
        }
    }
}
