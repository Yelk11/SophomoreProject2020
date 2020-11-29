using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour{
    public Vector3 initialImpulse;

    public GameObject ball;
    public GameObject p1Score;
    public GameObject p2Score;

    // Start is called before the first frame update
    void Start(){
        GetComponent<Rigidbody>().AddForce(initialImpulse, ForceMode.Impulse);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Wall 4")
        {
            Debug.Log("Ball Hit Wall 4");
            p1Score.transform.position += new Vector3(0, 1, 0);
        }
        else if (collision.gameObject.name == "Wall 3")
        {
            Debug.Log("Ball Hit Wall 3");
            p2Score.transform.position += new Vector3(0, 1, 0);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 v = GetComponent<Rigidbody>().velocity;
        v.y = 0;
        ball.GetComponent<Rigidbody>().velocity = v;

        if (v.x > 15)
        {
            ball.GetComponent<Rigidbody>().velocity = new Vector3(15, 0, v.z);
        }

        if (v.z > 15)
        {
            ball.GetComponent<Rigidbody>().velocity = new Vector3(v.x, 0, 15);
        }

        /*if (GetComponent<Rigidbody>().velocity.magnitude > speedlimit)
        {
            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * speedlimit;

            if (GetComponent<Rigidbody>().velocity.magnitude > speedlimit)
            {
                GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * speedlimit;
            }
        */
    }
}
