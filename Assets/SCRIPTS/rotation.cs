using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rewards : MonoBehaviour
{
    [SerializeField] private Vector3 rotationAxis = Vector3.up; // Axe de rotation
    [SerializeField] private float rotationSpeed = 10f; // Vitesse de rotation

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, rotationAxis, rotationSpeed * Time.deltaTime);
    }
}