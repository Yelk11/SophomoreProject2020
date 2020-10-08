using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            if (position.z > -38.5f) { 
                position.z -= 1f;
                this.transform.position = position;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            if (position.z < 38.5f) { 
                position.z += 1f;
                this.transform.position = position;
            }
        }
    }
}
