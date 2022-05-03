using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawnPoint : MonoBehaviour
{
    public Transform enemyTransform;

    private void Update()
    {
        transform.position = enemyTransform.position;
    }
}
