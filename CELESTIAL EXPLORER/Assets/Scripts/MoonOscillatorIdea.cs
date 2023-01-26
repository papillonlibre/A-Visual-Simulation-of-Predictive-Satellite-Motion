using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonOscillatorIdea : MonoBehaviour
{
    float timeCounter = 0;
    public float speed;
    public float width;
    public float height;
    public GameObject Earth;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * speed;

        float x = (Earth.transform.position.x - transform.position.x) + Mathf.Sin(timeCounter) * height;
        float y = transform.position.y;
        float z = (Earth.transform.position.z - transform.position.z) + Mathf.Cos(timeCounter) * width;

        transform.position = new Vector3(x, y, z);
    }
}
