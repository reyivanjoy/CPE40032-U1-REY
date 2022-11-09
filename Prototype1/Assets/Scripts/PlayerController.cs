using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float VehicleSpeed = 15.0f;
    private float TurningSpeed = 20.0f;
    private float HorizontalInput;
    private float VerticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

     // Moves the vehicle forward (Up/Down)
        transform.Translate(Vector3.forward * Time.deltaTime * VehicleSpeed * VerticalInput);
     // Rotates the vechile sidewards (Left/Right)
        transform.Rotate(Vector3.up * Time.deltaTime * TurningSpeed * HorizontalInput);
    }
}
