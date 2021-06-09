using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControlEnemigo : MonoBehaviour
{
    Transform posicionJugador;
    NavMeshAgent agente;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {   
        animator = GetComponent<Animator>();
        posicionJugador = GameObject.FindGameObjectWithTag("Jugador").transform;
        agente = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {   
        float val = posicionJugador.position.x - transform.position.x;
        float distancia = (val < 0)? val * -1 : val;
        if( val < 1.0f){
            Debug.Log("Distancia: " + val);
            animator.SetBool("run",true);
            agente.SetDestination(posicionJugador.position);
        } else {
             animator.SetBool("run",false);
        }
        

    }
}
