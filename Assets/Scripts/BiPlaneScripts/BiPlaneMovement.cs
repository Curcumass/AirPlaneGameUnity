using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiPlaneMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed;
    [SerializeField] private float _constantSpeed;
    [SerializeField] private float _torgueForce;
    private void FixedUpdate()
    {
        _rigidbody.AddForce(transform.forward * _constantSpeed, ForceMode.VelocityChange);

        if (Input.GetKey(KeyCode.W))
        {
            MoveBiplane();
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        RotateBiPlane(horizontalInput);
    }

    private void MoveBiplane()
    {
        _rigidbody.AddForce(transform.forward * _speed, ForceMode.VelocityChange);
    }

    private void RotateBiPlane(float horizontal)
    {
        _rigidbody.AddTorque(transform.right * _torgueForce * horizontal, ForceMode.VelocityChange);
    }


}
