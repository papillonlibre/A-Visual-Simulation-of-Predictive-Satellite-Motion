using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillatorMoon : MonoBehaviour
{
    float timeCounter = 0;
    public float speed;
    public float width;
    public float height;
    float x;
    float y;
    float z;
    float xOriginal;
    float yOriginal;
    float zOriginal;

    public GameObject Earth;

    // Start is called before the first frame update
    void Start()
    {
        xOriginal = transform.position.x;
        yOriginal = transform.position.y;
        zOriginal = transform.position.z;

    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * speed;

        z = Mathf.Cos(timeCounter) * width - 1000;
        x = Mathf.Sin(timeCounter) * height - 500;

        transform.position = new Vector3(x, y, z);

    }
}
