using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code paraphrased from https://www.youtube.com/watch?v=LBoPP9mKjKc&feature=youtu.be
public class UIElementsMovement : MonoBehaviour
{
    public GameObject you;
    public GameObject win;

    public GameObject panel;

    public GameObject target1;
    public GameObject target2;

    private Vector3 startPosition1;
    private Vector3 startPosition2;
    private float speed = 1000f;

    void Awake()
    {
        startPosition1 = you.transform.position;
        startPosition2 = win.transform.position;
    }

    void OnEnable()
    {
        StartCoroutine("UIcoroutineYou");
        StartCoroutine("UIcoroutineWin");
    }

    void OnDisable()
    {
        StopCoroutine("UIcoroutineYou");
        StopCoroutine("UIcoroutineWin");

        you.transform.position = startPosition1;
        win.transform.position = startPosition2;

        you.SetActive(true);
        win.SetActive(true);
    }

    private IEnumerator UIcoroutineYou()
    {

        you.SetActive(false);

        while (true)
        {
            yield return new WaitForSeconds(1f);
            you.SetActive(true);


            while (Vector3.Distance(you.transform.position, target1.transform.position) > 1f)
            {
                you.transform.position = Vector3.MoveTowards(you.transform.position, target1.transform.position, Time.deltaTime * speed);

                yield return new WaitForSeconds(0.02f);
            }

            you.transform.position = target1.transform.position;
            you.SetActive(false);

            yield return new WaitForSeconds(1f);

            you.SetActive(false);
            yield return new WaitForSeconds(1f);

            you.transform.position = startPosition1;
            you.SetActive(false);

        }

    }

    private IEnumerator UIcoroutineWin()
    {

        win.SetActive(false);

        while (true)
        {
            yield return new WaitForSeconds(1f);
            win.SetActive(true);


            while (Vector3.Distance(win.transform.position, target2.transform.position) > 1f)
            {
                win.transform.position = Vector3.MoveTowards(win.transform.position, target2.transform.position, Time.deltaTime * speed);

                yield return new WaitForSeconds(0.02f);
            }

            win.transform.position = target2.transform.position;
            win.SetActive(false);

            yield return new WaitForSeconds(1f);

            win.SetActive(false);
            yield return new WaitForSeconds(1f);

            win.transform.position = startPosition2;
            win.SetActive(false);

        }

    }
}