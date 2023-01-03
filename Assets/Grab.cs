using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public GameObject ball;
    public GameObject myhand;
    public float throwforce;

    bool inHands= false;
    //Vector3 ballposition;
    Collider ballcal;
    Rigidbody ballrb;
    Camera cam;

    void Start()
    {
       // ballposition = ball.transform.position;
        ballcal = ball.GetComponent<SphereCollider>();
        ballrb = ball.GetComponent<Rigidbody>();
        cam = GetComponentInChildren<Camera>();
    }
    public void grab()
    {
        if (!inHands /*&& myhand.GetComponent<DistanceOfHands>().canGrab*/)
        {
            ballcal.isTrigger = true;
            ballrb.useGravity = false;
            ball.transform.SetParent(myhand.transform);
            ball.transform.localPosition = new Vector3(0, 1f, 0);
            ballrb.velocity = Vector3.zero;
            inHands = true;
        }
        else if (inHands)
        {
            ballcal.isTrigger = false;
            ballrb.useGravity = true;
            ball.transform.SetParent(null);
            ballrb.velocity = cam.transform.rotation * Vector3.forward * throwforce;
            this.GetComponent<gravity>().enabled = false;
            
            //ball.transform.position = new Vector3(ball.transform.position.x, ballposition.y, ball.transform.position.z );
            // ball.transform.position = Vector3.Lerp(ball.transform.position, ball.transform.localPosition, 0.1f);
            inHands = false;
        }
    }
   

    //void Update()
    //{
    //    if (Input.GetButtonDown("Fire1"))
    //    {
    //        if (!inHands)
    //        {
    //            ball.transform.SetParent(myhand.transform);
    //            ball.transform.localPosition = new Vector3(0, 0.67f, 0);
    //            inHands = true;
    //        }
    //        else if (inHands)
    //        {
    //            this.GetComponent<Grab>().enabled = false;
    //            ball.transform.SetParent(null);
    //            ball.transform.position = ballposition;
    //            inHands = false;

    //        }

    //    }
    //}
    
}
