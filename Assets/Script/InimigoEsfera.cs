using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class InimigoEsfera : MonoBehaviour
{

    public int hp = 1;
    public GameObject player;
    private NavMeshAgent navMesh;

    private void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        navMesh.SetDestination(player.transform.position);
    }

    private void OnTriggerEnter(Collider colidiu)
    {
        if (colidiu.gameObject.tag == "Bala")
        {
            TomeiDano();
        }
    }

    public void TomeiDano()
    {
        hp--;
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}