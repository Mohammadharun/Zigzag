using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    public Vector3 cameraOffset;

    public float smoothFactor = 0.4f;

    private void Start()
    {
        cameraOffset = transform.position - target.transform.position;
    }

    private void LateUpdate()
    {
        Vector3 newpos = target.transform.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newpos, smoothFactor);
    }
}
