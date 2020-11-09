using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code used from    https://answers.unity.com/questions/475893/how-to-set-velocity-on-a-single-axis-only.html
public class BallMovement : MonoBehaviour{
    public Vector3 initialImpulse;
    public GameObject ball;

    // Start is called before the first frame update
    void Start(){
        GetComponent<Rigidbody>().AddForce(initialImpulse, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = GetComponent<Rigidbody>().velocity;
        v.y = 0;
        ball.GetComponent<Rigidbody>().velocity = v;
    }
}
