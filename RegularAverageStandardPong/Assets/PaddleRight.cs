﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleRight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;

            if (position.z > -4.8f)
            {
                position.z -= 0.18f;
                this.transform.position = position;
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;

            if (position.z < 4.8f)
            {
                position.z += 0.18f;
                this.transform.position = position;
            }
        }
    }
}