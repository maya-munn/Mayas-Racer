using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Dependency on input manager - script cannot function without this
[RequireComponent(typeof(InputManager))]
[RequireComponent(typeof(Rigidbody))]
public class CarController : MonoBehaviour
{
    public InputManager im;
    public List<WheelCollider> throttleWheels;
    public List<WheelCollider> steeringWheels;

    public float strengthCoefficient = 20000f;  //Torque
    public float maxTurn = 20f;                 //Degrees
    public Transform centreOfMass;              //Centre of mass
    public Rigidbody rigidBody;

    private void Start()
    {
        im = GetComponent<InputManager>();
        rigidBody = GetComponent<Rigidbody>();

        if (centreOfMass)
        {
            rigidBody.centerOfMass = centreOfMass.localPosition;
        }
    }

    //Meant for physics based process
    private void FixedUpdate()
    {
        foreach (WheelCollider wheel in throttleWheels)
        {
            wheel.motorTorque = strengthCoefficient * Time.deltaTime * im.throttle;
        }

        foreach (WheelCollider wheel in steeringWheels)
        {
            wheel.steerAngle = maxTurn * im.steer;
        }
    }
}