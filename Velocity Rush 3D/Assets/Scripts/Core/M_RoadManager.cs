using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_RoadManager : MonoBehaviour
{
    public GameObject[] roadPrefabs;

    private Transform playerTransform;

    private float spawnZ = 0.0f;
    private float roadLength = 50f;
    private int amnRoadOnScreen = 5;
    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for (int i = 0; i < amnRoadOnScreen; i++)
        {
            SpawnRoad();
        }
    }
    private void Update()
    {
        if (playerTransform.position.z > (spawnZ - (amnRoadOnScreen * roadLength)))
        {
            SpawnRoad();
        }
    }

    private void SpawnRoad(int prefabIndex = -1)
    {
        GameObject go;
        go = Instantiate(roadPrefabs[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += roadLength;
    }
}
