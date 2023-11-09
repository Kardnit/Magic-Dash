using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpawn : MonoBehaviour
{
    public Transform[] portalSpawnPoints;
    private int spawnedPortals;
    public GameObject portal;
    [SerializeField] int portalAmount = 1;

    void Start()
    {
        SpawnPortal();
    }

    public void SpawnPortal()
    {
        while (spawnedPortals != portalAmount)
        {
            foreach (var portalPoint in portalSpawnPoints)
            {
                int rnd = Random.Range(0, 5);
                Debug.Log(rnd);
                
                if (rnd == 1)
                {
                    Instantiate(portal, portalPoint);
                    Debug.Log(portalPoint.name);
                    spawnedPortals++;
                }

                if (spawnedPortals == portalAmount)
                {
                    break;
                }
            }
        }
    }

    private IEnumerator SpawnOnTime(float waitTime)
    {
        for (int i = 0; i < portalAmount; i++)
        {
            SpawnPortal();
            yield return new WaitForSeconds(waitTime);
        }
    }
}
