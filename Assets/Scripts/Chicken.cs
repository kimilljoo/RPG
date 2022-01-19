using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Creature
{
    protected float exp = 2;
    private void Start()
    {
        Turn();
    }
    protected override void GiveExp()
    {
        GameManager.curExp += exp;
    }

    protected override void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }

    protected override void MoveTime()
    {
        Move();
    }
    protected override void Turn()
    {
        transform.Rotate(new Vector3(0, 180, 0));
    }

}
