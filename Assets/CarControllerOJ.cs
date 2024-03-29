﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControllerOJ : MonoBehaviour
{
    public List<AxleInfo> axleInfos; // the information about each individual axle
    public float maxMotorTorque; // maximum torque the motor can apply to wheel
    public float maxSteeringAngle; // maximum steer angle the wheel can have

    //private ParticleSystem PS;

    /* private void Start() {
        PS = GetComponent<ParticleSystem>();
    }*/
    public void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.R)){
            transform.position = respawn.reachedPoint;
            transform.rotation = Quaternion.Euler(respawn.reachedPointRotation);
        }

        /* if (Input.GetKey(KeyCode.S)){
            PS.Play();
        }*/

        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");
            
        foreach (AxleInfo axleInfo in axleInfos) {
            if (axleInfo.steering) {
                axleInfo.leftWheel.steerAngle = steering;
                axleInfo.rightWheel.steerAngle = steering;
            }
            if (axleInfo.motor) {
                axleInfo.leftWheel.motorTorque = motor;
                axleInfo.rightWheel.motorTorque = motor;
            }
        }
    }
}
    
[System.Serializable]
public class AxleInfo {
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor; // is this wheel attached to motor?
    public bool steering; // does this wheel apply steer angle?
}
