using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int defeatedEnemies;
    public int vida;
    public int monedas;
    public int balas;






    // Start is called before the first frame update
    void Start()
    {
        defeatedEnemies = 0;
        vida = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(vida < 1) 
        {
            GameOver();
        }
    }

    void GameOver()
    {

    }
}
