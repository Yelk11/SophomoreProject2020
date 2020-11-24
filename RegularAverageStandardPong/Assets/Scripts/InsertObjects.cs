using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertObjects : MonoBehaviour
{

    public GameObject tree1, tree2, tree3, tree4, tree5;
    public float timer = 10f;
    public float initTime = 0f;
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
        if (Time.time > initTime)
        {
            item = Random.Range(1, 6);
            randomVectorx = Random.Range(-14f, 14f);
            randomVectorz = Random.Range(-7f, 7f);
            location = new Vector3(randomVectorx, 0, randomVectorz);
            switch (item)
            {
                case 1:
                    Instantiate(tree1, location, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(tree2, location, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(tree3, location, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(tree4, location, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(tree5, location, Quaternion.identity);
                    break;
                case 6:
                    Instantiate(tree1, location, Quaternion.identity);
                    break;
                case 7:
                    Instantiate(tree2, location, Quaternion.identity);
                    break;
                case 8:
                    Instantiate(tree3, location, Quaternion.identity);
                    break;
                case 9:
                    Instantiate(tree4, location, Quaternion.identity);
                    break;
                case 10:
                    Instantiate(tree5, location, Quaternion.identity);
                    break;
            }
            initTime = Time.time + timer;

        }
    }
}
        

