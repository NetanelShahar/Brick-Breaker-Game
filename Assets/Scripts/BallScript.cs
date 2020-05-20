using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D rg;
    public float ballForce;
    // Start is called before the first frame update
    void Start()
    {
        rg.AddForce(new Vector2(ballForce,ballForce));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
