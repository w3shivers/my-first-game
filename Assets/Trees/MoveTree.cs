using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTree : MonoBehaviour
{
    public GameObject TreeObject;
    public float MoveSpeed = 2f;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * MoveSpeed) * Time.deltaTime;
        if (transform.position.x <= -15)
            Destroy(TreeObject);
    }
}
