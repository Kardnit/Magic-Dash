using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    [SerializeField] public int enemyAmount = 0;
    [SerializeField] public float spawnDelay = 1;

    void Start()
    {
        StartCoroutine(SpawnOnTime());
    }


    public void SpawnPortal()
    {
        Vector3 portalPosition = transform.position;
        Quaternion enemRotation = transform.rotation;
        Instantiate(enemy, portalPosition, enemRotation);
    }

    private IEnumerator SpawnOnTime()
    {
        for (int i = 0; i < enemyAmount; i++)
        {
            SpawnPortal();
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
