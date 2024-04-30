using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{


    public void Inicio() 
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Exit() 
    {
        Application.Quit();
    }

    public void Menu() 
    {
        SceneManager.LoadScene("Menu");
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
