using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public GameObject ball;
    public GameObject paddle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 position = this.transform.position;

        if (Input.GetKey(KeyCode.S))
        {
            if (position.z > -7.5f)
            {
                position.z -= 0.18f;
                this.transform.position = position;
            }
        }else if (Input.GetKey(KeyCode.W))
        {
            if (position.z < 7f)
            {
                position.z += 0.18f;
                this.transform.position = position;
            }
        }
        else if(MainMenuScript.gameType) // Enables CPU
        {
            position.z = ball.transform.position.z;
            this.transform.position = position;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        float force = 0.000000000005f;
        ContactPoint redirection = collision.GetContact(0);
        Vector3 velocity = collision.rigidbody.velocity;

        if (redirection.point.x > transform.position.x)
        {
            Vector3 direction = new Vector3(0, 0, 2);
            collision.rigidbody.AddForce(direction * force, ForceMode.Impulse);
            collision.rigidbody.AddForce(velocity / 20, ForceMode.VelocityChange);

        }
        else if (redirection.point.x < transform.position.x)
        {
            Vector3 direction = new Vector3(0, 0, -2);
            collision.rigidbody.AddForce(direction * force, ForceMode.Impulse);
            collision.rigidbody.AddForce(velocity / 20, ForceMode.VelocityChange);
        }
    }


}
