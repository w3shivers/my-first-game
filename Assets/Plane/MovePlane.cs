using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlane : MonoBehaviour
{
    public float MinSpeed = 2;
    public float MaxSpeed = 5;
    private float MoveSpeed;
    public GameObject planeObject;

    // Start is called before the first frame update
    void Start()
    {
        MoveSpeed = Random.Range(MinSpeed, MaxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * MoveSpeed) * Time.deltaTime;
        if (transform.position.x <= -15)
            Destroy(planeObject);
    }
}
