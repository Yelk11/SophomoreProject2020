using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertObjects : MonoBehaviour
{

    public GameObject tree1, tree2, tree3, tree4, tree5;
    public float timer = 10f;
    public float initTime = 15f;
    public float randomVectorx;
    public float randomVectorz;
    public int item;
    Vector3 location;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > initTime)  //Initial check
        {
            // Choose one of 5 premade trees (tree is same visual object)
            item = Random.Range(1, 6);

            //Randomize X & Z values
            randomVectorx = Random.Range(-14f, 14f); 
            randomVectorz = Random.Range(-7f, 7f);

            //Set random location in a 3D Vector based off of random values above
            location = new Vector3(randomVectorx, 0, randomVectorz);

            //Make object appear randomly and as a clone of tree1
            Instantiate(tree1, location, Quaternion.identity);

            initTime = Time.time + timer;

        }
    }
}
        

