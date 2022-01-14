using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float moveSpeed = 30.0f;

    static public float damage = 100;

    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        Delete();
    }

    private void Delete()
    {
        if (transform.position.x >= 500 || transform.position.x <= -500)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z >= 500 || transform.position.z <= -500)
        {
            Destroy(gameObject);
        }
    }

    static public float GiveDamage(float hp,float Damage, float atk)
    {
        hp -= Damage * atk;
        return hp;
    }


}
