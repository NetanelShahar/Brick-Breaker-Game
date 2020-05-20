using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ballForce;
    bool beforeGameStarted=true;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyUp(KeyCode.Space)&&beforeGameStarted){
            transform.SetParent(null);
            rb.isKinematic=false;
            beforeGameStarted=false;
            rb.AddForce(new Vector2(ballForce,ballForce));
        }
    }
}
