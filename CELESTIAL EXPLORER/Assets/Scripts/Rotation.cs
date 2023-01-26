using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // the problem is that it rotated along the x and y rather than on the x
        //transform.Rotate(-rotator * Time.deltaTime, -rotator * Time.deltaTime, 0);

      
        transform.Rotate(0, 0, -rotator * Time.deltaTime);

    }
}
