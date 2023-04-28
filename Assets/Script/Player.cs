using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    private NavMeshAgent Agente;
    private Vector3 Destino;
    public float hp = 5;
    public bool vivo = true;

    // Start is called before the first frame update
    void Start()
    {
        Destino = new Vector3(0, 0, 0);
        Agente = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousepoint = Input.mousePosition;
            Ray pontodesaida = Camera.main.ScreenPointToRay(mousepoint);
            RaycastHit localTocou;
            if (Physics.Raycast(pontodesaida, out localTocou, Mathf.Infinity))
            {
                Destino = localTocou.point;
            }
        }



        Agente.SetDestination(Destino);
    }

    private void OnTriggerEnter(Collider colidiu)
    {
        if (colidiu.gameObject.tag == "Inimigo")
        {
            if (vivo == true)
            {
                hp--;
                //ControlAnim.SetTrigger("TomouDano");
                if (hp <= 0)
                {

                    Destroy(this.gameObject);
                }
            }

        }

    }
}
