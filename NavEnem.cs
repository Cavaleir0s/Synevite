using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class NavEnem : MonoBehaviour
{
    private NavMeshAgent inimigo; //para seguir o player
    private Transform point; // "player"
    public Animator anim;
    private bool podeAtk;

    // Start is called before the first frame update
    void Start()
    {
        podeAtk = true; // ele pode atacar
        inimigo = GetComponent<NavMeshAgent>(); //para usar o navMashgent
        point = GameObject.Find("PlayerArmature").transform;//faz com que o bot siga o player
    }

    // Update is called once perframe
    void Update()
    {
        inimigo.SetDestination(point.position); //usa o NMA para se mover até o player

        if (point.GetComponent<PStatus>().vida <= 0) //se a vida do player for menor ou igual a 0 ele não ´pode mais atacar
        {
            podeAtk = false;
        }
        else if (Vector3.Distance(transform.position, point.transform.position) <= 1) //se o bot estiver "proximo" do player ele ataca
        {
            Ataque();
        }
    }

    void Ataque()
    {
        if (podeAtk)//se ele puder atacar ele vai chamar a cortina de 2seg, para dar um intervalo entre os ataques
        {
            StartCoroutine("TempoDeAtaque");
            anim.SetBool("Attack", true);
            point.GetComponent<PStatus>().vida -= 5; 
        }
        else
        {
            anim.SetBool("Attack", false);
        }
    }

    IEnumerator TempoDeAtaque()
    {
        podeAtk = false;
        yield return new WaitForSeconds(2);
        podeAtk = true;
    }
}
