using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    private Transform cam;

    void Start()
    {
        cam = CameraManager.nowCamTransform;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.LookAt(transform.position + cam.rotation * Vector3.forward, cam.rotation * Vector3.up);

    }

}
