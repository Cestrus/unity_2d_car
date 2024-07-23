using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]
    float steerSpeed = 200;

    [SerializeField]
    float mediumCarSpeed = 10;

    [SerializeField]
    float slowCarSpeed = 5;

    [SerializeField]
    float fastCarSpeed = 15;

    float carSpeed;

    void Start()
    {
        carSpeed = mediumCarSpeed;
    }

    void OnCollisionEnter2D()
    {
        carSpeed = slowCarSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("FastSpeedPoint"))
        {
            carSpeed = fastCarSpeed;
        }

        if (other.CompareTag("NormalSpeedPoint"))
        {
            carSpeed = mediumCarSpeed;
        }
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * carSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
