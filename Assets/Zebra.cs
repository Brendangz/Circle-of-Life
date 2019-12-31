using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zebra : MonoBehaviour
{
    [SerializeField] float turnSpeed = 100f;
    [SerializeField] float walkSpeed = 100f;

    Rigidbody rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Turn();
        WalkDirection();
    }

    private void Turn()
    {
        rigidBody.freezeRotation = true;

        float rotationThisFrame = turnSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * rotationThisFrame);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.down * rotationThisFrame);
        }

        rigidBody.freezeRotation = false;
    }

    private void WalkDirection()
    {

        if (Input.GetKey(KeyCode.W))
        {
            float thrustThisFrame = walkSpeed * Time.deltaTime;

            transform.position -= transform.forward * thrustThisFrame;
            
        }
        else if(Input.GetKey(KeyCode.S))
        { 
            float thrustThisFrame = walkSpeed * Time.deltaTime;

            transform.position += transform.forward * thrustThisFrame;
        }
        
    }
}
