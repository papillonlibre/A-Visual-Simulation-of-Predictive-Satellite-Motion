using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public GameObject Pegasus;
    private IEnumerator coroutine;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*

        float r = (float) GetComponent<TextController>().radius;
        float finalR = (float) GetComponent<TextController>().finalRadius;
        float radiusProportion = finalR / r;

        float futureWidth = Pegasus.GetComponent<OscillatorSatellite>().width * radiusProportion;
        float futureHeight = Pegasus.GetComponent<OscillatorSatellite>().height * radiusProportion;
        double velRatio = GetComponent<TextController>().velocityRatio;
        double speed = GetComponent<TextController>().tempSpeed;

        if (GetComponent<TextController>().startCoroutine == true)
        {
            coroutine = LineMover(speed, GetComponent<TextController>().TargetPosition, futureHeight, futureWidth, velRatio);
            Debug.Log("Target is " + GetComponent<TextController>().TargetPosition);
            Debug.Log("Pegasus starting position: " + Pegasus.transform.position);
            StartCoroutine(coroutine);
        }*/

    }/*
    IEnumerator LineMover(double tempSpeed, Vector3 target, float futureHeight, float futureWidth, double velocityRatio)
    {

        while (Pegasus.transform.position != target)
        {
            Debug.Log("Pegasus position: " + Pegasus.transform.position);
            Debug.Log("Target is " + target);
            Pegasus.transform.position = Vector3.MoveTowards(Pegasus.transform.position, target, (float) tempSpeed * Time.deltaTime);
            yield return null;
        }

        if (Pegasus.transform.position == target)
        {
            Debug.Log("Current location after coroutines = " + Pegasus.transform.position);
            Debug.Log("Coroutines finished");


            // implementing the changes by accessing public variables of Pegasus
            // resets the width and height and then resume orbit
            Pegasus.GetComponent<OscillatorSatellite>().width = futureWidth;
            Pegasus.GetComponent<OscillatorSatellite>().height = futureHeight;
            Pegasus.GetComponent<OscillatorSatellite>().speed = (float) tempSpeed * (float)velocityRatio;
            GameObject.Find("pegasus").GetComponent<OscillatorSatellite>().enabled = true;
            StopCoroutine(coroutine);
        }

    }
    */
}
