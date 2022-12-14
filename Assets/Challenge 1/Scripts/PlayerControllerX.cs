using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 25.0f;
    public float verticalInput;
    public float horizontalInput;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Horizontal");
        horizontalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // turn left or right
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * horizontalInput);

        //transform.Rotate(0, 0, rotationSpeed * Time.deltaTime * horizontalInput);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.up, rotationSpeed * verticalInput * Time.deltaTime);

    }
}
