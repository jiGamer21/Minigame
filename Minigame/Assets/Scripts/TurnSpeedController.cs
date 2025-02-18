using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSpeedController : MonoBehaviour
{
    public float turnSpeed = 10f; // Initial turn speed
    private float totalRotation = 0f;

    void Update()
    {
        // Calculate the rotation for this frame
        float rotationThisFrame = turnSpeed * Time.deltaTime;
        
        // Apply the rotation
        transform.Rotate(0, rotationThisFrame, 0);
        
        // Update the total rotation
        totalRotation += rotationThisFrame;

        // Check if a full 360-degree turn has been completed
        if (totalRotation >= 360f)
        {
            // Increase the turn speed
            turnSpeed += 30f;
            
            // Reset the total rotation
            totalRotation -= 360f;
        }
    }
}