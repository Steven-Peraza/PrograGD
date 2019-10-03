using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraWin : MonoBehaviour
{
    
    private GameObject referencePoint, winner;
    private Vector3 velocity = Vector3.zero;
    private float smoothTime = 1.0F;
    // Update is called once per frame
    void Update()
    {
        if (FallingTiles.gameOuva) {
            referencePoint = GameObject.FindGameObjectWithTag("cameraGG");
            winner = GameObject.FindGameObjectWithTag("Player");

            transform.position = Vector3.SmoothDamp(transform.position, referencePoint.transform.position, ref velocity, smoothTime);

            transform.LookAt(winner.transform);
        }
    }
}
