using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Creature : MonoBehaviour
{

    protected float moveSpeed = 2.0f;

    protected float randomMoveTime = 0;

    protected float curMoveTime = 0;

    protected float Hp = 100.0f;

    private void Start()
    {
        randomMoveTime = Random.Range(0f,10.1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            Hp = Bullet.GiveDamage(Hp,Bullet.damage,Player.atk);
            Destroy(other.gameObject);
        }
    }
    private void Dead()
    {
        if(Hp <= 0.0f)
        {
            if(GameManager.isQuest == true)
                GameManager.curQuestkillCount++;
            GiveExp();
            Debug.Log(GameManager.curExp);
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        MoveTime();

        Dead();
    }

    protected abstract void Move();

    protected abstract void Turn();
    protected abstract void MoveTime();

    protected abstract void GiveExp();

}
