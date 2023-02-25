using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsManager : MonoBehaviour
{
    public GameObject bananaPrefab;
    public Transform[] spawnPoints;

    public void SpawnItems()
    {
        for(int i=0; i < spawnPoints.Length;i++)
        {
            Instantiate(bananaPrefab, spawnPoints[i].position, Quaternion.identity);
        }
    }

}
