//Special thanks to John McConley for helping me figure out how to code this//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrow : MonoBehaviour
{
    private bool spinInput;
 

    private float spinTime;
    private bool hasSpun;
    public Transform playerTransform;
    public PlayerController player;
    public Rigidbody rb;
    private float yPos;
    public float divisor;

    private float yMinPos;

    public float artificialFriction;
    private float speed;
    private float initialSpeed;
    private float zLocation;

    public float scoreTotal; 

    

    // Start is called before the first frame update
    void Start()
    {
       //turnSpeed=45.0f; 
       spinTime=0.0f;
       hasSpun = false;
       spinInput = false;
        yPos = transform.position.y;
        yMinPos = -0.445f;
        scoreTotal= 0f;
    }
    
    
    //private float spinStart;
    //private float spinStop;
    
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < yMinPos)
        {
            transform.position = new Vector3(transform.position.x, yMinPos, transform.position.z);
        }
        /*spinStart = ( Time.deltaTime);
        spinStop = (Time.deltaTime);*/
        
        if(!hasSpun){
            hasSpun = Input.GetKeyUp(KeyCode.Space);
            transform.position = new Vector3 (transform.position.x, yPos, transform.position.z);
            if(hasSpun)
            {
                initialSpeed = player.getTurnSpeed()/divisor;
                speed = initialSpeed;
            }
        }
        spinInput = Input.GetKey(KeyCode.Space);
        
        if(spinInput && !hasSpun){
            spinTime += Time.deltaTime;
            transform.RotateAround(playerTransform.position, Vector3.up, player.getTurnSpeed()* Time.deltaTime);
        }
        
        /*if (transform.rotation.y == 180)
        {
            transform.RotateAround(playerTransform.position, Vector3.up, turnSpeed*=1.25f * Time.deltaTime);
        }*/
        


        //rotate the vehicle baased on horizontal input
        // if (Input.GetKeyDown ('space')){
        //     transform.Rotate 
        // }
        if (hasSpun)
            {
                transform.Translate (Vector3.forward * speed);
                speed -= artificialFriction;
                if(speed < 0.0f)
                {
                    speed = 0.0f;
                    zLocation = gameObject.transform.position.z;
                    scoreTotal = (int)(zLocation * 150);
                    ;
                }
                
            }
        

 
    }
    public float getscoreTotal()
    {
        return scoreTotal;
    }
}
