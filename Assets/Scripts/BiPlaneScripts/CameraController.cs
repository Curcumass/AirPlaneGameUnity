using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _taargetPoint;
    private void Update()
    {
        MoveCamera();
    }

    private void MoveCamera()
    {
        transform.position = _taargetPoint.position;
    }
}
