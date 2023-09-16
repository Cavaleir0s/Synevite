using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barradevida : MonoBehaviour
{

    public Image barra;

    public float vidaAtual;

    public float vidaMax;

    

    // Update is called once per frame
    void Update()
    {
        barra.fillAmount = vidaAtual / vidaMax;

       
    }
}
