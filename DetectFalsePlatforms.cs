using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{
    bool hit;
    void Update()
    {
        hit = Physics.Raycast(transform.localPosition, transform.forward, 1.5f);
        Debug.DrawRay(transform.position, Vector3.forward * .15f, Color.red, 1 << 8);
        if (hit == true)
        {
            Debug.LogWarning("Be careful!");
        }

        else
        {
            Debug.Log("All clear!");
        }
        
    }   
}
