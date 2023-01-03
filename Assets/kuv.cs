using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kuv : MonoBehaviour
{
    Rigidbody fizik;

    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        fizik.AddForce(Vector3.forward*500);
    }
   



}
