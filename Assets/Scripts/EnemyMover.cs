using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class EnemyMover : MonoBehaviour
{
    [HideInInspector]public Vector3 target;

    private NavMeshAgent meshAgent;
    private void Start()
    {
        meshAgent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        meshAgent.destination = target;
        if (transform.position == meshAgent.destination)
        {
            Destroy(gameObject);
        }
    }
}
