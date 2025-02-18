using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public BallThrow ballthrow;
    public TextMeshProUGUI scoreText;
    private float score;


    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
         score = ballthrow.getscoreTotal();

         scoreText.text = "Score: " + score;
    }
}
