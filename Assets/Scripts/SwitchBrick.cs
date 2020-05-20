using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBrick : MonoBehaviour
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
        Destroy(gameObject);
        // GameObject Paddle;
        GameObject Paddle = GameObject.Find("Paddle");
        Destroy (Paddle.gameObject.GetComponent <PaddleScript>());
        Paddle.AddComponent<SwitchKeyBoard>();; 
    }   
 }
}
