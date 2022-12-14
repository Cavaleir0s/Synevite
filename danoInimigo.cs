using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class danoInimigo : MonoBehaviour
{
    public int dano;

    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            Player.GetComponent<vida>().VidaPlayer -= dano;
        }

        if(other.tag == "inimigo")
        {
            Debug.Log("esse é o inimigo");
        }



    }

}
