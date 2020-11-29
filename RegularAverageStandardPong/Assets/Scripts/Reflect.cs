using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflect : MonoBehaviour
{
    public GameObject ball;
    public GameObject bonusBall;

    private void OnCollisionEnter(Collision collision)
    {
        float force = 0.000000000005f;
        ContactPoint redirection = collision.GetContact(0);
        Vector3 velocity = collision.rigidbody.velocity;

        if (redirection.point.x > transform.position.x)
        {
            Vector3 direction = new Vector3(0, 0, 2);
            collision.rigidbody.AddForce(direction * force, ForceMode.Impulse);
            collision.rigidbody.AddForce(velocity / 50, ForceMode.VelocityChange);

        }
        else if (redirection.point.x < transform.position.x)
        {
            Vector3 direction = new Vector3(0, 0, -2);
            collision.rigidbody.AddForce(direction * force, ForceMode.Impulse);
            collision.rigidbody.AddForce(velocity / 50, ForceMode.VelocityChange);
        }
    }
}
