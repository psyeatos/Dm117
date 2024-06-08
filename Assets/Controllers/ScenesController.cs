using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesController : MonoBehaviour
{
    public void CarregarCena()
    {
        SceneManager.LoadSceneAsync("Cena 2");
    }

    public void FecharJogo()
    {
#if UNITY_EDITOR
        // Se estiver rodando no editor do Unity, parar o modo de jogo
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Se estiver rodando em uma build standalone, fechar o jogo
        Application.Quit();
#endif
    }

    public void ReiniciarCena()
    {
        // Obtém a cena atual
        Scene cenaAtual = SceneManager.GetActiveScene();
        // Recarrega a cena atual
        SceneManager.LoadScene(cenaAtual.name);
        Time.timeScale = 1;
    }
}
