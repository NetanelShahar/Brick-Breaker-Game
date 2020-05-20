using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    public float hitsLimit;
    private float hitsCounter=0; 
    public Sprite BrokenGreen;
    public Sprite BrokenBlue;
    public Sprite BrokenRed;
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
        if(this.gameObject.tag == "Green-Brick"){
             this.gameObject.GetComponent<SpriteRenderer>().sprite=BrokenGreen;
        }
        if(this.gameObject.tag == "Blue-Brick"){
             this.gameObject.GetComponent<SpriteRenderer>().sprite=BrokenBlue;
        }
        if(this.gameObject.tag == "Red-brick"){
            this.gameObject.GetComponent<SpriteRenderer>().sprite=BrokenRed;
        }
        hitsCounter++;
    }
}   

 }
}
