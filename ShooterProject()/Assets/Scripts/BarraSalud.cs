using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BarraSalud : MonoBehaviour
{


    public Image barraDeVida;
    public float vidaActual;
    public float vidaMax;
    public float dañoEnemigo;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy") 
        {
            vidaActual = vidaActual - dañoEnemigo;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        vidaActual = 100;
        vidaMax = 100;
    }

    // Update is called once per frame
    void Update()
    {
        barraDeVida.fillAmount = vidaActual / vidaMax;
        Muerte();
    }


    void Muerte() 
    { 
    if(vidaActual <= 0) 
        {
            SceneManager.LoadScene("Muerte");
        }
    
    }
}
