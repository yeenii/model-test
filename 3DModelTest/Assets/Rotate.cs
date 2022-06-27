using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0, speed * Time.deltaTime, 0);
            
        }

        if (Input.GetMouseButton(1))
        {
            transform.Rotate(speed * Time.deltaTime, 0, 0);
        }
    }
}
