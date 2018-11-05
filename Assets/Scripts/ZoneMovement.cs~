using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneMovement : MonoBehaviour {

    public Rigidbody rb;
    public GameObject player;
    public int speed;

    // Use this for initialization
    void Start()
    {
        speed = GameObject.Find("Player").GetComponent<Player>().speed;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        player = GameObject.Find("Player");
        speed = player.GetComponent<Player>().speed;
        transform.Translate(0, 0, -1 * speed);
        if (transform.position.z < player.transform.position.z - 10)
        {
            Destroy(this.gameObject);
        }
    }
}
