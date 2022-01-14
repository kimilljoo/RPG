using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : Creature
{

    protected override void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
    protected override void Turn()
    {
        transform.Rotate(new Vector3(0, Random.Range(0f, 360.1f), 0f));
        randomMoveTime = Random.Range(0f, 10.1f);
        curMoveTime = 0.0f;
    }
    protected override void MoveTime()
    {
        curMoveTime += Time.deltaTime;
        if (curMoveTime <= randomMoveTime)
        {
            Move();
        }
        else
        {
            Invoke("Turn", 1.0f);
        }
    }
}
