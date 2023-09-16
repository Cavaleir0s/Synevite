using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotStatus : MonoBehaviour
{
    public int vida = 100;

    private void Awake()
    {
        transform.tag = "Monstro";
    }

    // Update is called once per frame
    void Update()
    {
        if (vida <= 0)
        {
            vida = 0;
        }
    }
}
