using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code used from    https://answers.unity.com/questions/805594/how-do-i-change-an-objects-scale-in-code.html
//                  https://answers.unity.com/questions/577132/random-position-for-gameobject.html
//                  https://stackoverflow.com/questions/52338632/make-an-object-disappear-from-another-object-in-unity-c-sharp#:~:text=Find(%22ObjectToDisappearName%22)%3B,inside%20your%20collision%20detection%20method.
public class PowerUpScript : MonoBehaviour
{
    public GameObject powerUp;
    public GameObject ball;
    public GameObject rPaddle;
    public GameObject lPaddle;
    public GameObject lastHit;

    private IEnumerator OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "PaddleRight")
        {
            lastHit = rPaddle;
        }

        if (col.gameObject.name == "Paddle")
        {
            lastHit = lPaddle;
        }

        if (col.gameObject.name == "Ball")
        {
            float x;
            float y;
            float z;
            Vector3 pos;

            powerUp.GetComponent<Renderer>().enabled = false;
            powerUp.GetComponent<Collider>().enabled = false;
            lastHit.transform.localScale += new Vector3(0, 0, 1);

            //Waits for 20 seconds after the power up has been hit to return to original size.
            yield return new WaitForSeconds(20f);
            lastHit.transform.localScale += new Vector3(0, 0, -1);

            while(true)
            {
                yield return new WaitForSeconds(20f);

                x = Random.Range(-13, 13);
                y = 0.75f;
                z = Random.Range(-4, 4);
                pos = new Vector3(x, y, z);
                powerUp.transform.position = pos;
                powerUp.GetComponent<Renderer>().enabled = true;
                powerUp.GetComponent<Collider>().enabled = true;
            }

        }
    }
}
