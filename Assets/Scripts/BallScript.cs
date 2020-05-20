using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ballForce;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyUp(KeyCode.Space)){
            transform.SetParent(null);
            rb.isKinematic=false;
            rb.AddForce(new Vector2(ballForce,ballForce));
        }
    }
}
