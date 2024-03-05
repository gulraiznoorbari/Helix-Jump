using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleController : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private void FixedUpdate()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector3 rotation = Input.GetTouch(0).deltaPosition;
            transform.Rotate(0, rotation.x * _rotationSpeed * Time.deltaTime, 0);
        }
    }
}
