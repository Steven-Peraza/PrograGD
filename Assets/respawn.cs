using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class respawn : MonoBehaviour
{
    public static Vector3 reachedPoint = new Vector3();
    public static Vector3 reachedPointRotation = new Vector3();
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            reachedPoint = transform.position;
            reachedPointRotation = transform.rotation.eulerAngles;
        }
            
    }
}

