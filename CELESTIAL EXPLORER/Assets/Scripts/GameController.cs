using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject orbitScreen;
    public GameObject orbitScreen2;
    public GameObject verifyScreen;
    public GameObject verifyScreen2;
    public GameObject Earth;
    public GameObject Moon;
    public GameObject ISS;
    public GameObject Hubble;
    public GameObject Rocket;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject instructionScreen;
    public GameObject NotesScreen;


    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Main Camera").GetComponent<CameraZoom>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // on click of satellite motion or submit!
    public void updateScreen1()
    {

        titleScreen.SetActive(false);
        orbitScreen.SetActive(true);
        orbitScreen2.SetActive(true);
        verifyScreen.SetActive(false);
        verifyScreen2.SetActive(false);
        Earth.SetActive(true);
        Moon.SetActive(true);
        Rocket.SetActive(true);
        ISS.SetActive(true);
        Hubble.SetActive(true);
        button1.SetActive(true);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
        button5.SetActive(false);
        button6.SetActive(false);
        button7.SetActive(false);
        instructionScreen.SetActive(false);
        NotesScreen.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<CameraZoom>().enabled = true;


    }
    // on click of home
    public void updateScreen2()
    {
        titleScreen.SetActive(true);
        orbitScreen.SetActive(false);
        orbitScreen2.SetActive(false);
        verifyScreen.SetActive(false);
        verifyScreen2.SetActive(false);
        Hubble.SetActive(false);
        Earth.SetActive(false);
        Moon.SetActive(false);
        Rocket.SetActive(false);
        ISS.SetActive(false);
        instructionScreen.SetActive(false);
        NotesScreen.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<CameraZoom>().enabled = false;


    }
    // on click of enter specs
    public void updateScreen3()
    {
        titleScreen.SetActive(false);
        orbitScreen.SetActive(false);
        orbitScreen2.SetActive(true);
        verifyScreen.SetActive(false);
        verifyScreen2.SetActive(false);
        Earth.SetActive(true);
        Hubble.SetActive(true);
        ISS.SetActive(true);
        Moon.SetActive(true);
        Rocket.SetActive(true);
        button1.SetActive(false);
        button2.SetActive(true);
        button3.SetActive(true);
        button4.SetActive(true);
        button5.SetActive(true);
        button6.SetActive(true);
        button7.SetActive(true);
        instructionScreen.SetActive(false);
        NotesScreen.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<CameraZoom>().enabled = true;


    }
    // used to verify the calculations
    public void updateScreen4()
    {
        titleScreen.SetActive(false);
        orbitScreen.SetActive(false);
        orbitScreen2.SetActive(false);
        verifyScreen.SetActive(true);
        verifyScreen2.SetActive(true);
        Earth.SetActive(true);
        Moon.SetActive(true);
        Hubble.SetActive(true);
        ISS.SetActive(true);
        Rocket.SetActive(true);
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
        button5.SetActive(false);
        button6.SetActive(false);
        button7.SetActive(false);
        instructionScreen.SetActive(false);
        NotesScreen.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<CameraZoom>().enabled = true;

    }
    // instruction screen
    public void UpdateScreen5()
    {
        titleScreen.SetActive(false);
        orbitScreen.SetActive(false);
        orbitScreen2.SetActive(false);
        verifyScreen.SetActive(false);
        verifyScreen2.SetActive(false);
        Earth.SetActive(false);
        Moon.SetActive(false);
        Hubble.SetActive(false);
        ISS.SetActive(false);
        Rocket.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
        button5.SetActive(false);
        button6.SetActive(false);
        button7.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<CameraZoom>().enabled = false;
        instructionScreen.SetActive(true);
        NotesScreen.SetActive(false);
    }
    // physics notes screen
    public void UpdateScreen6()
    {
        titleScreen.SetActive(false);
        orbitScreen.SetActive(false);
        orbitScreen2.SetActive(false);
        verifyScreen.SetActive(false);
        verifyScreen2.SetActive(false);
        Earth.SetActive(false);
        Moon.SetActive(false);
        Hubble.SetActive(false);
        ISS.SetActive(false);
        Rocket.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
        button5.SetActive(false);
        button6.SetActive(false);
        button7.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<CameraZoom>().enabled = false;
        instructionScreen.SetActive(false);
        NotesScreen.SetActive(true);
    }
}
