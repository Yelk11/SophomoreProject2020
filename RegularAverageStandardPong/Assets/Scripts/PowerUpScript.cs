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
    public GameObject bonusBall;
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

        if (col.gameObject.name == "Ball" || col.gameObject.name == "BonusBall")
        {
            float x;
            float y;
            float z;
            int choose;
            Vector3 pos;

            powerUp.GetComponent<Renderer>().enabled = false;
            powerUp.GetComponent<Collider>().enabled = false;

            choose = Random.Range(1, 4);

            //Increases last-hit paddle size.
            if (choose == 1)
            {
                lastHit.transform.localScale += new Vector3(0, 0, 1);

                //Waits for 30 seconds after the power up has been hit to return to original size.
                yield return new WaitForSeconds(30f);
                lastHit.transform.localScale += new Vector3(0, 0, -1);

            //Increases ball size.
            } else if (choose == 2)
            {
                ball.transform.localScale += new Vector3(1, 1, 1);

                //Waits for 20 seconds after the power up has been hit to return ball to original size.
                yield return new WaitForSeconds(20f);
                ball.transform.localScale += new Vector3(-1, -1, -1);
            //Adds another ball to the field temporarily.
            } else if (choose == 3)
            {
                bonusBall.SetActive(true);
                bonusBall.GetComponent<Renderer>().enabled = true;
                bonusBall.GetComponent<Collider>().enabled = true;

                yield return new WaitForSeconds(20f);
                bonusBall.SetActive(false);
                bonusBall.GetComponent<Renderer>().enabled = false;
                bonusBall.GetComponent<Collider>().enabled = false;

                bonusBall.transform.position = new Vector3(0, 1, 0);
            }

            x = Random.Range(-13, 13);
            y = 0.75f;
            z = Random.Range(-4, 4);
            pos = new Vector3(x, y, z);

            //Chooses a random position for the powerup to respawn and become tangible.
            powerUp.transform.position = pos;
            powerUp.GetComponent<Renderer>().enabled = true;
            powerUp.GetComponent<Collider>().enabled = true;
        }
    }
}
