//Special thanks to John McConley for helping me figure out how to code this//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool spinInput;
 
    public float turnSpeed; 
    private float spinTime;
    private bool hasSpun;

    public float addedSpeedPerFrame;
    //private float totalRotation;

    
    public Transform playerTransform;

    private float previousFrameRotation;
    // Start is called before the first frame update
    void Start()
    {
       //turnSpeed=45.0f; 
       spinTime=0.0f;
    //    turnSpeed = 900f;
       hasSpun = false;
       spinInput = false;
    //    transform.rotation.y=0;
       //totalRotation = 0f;
    }
    
    
    //private float spinStart;
    //private float spinStop;
    
    // Update is called once per frame
    void Update()
    {
         // Calculate the rotation for this frame
        
        /*spinStart = ( Time.deltaTime);
        spinStop = (Time.deltaTime);*/
        if(!hasSpun){
            hasSpun = Input.GetKeyUp(KeyCode.Space);
            /*float rotationThisFrame = turnSpeed * Time.deltaTime;
        
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
                }*/
        }
        spinInput = Input.GetKey(KeyCode.Space);
        
        if(spinInput && !hasSpun){
            spinTime += Time.deltaTime;
            transform.RotateAround(playerTransform.position, Vector3.up, turnSpeed  * Time.deltaTime);
            turnSpeed+=addedSpeedPerFrame;
        }
        // if (transform.rotation.y = 360)
        // {AngleUnit.Turn+=1}
        // {
        //     turnSpeed += 250;
        //     transform.RotateAround(playerTransform.position, Vector3.up, turnSpeed * Time.deltaTime);
        // }

        //rotate the vehicle baased on horizontal input
        // if (Input.GetKeyDown ('space')){
        //     transform.Rotate 
        // }
       
    
    }
    public float getTurnSpeed()
    {
        return turnSpeed;
    }

}
