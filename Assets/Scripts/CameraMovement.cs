using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform ball;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float positionOffset;
    [SerializeField] private float smoothDamp;

    private Vector3 currentVelocity;

    private void FixedUpdate()
    {
        Vector3 targetPosition = ball.position + offset;
        if (ball.position.y < transform.position.y + positionOffset)
        {
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref currentVelocity, smoothDamp);
        }

    }
}
