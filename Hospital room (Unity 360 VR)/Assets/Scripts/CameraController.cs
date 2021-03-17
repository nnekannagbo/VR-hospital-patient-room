using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //variable for the sensitivity of the mouse
    private float rotateSpeed = 300.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))  //0 is left mouse button, 1 is middle mouse button, 2 is right mouse button. Only rotate around the scene when left mouse button is pushed down.
        {
            //rotate camera according to the mouse
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x + Input.GetAxis("Mouse Y") * Time.deltaTime * rotateSpeed, transform.localEulerAngles.y + Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed, 0);  //transform is the xyz value of the object 
            //x and y are inverted. z is always going to be 0
        }
    }
}
