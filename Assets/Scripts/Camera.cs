using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    private float dist = 3f;
    private float height = 10f;
    private float dampTrace = 20f;
    
    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position,
            target.position - (target.forward * dist) + (Vector3.up * height),
            Time.deltaTime * dampTrace);

        transform.LookAt(target.position);
        //transform.RotateAround(target.position, new Vector3(0,Input.GetAxis("Mouse X"),0)*Time.deltaTime * 0.2f, 10);
    }

}
