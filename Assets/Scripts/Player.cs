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
    public float delay;
    public AudioSource hitMatchingSound;
    public AudioSource hitNonMatchingSound;
    public AudioSource changeColorSound;

    // Use this for initialization
    void Start () {
        print("test");
        material = GetComponent<Renderer>().material;
        this.gameObject.tag = "BluePlayer";
        material.color = Color.blue;
        startingSpeed = 1;
        speed = startingSpeed;
        score = 0;
        scoreInterval = 20;
        delay = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
        float currentX = this.GetComponent<Transform>().position.x;

        if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) && currentX > -10)
        {
            transform.Translate(-10f, 0, 0);
        }
        if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && currentX < 10)
        {
            transform.Translate(10f, 0, 0);
        }
    }

    void FixedUpdate()
    {
        //float currentX = this.GetComponent<Transform>().position.x;

        //if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) && currentX > -10)
        //{
        //    if(Time.time - delay >= 0.03f) {
        //        delay = Time.time;
        //        transform.Translate(-10f, 0, 0);
        //    }
        //}
        //if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && currentX < 10)
        //{
        //    if (Time.time - delay >= 0.03f)
        //    {
        //        delay = Time.time;
        //        transform.Translate(10f, 0, 0);
        //    }
        //}
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "BlueBall" && this.gameObject.tag == "BluePlayer") {
            hitMatchingSound.Play();
            score += 10;
            Destroy(collision.gameObject);
            speed = score / scoreInterval * 2;
            if(speed == 0) {
                speed = startingSpeed;
            }
        } else if (collision.gameObject.tag == "RedBall" && this.gameObject.tag == "RedPlayer")
        {
            hitMatchingSound.Play();
            score += 10;
            Destroy(collision.gameObject);
            speed = score / scoreInterval * 2;
            if (speed == 0)
            {
                speed = startingSpeed;
            }
        } else if (collision.gameObject.tag == "GreenBall" && this.gameObject.tag == "GreenPlayer")
        {
            hitMatchingSound.Play();
            score += 10;
            Destroy(collision.gameObject);
            speed = score / scoreInterval * 2;
            if (speed == 0)
            {
                speed = startingSpeed;
            }
        } else if (collision.gameObject.tag == "BlueBall" || collision.gameObject.tag == "RedBall" || collision.gameObject.tag == "GreenBall")
        {
            hitNonMatchingSound.Play();
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
            changeColorSound.Play();
            this.gameObject.tag = "RedPlayer";
            this.material.color = Color.red;

        } else if (collision.gameObject.tag == "BlueZone")
        {
            changeColorSound.Play();
            this.gameObject.tag = "BluePlayer";
            this.material.color = Color.blue;

        } else if (collision.gameObject.tag == "GreenZone")
        {
            changeColorSound.Play();
            this.gameObject.tag = "GreenPlayer";
            this.material.color = Color.green;

        }
        scoreText.text = "Score : " + score;
    }
}
