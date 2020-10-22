using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class RayPlayer : MonoBehaviour
{

    public Transform Pointer;
    public Ray ray;
    public void LateUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(transform.position, transform.forward * 100, Color.red);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Pointer.position = hit.point;

            }
        }

    }
}
