using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillatorSatellite : MonoBehaviour
{
    float timeCounter = 0;
    float circumference;
    
    public float speed;
    public float width;
    public float height;
    float x;
    float y;
    float z;
    public float currentX;
    public float currentZ;

    public GameObject Earth;
    
    // Start is called before the first frame update
    void Start()
    {
        
        y = transform.position.y;
        

    }

    // Update is called once per frame
    void Update()
    {
        circumference = width * Mathf.PI;
        

        // updates position
        timeCounter += Time.deltaTime * speed;
        
        z = Mathf.Cos(timeCounter) * width;
        x = Mathf.Sin(timeCounter) * height;
        currentX = x;
        currentZ = z;
        transform.position = new Vector3(x, y, z);
        

        // updates rotation of rocket throughout orbit

        
        transform.Rotate(0, 0, 360/(2*circumference));        

        

    }
}
