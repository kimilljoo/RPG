using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    static public bool isCursor = false;

    
    private void Update()
    {
        if(isCursor == false)
        {
            Cursor.lockState = CursorLockMode.Locked;    
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;    
        }
        Cursor.visible = isCursor;
    }
}
