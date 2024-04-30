using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectile : MonoBehaviour
{

    private bool collided;

    void OnCollisionEnter(Collision co)
    {
      if(co.gameObject.tag != "Bala" && co.gameObject.tag != "Player" && !collided)
      {
        collided = true;
        Destroy(gameObject);
      }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
