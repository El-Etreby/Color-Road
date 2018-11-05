using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour {
    public int speed;
    public GameObject player;

    // Use this for initialization
    void Start () {
        speed = GameObject.Find("Player").GetComponent<Player>().speed;
    }
	
	// Update is called once per frame
	void Update () {
	}

    private void FixedUpdate()
    {
        player = GameObject.Find("Player");
        speed = player.GetComponent<Player>().speed;
        transform.Translate(0, 0, -1 * speed);
        if (transform.position.z < -245)
        {
            transform.Translate(0, 0, 400);
        }
    }
}
