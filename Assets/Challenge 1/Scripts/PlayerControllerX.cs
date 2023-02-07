using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20.0f;
    public float rotationSpeed = 50.0f;
    public float verticalInput;
    public float horizontalInput;
    public Camera camOnBoard;
    public bool isCamOnBoardActive;

    // Start is called before the first frame update
    void Start()
    {
        camOnBoard = GameObject.Find("Camera").GetComponent<Camera>();
        isCamOnBoardActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            if(isCamOnBoardActive == false)
            {
                isCamOnBoardActive = true;
                camOnBoard.gameObject.SetActive(true);
            }
            else
            {
                isCamOnBoardActive = false;
                camOnBoard.gameObject.SetActive(false);
            }
            
        }
        

        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // move the car forward 
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        // turn left or right
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime * horizontalInput);

        //transform.Rotate(0, 0, rotationSpeed * Time.deltaTime * horizontalInput);

        // tilt the plane up/down based on up/down arrow keys
        //transform.Rotate(Vector3.up, rotationSpeed * verticalInput * Time.deltaTime);

    }
}
