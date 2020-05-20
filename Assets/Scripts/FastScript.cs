using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other) {
    if(other.gameObject.tag == "Ball"){
        other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(400,400));
        Destroy(gameObject);
    }   
 }
}
