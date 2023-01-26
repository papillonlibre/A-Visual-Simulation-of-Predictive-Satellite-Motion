using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TextController : MonoBehaviour
{
    // UI elements energy level
    public TMP_InputField radius_field;
    public TMP_InputField radius_fieldFinal;
    public TMP_InputField mass_field;
    public TMP_InputField energy_field;
    public TMP_InputField fuel_field;
    public GameObject validation;
    public GameObject mixedValidation;
    public GameObject validation2;
    public GameObject validation3;
    public GameObject validation4;
    public GameObject validation5;
    public GameObject validation6;
    public GameObject validation7;
    public GameObject validation8;
    public GameObject validation9;
    public GameObject validation10;
    public GameObject validation11;
    public GameObject validation12;
    public GameObject validation13;
    public GameObject validation14;
    public GameObject validation15;
    public GameObject validation16;
    public GameObject validation17;
    public GameObject errorMessage;
    public GameObject errorMessage2;

    // UI elements verify level
    public TMP_InputField velocity_field;
    public TMP_InputField acceleration_field;
    public TMP_InputField period_field;
    public TMP_InputField verifyRadius_field;
    public TMP_InputField escape_field;

    float targetTime = 10.0f;

    // constants
    double G = 6.67430 * Math.Pow(10, -11);
    double Earth_Mass = 5.9722 * Math.Pow(10, 24);

    // inputted values as doubles
    public double radius;
    public double finalRadius;
    double mass; // this will not be used in the non-energy level except for initial velocity. It is instructive
                 // to students because it shows that the mass
                 // of the satellite is irrellevant. For the energy
                 // level, it is a requisite parameter.
    double totalEnergy;


    // strings for comparison
    string energyGuess;
    string accelerationGuess;
    string velocityGuess;
    string periodGuess;
    string fuelGuess;
    string escapeGuess;

    double verifyRadius;

    // values for visual controller
    public GameObject Pegasus;
    float width;
    float height;
    double speed;
    public double velocityRatio;
    public double tempSpeed;
    
    public Boolean startCoroutine = false;
    public Vector3 TargetPosition;
    private IEnumerator coroutine;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Double.TryParse(radius_field.text.ToString(), out double result))
        {
            radius = Convert.ToDouble(radius_field.text.ToString());
        }
        if (Double.TryParse(mass_field.text.ToString(), out double result2))
        {
            mass = Convert.ToDouble(mass_field.text.ToString());
        }
        if (Double.TryParse(radius_fieldFinal.text.ToString(), out double result3))
        {
            finalRadius = Convert.ToDouble(radius_fieldFinal.text.ToString());
        }

        if (Double.TryParse(verifyRadius_field.text.ToString(), out double result4))
        {
            verifyRadius = Convert.ToDouble(verifyRadius_field.text.ToString());
        }

        energyGuess = energy_field.text.ToString();

        velocityGuess = velocity_field.text.ToString();
        accelerationGuess = acceleration_field.text.ToString();
        periodGuess = period_field.text.ToString();

        fuelGuess = fuel_field.text.ToString();
        escapeGuess = escape_field.text.ToString();

        width = Pegasus.GetComponent<OscillatorSatellite>().width;
        height = Pegasus.GetComponent<OscillatorSatellite>().height;
        speed = Pegasus.GetComponent<OscillatorSatellite>().speed;


    }
    public void PhysicsChecker()
    {
        Debug.Log("Here at the beginning");
        
        double velocity1 = Math.Sqrt(G * Earth_Mass / verifyRadius);

        double acceleration1 = G * Earth_Mass / (Math.Pow(verifyRadius, 2));

        double period1 = Math.Sqrt(4 * Math.Pow(Math.PI, 2) * Math.Pow(verifyRadius, 3) / G * Earth_Mass);

        double escape1 = Math.Pow((2 * G * Earth_Mass / verifyRadius), 1 / 2);

        double velocity = Math.Round(velocity1, 4);
        double acceleration = Math.Round(acceleration1, 4);
        double period = Math.Round(period1, 4);

        double escape = Math.Round(escape1, 4);

        if (acceleration.ToString() == accelerationGuess && velocity.ToString() == velocityGuess && period.ToString() == periodGuess && escape.ToString() == escapeGuess)
        {
            Invoke("myCorrectTimer2", .1f);
            Debug.Log("Here");
        }
        else if (acceleration.ToString() == accelerationGuess && velocity.ToString() == velocityGuess && escape.ToString() == escapeGuess)
        {
            Invoke("myCorrectTimer3", .1f);
            Debug.Log("Here");
        }
        else if (acceleration.ToString() == accelerationGuess && period.ToString() == periodGuess && escape.ToString() == escapeGuess)
        {
            Invoke("myCorrectTimer4", .1f);
            Debug.Log("Here");
        }
        else if (velocity.ToString() == velocityGuess && period.ToString() == periodGuess && escape.ToString() == escapeGuess)
        {
            Invoke("myCorrectTimer5", .1f);
            Debug.Log("Here");
        }

        else if (period.ToString() == periodGuess && velocity.ToString() == velocityGuess && acceleration.ToString() == accelerationGuess)
        {
            Invoke("myCorrectTimer6", .1f);
            Debug.Log("Here");
        }
        else if (escape.ToString() == escapeGuess && acceleration.ToString() == accelerationGuess)
        {
            Invoke("myCorrectTimer7", .1f);
            Debug.Log("Here");
        }
        else if (escape.ToString() == escapeGuess && period.ToString() == periodGuess)
        {
            Invoke("myCorrectTimer8", .1f);
            Debug.Log("Here");
        }
        else if (escape.ToString() == escapeGuess && velocity.ToString() == velocityGuess)
        {
            Invoke("myCorrectTimer9", .1f);
            Debug.Log("Here");
        }
        else if (period.ToString() == periodGuess && acceleration.ToString() == accelerationGuess)
        {
            Invoke("myCorrectTimer10", .1f);
            Debug.Log("Here");
        }
        else if (period.ToString() == periodGuess && velocity.ToString() == velocityGuess)
        {
            Invoke("myCorrectTimer11", .1f);
            Debug.Log("Here");
        }
        else if (velocity.ToString() == velocityGuess && acceleration.ToString() == accelerationGuess)
        {
            Invoke("myCorrectTimer12", .1f);
            Debug.Log("Here");
        }

        else if (period.ToString() == periodGuess)
        {
            Invoke("myCorrectTimer13", .1f);
            Debug.Log("Here");
        }
        else if (acceleration.ToString() == accelerationGuess)
        {
            Invoke("myCorrectTimer14", .1f);
            Debug.Log("Here");
        }
        else if (velocity.ToString() == velocityGuess)
        {
            Invoke("myCorrectTimer15", .1f);
            Debug.Log("Here");
        }
        else if (escape.ToString() == escapeGuess)
        {
            Invoke("myCorrectTimer16", .1f);
            Debug.Log("Here");
        }
        else
        {
            Invoke("myCorrectTimer17", .1f);

        }

    }

    public void EnergyChecker()
    {

        double TopEnergy = G * Earth_Mass * mass / (2 * finalRadius);
        double BottomEnergy = G * Earth_Mass * mass / (2 * radius);

        totalEnergy = Math.Round(TopEnergy - BottomEnergy, 4);

        // the user has guessed the work done correctly

        if (totalEnergy.ToString() == energyGuess && fuelGuess == "87.5")
        {
            Invoke("myCorrectTimer", .1f);
            visualHandler();

        }
        else if (totalEnergy.ToString() == energyGuess && fuelGuess != "87.5")
        {
            Invoke("myMixedCorrectTimer", .1f);
            visualHandler();

        }
        else if (totalEnergy.ToString() != energyGuess && fuelGuess == "87.5")
        {
            Invoke("myIncorrectTimer2", .1f);

        }
        else
        {
            Invoke("myIncorrectTimer", .1f);
            Debug.Log("radius= " + radius + " , finalRadius = " + finalRadius + " , and mass = " + mass + " , and totalEnergy = " + totalEnergy);
        }

    }
    // timers for the energy level
    private void myCorrectTimer()
    {
        validation.SetActive(true);
        targetTime--;
        if (targetTime > 0)
        {
            Invoke("myCorrectTimer", .5f);
        }
        else
        {
            validation.SetActive(false);
            targetTime = 10.0f;
        }
    }
    private void myMixedCorrectTimer()
    {
        mixedValidation.SetActive(true);
        targetTime--;
        if (targetTime > 0)
        {
            Invoke("myMixedCorrectTimer", .5f);
        }
        else
        {
            mixedValidation.SetActive(false);
            targetTime = 10.0f;
        }
    }

    private void myIncorrectTimer()
    {
        errorMessage.SetActive(true);
        targetTime--;
        if (targetTime > 0)
        {
            Invoke("myIncorrectTimer", .5f);
        }
        else
        {
            errorMessage.SetActive(false);
            targetTime = 10.0f;
        }
    }
    private void myIncorrectTimer2()
    {
        errorMessage2.SetActive(true);
        targetTime--;
        if (targetTime > 0)
        {
            Invoke("myIncorrectTimer2", .5f);
        }
        else
        {
            errorMessage2.SetActive(false);
            targetTime = 10.0f;
        }
    }
    // timers for the verify level
    private void myCorrectTimer2()
    {
        validation2.SetActive(true);
        targetTime--;
        if (targetTime > 0)
        {
            Invoke("myCorrectTimer2", .5f);
        }
        else
        {
            validation2.SetActive(false);
            targetTime = 10.0f;
        }
    }
    private void myCorrectTimer3()
    {
        validation3.SetActive(true);
        targetTime--;
        if (targetTime > 0)
        {
            Invoke("myCorrectTimer3", .5f);
        }
        else
        {
            validation3.SetActive(false);
            targetTime = 10.0f;
        }
    }
    private void myCorrectTimer4()
    {
        validation4.SetActive(true);
        targetTime--;
        if (targetTime > 0)
        {
            Invoke("myCorrectTimer4", .5f);
        }
        else
        {
            validation4.SetActive(false);
            targetTime = 10.0f;
        }
    }
    private void myCorrectTimer5()
    {
        validation5.SetActive(true);
        targetTime--;
        if (targetTime > 0)
        {
            Invoke("myCorrectTimer5", .5f);
        }
        else
        {
            validation5.SetActive(false);
            targetTime = 10.0f;
        }
    }
    private void myCorrectTimer6()
    {
        validation6.SetActive(true);
        targetTime--;
        if (targetTime > 0)
        {
            Invoke("myCorrectTimer6", .5f);
        }
        else
        {
            validation6.SetActive(false);
            targetTime = 10.0f;
        }
    }


    private void myCorrectTimer7()
    {
        validation7.SetActive(true);
        targetTime--;
        if (targetTime > 0)
        {
            Invoke("myCorrectTimer7", .5f);
        }
        else
        {
            validation7.SetActive(false);
            targetTime = 10.0f;
        }
    }
    private void myCorrectTimer8()
    {
        validation8.SetActive(true);
        targetTime--;
        if (targetTime > 0)
        {
            Invoke("myCorrectTimer8", .5f);
        }
        else
        {
            validation9.SetActive(false);
            targetTime = 10.0f;
        }
    }
    private void myCorrectTimer9()
    {
        validation9.SetActive(true);
        targetTime--;
        if (targetTime > 0)
        {
            Invoke("myCorrectTimer9", .5f);
        }
        else
        {
            validation8.SetActive(false);
            targetTime = 10.0f;
        }
    }
    private void myCorrectTimer10()
    {
        validation10.SetActive(true);
        targetTime--;
        if (targetTime > 0)
        {
            Invoke("myCorrectTimer10", .5f);
        }
        else
        {
            validation10.SetActive(false);
            targetTime = 10.0f;
        }
    }
    private void myCorrectTimer11()
    {
        validation11.SetActive(true);
        targetTime--;
        if (targetTime > 0)
        {
            Invoke("myCorrectTimer11", .5f);
        }
        else
        {
            validation11.SetActive(false);
            targetTime = 10.0f;
        }
    }
    private void myCorrectTimer12()
    {
        validation12.SetActive(true);
        targetTime--;
        if (targetTime > 0)
        {
            Invoke("myCorrectTimer12", .5f);
        }
        else
        {
            validation12.SetActive(false);
            targetTime = 10.0f;
        }
    }
    private void myCorrectTimer13()
    {
        validation13.SetActive(true);
        targetTime--;
        if (targetTime > 0)
        {
            Invoke("myCorrectTimer13", .5f);
        }
        else
        {
            validation13.SetActive(false);
            targetTime = 10.0f;
        }
    }
    private void myCorrectTimer14()
    {
        validation14.SetActive(true);
        targetTime--;
        if (targetTime > 0)
        {
            Invoke("myCorrectTimer14", .5f);
        }
        else
        {
            validation14.SetActive(false);
            targetTime = 10.0f;
        }
    }
    private void myCorrectTimer15()
    {
        validation15.SetActive(true);
        targetTime--;
        if (targetTime > 0)
        {
            Invoke("myCorrectTimer15", .5f);
        }
        else
        {
            validation15.SetActive(false);
            targetTime = 10.0f;
        }
    }
    private void myCorrectTimer16()
    {
        validation16.SetActive(true);
        targetTime--;
        if (targetTime > 0)
        {
            Invoke("myCorrectTimer16", .5f);
        }
        else
        {
            validation16.SetActive(false);
            targetTime = 10.0f;
        }
    }
    private void myCorrectTimer17()
    {
        validation17.SetActive(true);
        targetTime--;
        if (targetTime > 0)
        {
            Invoke("myCorrectTimer17", .5f);
        }
        else
        {
            validation17.SetActive(false);
            targetTime = 10.0f;
        }
    }




    // functions to handle visual movement

    private void visualHandler()
    {
        // stops the orbit;
        
        GameObject.Find("pegasus").GetComponent<OscillatorSatellite>().enabled = false;

        // used to adjust the radius
        // have to convert the radius in kilometers
        // to the radius with the width and height// defined in Unity
        float radiusF = (float)finalRadius;
        float radiusI = (float)radius;
        radiusF /= (float)2.04;
        radiusI /= (float)2.04;
        float radiusRatio = radiusF / radiusI;

        // used to adjust velocity

        double velocityI = Math.Sqrt(G * Earth_Mass / radiusI);
        double velocityF = Math.Sqrt(G * Earth_Mass / radiusF);
        velocityRatio = velocityF / velocityI;
        
        // current and future orbit info
        float currentWidth = width;
        float currentHeight = height;
        float futureWidth = currentWidth * radiusRatio;
        float futureHeight = currentHeight * radiusRatio;

        // destination position of x and z

        float futureX = Pegasus.GetComponent<OscillatorSatellite>().currentX * radiusRatio;
        float futureZ = Pegasus.GetComponent<OscillatorSatellite>().currentZ * radiusRatio;
        //Debug.Log("futureX = " + futureX);
        //Debug.Log("futureZ = " + futureZ);

        // takes the average of the velocities as the path velocity
        float deltaSpeed = (float)velocityF - (float)velocityI;
        tempSpeed = deltaSpeed / 2;

        
        //float deltaX = futureX - Pegasus.GetComponent<OscillatorSatellite>().currentX;
        //float deltaZ = futureZ - Pegasus.GetComponent<OscillatorSatellite>().currentZ;

        TargetPosition = new Vector3(futureX, Pegasus.transform.position.y, futureZ);
        
        coroutine = LineMover(speed, TargetPosition, futureHeight, futureWidth, velocityRatio);
        //Debug.Log("Target is " + TargetPosition);
        //Debug.Log("Pegasus starting position: " + Pegasus.transform.position);
        StartCoroutine(coroutine);

    }
    IEnumerator LineMover(double tempSpeed, Vector3 target, float futureHeight, float futureWidth, double velocityRatio)
    {
        
        while (Pegasus.transform.position != target)
        {
            //Debug.Log("Pegasus position: " + Pegasus.transform.position);
            //Debug.Log("Target is " + target);
            Pegasus.transform.position = Vector3.MoveTowards(Pegasus.transform.position, target, (float)tempSpeed * Time.deltaTime);
            yield return null;
        }

        if (Pegasus.transform.position == target)
        {
            //Debug.Log("Current location after coroutines = " + Pegasus.transform.position);
            //Debug.Log("Coroutines finished");


            // implementing the changes by accessing public variables of Pegasus
            // resets the width and height and then resume orbit
            Pegasus.GetComponent<OscillatorSatellite>().width = futureWidth;
            Pegasus.GetComponent<OscillatorSatellite>().height = futureHeight;
            Pegasus.GetComponent<OscillatorSatellite>().speed = (float) speed * (float)velocityRatio;
            GameObject.Find("pegasus").GetComponent<OscillatorSatellite>().enabled = true;
            StopCoroutine(coroutine);
        }

    }

}