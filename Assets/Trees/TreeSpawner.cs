using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TreeSpawner : MonoBehaviour
{
    public GameObject SpawnerObject;
    public GameObject[] SpawnObjects;
    public float SpawnRate = 5;
    private Vector3 ParentPosition;
    private float timer = 0;    
    
    // Start is called before the first frame update
    void Start()
    {
        ParentPosition = SpawnerObject.transform.position;
        SpawnTree();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SpawnRate)
        {
            timer += Time.deltaTime;
            return;
        }
        timer = 0;
        SpawnTree();
    }

    private void SpawnTree()
    {
        var NewGameObject = SpawnObjects[Random.Range(0, SpawnObjects.Length)];
        Instantiate(NewGameObject, ParentPosition, transform.rotation);
    }
}
