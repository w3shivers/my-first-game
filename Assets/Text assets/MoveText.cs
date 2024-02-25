using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveText : MonoBehaviour
{
    public GameObject TextObject;
    public float MoveSpeed = 1.5f;

    // Update is called once per frame
    void Update()
    {
        if (TextObject.transform.position.x <= -20)
            Destroy(TextObject);
        transform.position = transform.position + (Vector3.left * MoveSpeed) * Time.deltaTime;
    }
}
