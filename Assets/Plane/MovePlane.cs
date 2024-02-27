using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlane : GameStatus
{
    public float MinSpeed = 2;
    public float MaxSpeed = 5;
    public int IncreaseSpeed = 20;
    private float MoveSpeed;
    public GameObject planeObject;

    private void Start()
    {
        float increaseSpeed = 0;
        if (this.GameTime != 0)
            increaseSpeed = (float)this.GameTime / IncreaseSpeed;
        MoveSpeed = Random.Range(MinSpeed + increaseSpeed, MaxSpeed + increaseSpeed);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * MoveSpeed) * Time.deltaTime;
        if (transform.position.x <= -15)
            Destroy(planeObject);
    }
}
