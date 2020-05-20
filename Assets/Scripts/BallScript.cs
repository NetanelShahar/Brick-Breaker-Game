using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BallScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ballForce;
    bool beforeGameStarted=true;
    public float maxBballScore;
    public string levelName;
    private float ballScore = 0;
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

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Green-Brick" || other.gameObject.tag == "Blue-Brick" || other.gameObject.tag == "Red-brick")
        {
            ballScore++;
        }

        if (ballScore == maxBballScore)
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
