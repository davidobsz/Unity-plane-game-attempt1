using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20.0f;
    public float turnSpeed = 25f;
    public float horizontalInput;
    public float forwardInput;
    public float mouseInputLeftRight;
    public float mouseInputUpDown;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        mouseInputLeftRight = Input.GetAxis("Mouse X");
        mouseInputUpDown = Input.GetAxis("Mouse Y");
        // Move the Vehicle forward
        //transform.Translate(0, 0, 1);  <- this does the same as below.
        // transform.Translate(Vector3.forward); <- moves 1 unit (meter) a second but based on frames... higher fps higher speed .. BAD 


        // Rotates car based on input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.left * Time.deltaTime * turnSpeed * mouseInputLeftRight);
        transform.Rotate(Vector3.forward * Time.deltaTime * turnSpeed * mouseInputUpDown);
        transform.Translate(Vector3.left * Time.deltaTime * turnSpeed * forwardInput);
        //transform.Translate(Vector3.up * Time.deltaTime * turnSpeed * forwardInput);

    }
}