using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private GameObject magic;
    [SerializeField]
    private GameObject shootingPoint;

    private float Hp = 100f;

    static public float atk = 1f;

    private float moveSpeed = 4f;

    public bool isMove = true;
    private bool isTrigger = false;

    private float h;
    private float v;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Update()
    {
        Rotate();
        Fire();
        
    }

    private void Move()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        if(isMove == true)
        {
            transform.Translate(new Vector3(h,0,v) * Time.deltaTime * moveSpeed);
        }

        if (h != 0 || v != 0)
        {
            animator.SetBool("isWalk", true);

        }
        else
            animator.SetBool("isWalk", false);

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.Fire"))
        {
            isMove = false;
        }
        else
            isMove = true;

    }

    private void Rotate()
    {
        if(isMove == true)
        {
            transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0));
        }

    }

    private void Fire()
    {
        if (Input.GetMouseButtonDown(1) && (animator.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.Walk") || animator.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.Idle")))
        {
            isTrigger = false;
            animator.SetBool("isFire", true);

        }
        else
            animator.SetBool("isFire", false);

        if ((animator.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.Fire") && animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.7f) && isTrigger == false)
        {
            Instantiate(magic, shootingPoint.transform.position, transform.rotation);
            isTrigger = true;
        }
    }


}