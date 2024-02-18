using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BackgroundSpawn : MonoBehaviour
{
    public GameObject BackgroundObject;
    private bool hasSpawnedNext = false;
    public 

    // Start is called before the first frame update
    void Start()
    {
        BackgroundObject.name = "Background Object"; // Rename for cloned items
        SpanNewBackground();
    }

    // Update is called once per frame
    void Update()
    {
        SpanNewBackground();
    }

    void SpanNewBackground()
    {
        if (BackgroundObject.transform.position.x <= 0 && !hasSpawnedNext)
        {
            hasSpawnedNext = true;
            var position = new Vector3((float) 69.5, BackgroundObject.transform.position.y, 0);
            Instantiate(BackgroundObject, position, transform.rotation);
        }
        else if (BackgroundObject.transform.position.x <= -80 && hasSpawnedNext)
        {
            Destroy(BackgroundObject);
        }
    }
}
