using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour{
    public Vector3 initialImpulse;
    public Text scoreText;
    public int p1Score = 0;
    public int p2Score = 0;
    



    void Start(){
        GetComponent<Rigidbody>().AddForce(initialImpulse, ForceMode.Impulse);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Wall 4")
        {
            p1Score++;
        }else if(collision.gameObject.name == "Wall 3")
        {
            p2Score++;
        }
    }


    // Update is called once per frame
    void Update()
    {
        scoreText.text = p1Score + "|" + p2Score;
    }
}
