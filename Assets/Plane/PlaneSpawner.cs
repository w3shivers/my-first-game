using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class PlaneSpawner : MonoBehaviour
{
    public GameObject PlaneSpawnerObject;
    public GameObject PlaneObject;
    public float MinSpawnRate = 2;
    public float MaxSpawnRate = 5;
    public float LowestPoint = 0;
    public float HighestPoint = 1;
    private float SpawnRate = 0;
    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        if(timer < SpawnRate)
        {
            timer += Time.deltaTime;
            return;
        }
        SpawnRate = Random.Range(MinSpawnRate, MaxSpawnRate);
        timer = 0;
        SpawnPlane();
    }

    private void SpawnPlane()
    {
        var spawnPostion = new Vector3(PlaneSpawnerObject.transform.position.x, Random.Range(LowestPoint, HighestPoint), PlaneSpawnerObject.transform.position.z);
        Instantiate(PlaneObject, spawnPostion, transform.rotation);
    }
}
