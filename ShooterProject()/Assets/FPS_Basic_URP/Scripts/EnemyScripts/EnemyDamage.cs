using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [Header("Damage Configuration")]
    [SerializeField] float health;
    [SerializeField] float maxHealth;

    [Header("Feedback System")]
    [SerializeField] Material original;
    [SerializeField] Material damaged;
    [SerializeField] float feedbackTime;
    [SerializeField] GameObject deathEffect;
    GameObject model; //Ref al objeto que contiene el mesh del personaje (solo en caso de que el mesh vaya aparte del c�digo)
    MeshRenderer modelRend; //Ref al meshRenderer del objeto con modelado (permite acceder a su material)

    // Start is called before the first frame update
    void Start()
    {
        model = GameObject.Find("Body");
        modelRend = model.GetComponent<MeshRenderer>();
        original = modelRend.material;
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        HealthManagement();
    }

    void HealthManagement()
    {
        if (health <= 0) 
        {
            deathEffect.SetActive(true);
            deathEffect.transform.position = transform.position;
            Destroy(gameObject); 
        }
    }

    public void TakeDamage(int damageToTake)
    {
        //Aqu� cabe codear cualquier efecto de recibir da�o que se desee
        modelRend.material = damaged; //FEEDBACK DE RECIBIR DA�O (EN ESTE CASO CAMBIO DE COLOR)
        health -= damageToTake;
        Invoke(nameof(ResetMaterial), feedbackTime);
    }

    void ResetMaterial()
    {
        modelRend.material = original;
    }
}
