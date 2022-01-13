using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float moveSpeed = 10.0f;


    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }

}
