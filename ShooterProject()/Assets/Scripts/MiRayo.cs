using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiRayo : MonoBehaviour
{

    public Transform final;

    public int cantidadDePuntos;

    public float dispersion;
    public float frecuencia;

    private LineRenderer line;
    private float tiempo = 0;


    // Start is called before the first frame update
    void Start()
    {
        line = GetLine();
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        if(tiempo > frecuencia) 
        {
            ActualizarPuntos(this.line);
        }
    }

    private LineRenderer GetLine() 
    {
      return GetComponent<LineRenderer>();
    }

    private void ActualizarPuntos(LineRenderer line) 
    {
        List<Vector3> puntos = InterpolarPuntos(Vector3.zero, final.localPosition, cantidadDePuntos);
        line.positionCount = puntos.Count;
        line.SetPositions(puntos.ToArray());
    }

    private List<Vector3> InterpolarPuntos(Vector3 principio, Vector3 final, int totalPoints) 
    {
      List<Vector3> list = new List<Vector3>();
        
      for(int i = 0; i < totalPoints; i++) 
        {
            list.Add(Vector3.Lerp(principio, final, (float)i / totalPoints) + DesfaseAleatorio());
        }

        return list;
    }

    private Vector3 DesfaseAleatorio() 
    {
        return Random.insideUnitSphere.normalized * Random.Range(0, dispersion);
    }


    }



