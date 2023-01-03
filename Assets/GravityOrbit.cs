using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityOrbit : MonoBehaviour
{

    public float Gravity;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<gravity>())
        {
            other.GetComponent<gravity>().Gravity = this.GetComponent<GravityOrbit>();
        }

    }


}