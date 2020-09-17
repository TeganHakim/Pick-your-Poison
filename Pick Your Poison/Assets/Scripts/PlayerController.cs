using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float turnSpeed = 5f;
    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.up * verticalInput * movementSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * horizontalInput * turnSpeed * Time.deltaTime);
    }
}
