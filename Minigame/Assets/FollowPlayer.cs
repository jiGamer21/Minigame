using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 6, 0);
    // private bool spinInput;
    // private bool hasSpun;

    // Start is called before the first frame update
    void Start()
    {
        // hasSpun = false;
        // spinInput = false;
    }

    
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        // if(!hasSpun){
        //     hasSpun = Input.GetKeyUp(KeyCode.Space);
        //     transform.position = new Vector3(0, 6, -3);
        //     if (hasSpun){
        //         transform.position = player.transform.position + offset;
        //     }
                
        //     }
        
        // spinInput = Input.GetKey(KeyCode.Space);
        
        
        
        
        


    }
}
