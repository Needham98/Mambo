using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public float speed = 0.5f;

    void Update()
    {
        float xAxisValue = Input.GetAxis("Horizontal") * -1*speed;
        float zAxisValue = Input.GetAxis("Vertical") * -1*speed;
        float yValue = 0.0f;

        if (Input.GetKey(KeyCode.Q))
        {
            yValue = -speed;
        }
        if (Input.GetKey(KeyCode.E))
        {
            yValue = speed;
        }

        transform.position = new Vector3(transform.position.x + xAxisValue, transform.position.y + yValue, transform.position.z + zAxisValue);
    }
}
