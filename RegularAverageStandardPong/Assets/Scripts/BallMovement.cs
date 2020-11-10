using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour{
    public Vector3 initialImpulse;

    public Text scoreBoard;
    public int p1Score = 0;
    public int p2Score = 0;
    public float speedlimit = .00000000005f;
    public GameObject ball;

    // Start is called before the first frame update
    void Start(){
        GetComponent<Rigidbody>().AddForce(initialImpulse, ForceMode.Impulse);
    
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Wall 4")
        {
            
            p1Score++;
        }else if(collision.gameObject.name == "Wall 3")
        {
            
            p2Score++;
        }
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        scoreBoard.text = p1Score + "|" + p2Score;

        Vector3 v = GetComponent<Rigidbody>().velocity;
        v.y = 0;
        ball.GetComponent<Rigidbody>().velocity = v;

        if (GetComponent<Rigidbody>().velocity.magnitude > speedlimit)
        {
            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * speedlimit;
        }
    }
}
