using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    private Material material;
    public Rigidbody rb;
    public Text scoreText;
    public int scoreInterval;
    public int startingSpeed;
    public int score;
    public int speed;

    // Use this for initialization
    void Start () {
        material = GetComponent<Renderer>().material;
        this.gameObject.tag = "BluePlayer";
        material.color = Color.blue;
        startingSpeed = 1;
        speed = startingSpeed;
        score = 0;
        scoreInterval = 50;
    }
	
	// Update is called once per frame
	void Update () {
        //float currentX = this.GetComponent<Transform>().position.x;

        //if (Input.GetKeyDown(KeyCode.LeftArrow) && currentX > -10) {
        //    transform.Translate(-10f, 0, 0);
        //}
        //if (Input.GetKeyDown(KeyCode.RightArrow) && currentX < 10)
        //{
        //    transform.Translate(10f, 0, 0);
        //}
    }

    void FixedUpdate()
    {
        float currentX = this.GetComponent<Transform>().position.x;

        if (Input.GetKeyDown(KeyCode.LeftArrow) && currentX > -10)
        {
            transform.Translate(-10f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && currentX < 10)
        {
            transform.Translate(10f, 0, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "BlueBall" && this.gameObject.tag == "BluePlayer") {
            score += 10;
            Destroy(collision.gameObject);
            speed = score / scoreInterval * 2;
            if(speed == 0) {
                speed = startingSpeed;
            }
        } else if (collision.gameObject.tag == "RedBall" && this.gameObject.tag == "RedPlayer")
        {
            score += 10;
            Destroy(collision.gameObject);
            speed = score / scoreInterval * 2;
            if (speed == 0)
            {
                speed = startingSpeed;
            }
        } else if (collision.gameObject.tag == "GreenBall" && this.gameObject.tag == "GreenPlayer")
        {
            score += 10;
            Destroy(collision.gameObject);
            speed = score / scoreInterval * 2;
            if (speed == 0)
            {
                speed = startingSpeed;
            }
        } else if (collision.gameObject.tag == "BlueBall" || collision.gameObject.tag == "RedBall" || collision.gameObject.tag == "GreenBall")
        {
            score /= 2;
            Destroy(collision.gameObject);
            speed = score / scoreInterval * 2;
            if (speed == 0)
            {
                speed = startingSpeed;
            }
            if(score <= 0) {
                GameObject.Find("Canvas").GetComponent<MenuController>().LoadGameOverMenu();
            }
        } else if(collision.gameObject.tag == "RedZone")
        {
            this.gameObject.tag = "RedPlayer";
            this.material.color = Color.red;

        } else if (collision.gameObject.tag == "BlueZone")
        {
            this.gameObject.tag = "BluePlayer";
            this.material.color = Color.blue;

        } else if (collision.gameObject.tag == "GreenZone")
        {
            this.gameObject.tag = "GreenPlayer";
            this.material.color = Color.green;

        }
        scoreText.text = "Score : " + score;
    }
}
