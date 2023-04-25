using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour
{
    public GameObject PontoDeSaida;
    public GameObject Bala;
    public int limiteMunicao;
    public int municao = 300000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (municao > 0)
            {
                municao--;

                GameObject Disparo = Instantiate(Bala, PontoDeSaida.transform.position, Quaternion.identity);
                Disparo.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                Destroy(Disparo, 2f);
            }
        }
    }
}
