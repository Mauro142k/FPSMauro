using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{

    public float vida;
    NavMeshAgent agente;
    public Transform target;


    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(vida <= 0)
        {
          Destroy(gameObject);
;        }
        agente.destination = target.position;
        
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bala") 
        {
            vida = vida - 40
                ;
        }
    }

     
}
