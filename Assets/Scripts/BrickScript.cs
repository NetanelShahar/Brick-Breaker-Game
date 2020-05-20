using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    public float hitsLimit;
    private float hitsCounter=0; 
// Start is called before the first frame update
void Start()
{
hitsLimit--;
}

// Update is called once per frame
void Update()
{

}

void OnCollisionEnter2D(Collision2D other) {
if(other.gameObject.tag == "Ball"){
    if(hitsCounter==hitsLimit){
    Destroy(gameObject);
    }else
    {
        hitsCounter++;
    }
}   

 }
}
