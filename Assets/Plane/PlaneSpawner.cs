using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class PlaneSpawner : GameStatus
{
    public GameObject PlaneSpawnerObject;
    public GameObject PlaneObject;
    public float MinSpawnRate = 2;
    public float MaxSpawnRate = 5;
    public float LowestPoint = 0;
    public float HighestPoint = 1;
    private float SpawnRate = 0;
    private float timer = 0;
    public int DecreaseSpawnRate = 40;

    // Update is called once per frame
    void Update()
    {
        if(timer < SpawnRate)
        {
            timer += Time.deltaTime;
            return;
        }
        float minimum = 1;
        float maximum = 1.2f;
        if ( MinSpawnRate > minimum)
            MinSpawnRate = DecreaseRate(MinSpawnRate);
        else
            MinSpawnRate = minimum;
        if (MaxSpawnRate > maximum)
            MaxSpawnRate = DecreaseRate(MaxSpawnRate);
        else
            MaxSpawnRate = maximum;

        SpawnRate = Random.Range(MinSpawnRate, MaxSpawnRate);
        timer = 0;
        SpawnPlane();
    }

    private float DecreaseRate(float currentValue)
    {
        float decreaseRate = 0;
        if (this.GameTime != 0)
            decreaseRate = (float)this.GameTime / DecreaseSpawnRate;
        return currentValue - decreaseRate;
    }

    private void SpawnPlane()
    {
        var spawnPostion = new Vector3(PlaneSpawnerObject.transform.position.x, Random.Range(LowestPoint, HighestPoint), PlaneSpawnerObject.transform.position.z);
        Instantiate(PlaneObject, spawnPostion, transform.rotation);
    }
}
