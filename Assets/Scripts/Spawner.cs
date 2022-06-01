using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private EnemyMover mobPrefab;
    [SerializeField] private Transform target;
    public void SpawnMob()
    {
        Instantiate(mobPrefab, transform).target = target.position;
    }
}
