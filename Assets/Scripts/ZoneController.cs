using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneController : MonoBehaviour {
    private float time;
    public Transform BlueZonePrefab;
    public Transform RedZonePrefab;
    public Transform GreenZonePrefab;

    // Use this for initialization
    void Start()
    {
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time > 15.0)
        {
            int RandomColor = Random.Range(0, 3);
            if (RandomColor == 0)
            {
                Instantiate(BlueZonePrefab, new Vector3(0,0,-10), Quaternion.identity);
            }
            else if (RandomColor == 1)
            {
                Instantiate(RedZonePrefab, new Vector3(0, 0, -10), Quaternion.identity);
            }
            else if (RandomColor == 2)
            {
                Instantiate(GreenZonePrefab, new Vector3(0, 0, -10), Quaternion.identity);
            }
            time = 0.0f;
        }
    }
}
