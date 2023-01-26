using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    private Camera cam;

    public float minFOV;
    public float maxFOV;
    public float zoomRate;

    private float currentFOV;


    private void Start()
    {
        cam = GetComponent<Camera>();
    }


    private void Update()
    {
        UseWheel();

    }


    public void UseWheel()
    {
        currentFOV = cam.fieldOfView;

        currentFOV += Input.GetAxis("Mouse ScrollWheel") * zoomRate;

        currentFOV = Mathf.Clamp(currentFOV, minFOV, maxFOV);
        cam.fieldOfView = currentFOV;
    }

}