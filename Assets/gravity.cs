using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    public GravityOrbit Gravity;
    private Rigidbody rb;

    public float rotationspeed = 20;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        if (Gravity)
        {

            Vector3 gravityUp = Vector3.zero;

            gravityUp = (transform.position - Gravity.transform.position).normalized;

            Vector3 localUp = transform.up;

            Quaternion targerrotation = Quaternion.FromToRotation(localUp, gravityUp) * transform.rotation;

            transform.up = Vector3.Lerp(transform.up, gravityUp, rotationspeed * Time.deltaTime);

            rb.AddForce((-gravityUp * Gravity.Gravity) * rb.mass);


        }
    }
}
