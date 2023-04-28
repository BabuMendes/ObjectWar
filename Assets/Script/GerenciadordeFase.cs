using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadordeFase : MonoBehaviour
{
    public int faseAtual;
    public GameObject PanelVitoria;

    private void Start()
    {
        if (faseAtual > 0 && faseAtual < 4)
        {
            PlayerPrefs.SetInt("FASE", faseAtual);
        }

    }

    public void Fase(int numeroFase)
    {
        SceneManager.LoadScene(numeroFase);
    }



    public void PassarFase()
    {
        if(faseAtual == 2)
        {
            PanelVitoria.SetActive(true);
        }
        else
        {
            int pFase = faseAtual + 1;
            SceneManager.LoadScene(pFase);
        }
        
    }

    public void IrParaFase2()
    {
        int fSave = PlayerPrefs.GetInt("FASE");
        SceneManager.LoadScene(fSave);
    }

}