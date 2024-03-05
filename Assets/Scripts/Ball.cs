using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float jumpSpeed;
    [SerializeField] private GameObject paintSplashParticle;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            rb.AddForce(Vector3.up * jumpSpeed * Time.deltaTime, ForceMode.Impulse);
            GameObject splashParticle = Instantiate(paintSplashParticle, transform.position, paintSplashParticle.gameObject.transform.rotation);
            // Add as a child to the collided object:
            splashParticle.transform.parent = collision.transform;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
