using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int moveSpeed = 3;
    [SerializeField]
    private Animator animator;

    private bool isMove = true;

    private void Start()
    {
        animator= GetComponent<Animator>();
    }

    private void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.Fire"))
        {
            isMove = false;
        }
        else
            isMove = true;

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if(h != 0 || v != 0)
        {
            animator.SetBool("isWalk", true);
            
        }
        else
            animator.SetBool("isWalk", false);


        if(Input.GetMouseButtonDown(0))
        {
            animator.SetBool("isFire", true);
        }
        else
            animator.SetBool("isFire", false);
        
        
        if(isMove == true)
        {
            transform.Translate(h * Time.deltaTime * moveSpeed, 0, v * Time.deltaTime * moveSpeed);
        }

    }

}