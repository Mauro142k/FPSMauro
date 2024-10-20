using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour
{


public Image barraDeMana;
public GameObject bala;
public float manaMax;
public float manaActual;
public float manaRecoveryRate = 0.1f;

public Transform spawnPoint;

public float shotForce = 1500;
public float shotRate = 0.5f;

private float shotRateTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(tiempo());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(manaActual);
        if (manaActual < manaMax && Time.time > manaRecoveryRate)
        {
            Debug.Log("Está recuperando");
            manaActual += 0.5f;
            manaRecoveryRate = Time.time + manaRecoveryRate;
        }
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && manaActual > 0)
        {
            manaActual = manaActual - 10;
            barraDeMana.fillAmount = manaActual / manaMax;

            if (Time.time > shotRateTime)
            {
                GameObject newBala;

                newBala = Instantiate(bala, spawnPoint.position, spawnPoint.rotation);

                newBala.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);

                shotRateTime = Time.time + shotRate;

                Destroy(newBala, 2);


            }


        }
    }

    IEnumerator tiempo()
    {
      while(true)
      {
       yield return new WaitForSeconds(0.1f);
       if(manaActual < 100)
       {
        manaActual += 0.5f;
       }
      }
    }
}
