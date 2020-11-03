using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour{
    public Vector3 initialImpulse;
    public Rigidbody ballBody;
    public float timing = 0.5f;
    

    public Text scoreBoard;
    public int p1Score = 0;
    public int p2Score = 0;
    // Start is called before the first frame update
    void Start(){
        ballBody = GetComponent<Rigidbody>();
        ballBody.AddForce(initialImpulse, ForceMode.Impulse);
        ballBody.AddForce(initialImpulse, ForceMode.Impulse);
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
        

        


    }
}
