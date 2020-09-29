using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turrets : MonoBehaviour
{
    private float startRotation;
    public float maxRotation = 45f;
    public float rotationSpeed = 10f;

    private void Start()
    {
        startRotation = transform.rotation.y;
    }

    private void Update()
    {
        TurretRotation();
    }



    void TurretRotation()
    {
        if (Input.GetButton("TurretRight") && transform.rotation.y < maxRotation)
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
        else if (Input.GetButton("TurretLeft") && transform.rotation.y > --maxRotation)
        {
            transform.Rotate(0, -(rotationSpeed * Time.deltaTime), 0);
        }
    }
}
