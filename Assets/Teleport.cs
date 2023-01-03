using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform TeleportTarget;
    public GameObject Player;
  
    

    
    void Update()
    {
        transform.Rotate(0, 45 * Time.deltaTime, 0);
    }

    public void teleport()
    {
        Player.transform.position = new Vector3(TeleportTarget.position.x, TeleportTarget.position.y + 2.52f, TeleportTarget.position.z);
    }
}
    