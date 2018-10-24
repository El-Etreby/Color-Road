using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGeneration : MonoBehaviour {
    private float time;
    public Transform BlueBallPrefab;
    public Transform RedBallPrefab;
    public Transform GreenBallPrefab;

    // Use this for initialization
    void Start () {
        time = 0.0f;
    }
	
	// Update is called once per frame
	void Update () {
    }

     void FixedUpdate()
    {
        time += Time.deltaTime;
        if(time > 3.0) {
            int RandomColor = Random.Range(0, 3);
            if(RandomColor == 0) {
                Instantiate(BlueBallPrefab, new Vector3(Random.Range(-1, 1) * 10, 1.77f, 10), Quaternion.identity);
            } else if(RandomColor == 1) {
                Instantiate(RedBallPrefab, new Vector3(Random.Range(-1, 1) * 10, 1.77f, 10), Quaternion.identity);
            } else if (RandomColor == 2) {
                Instantiate(GreenBallPrefab, new Vector3(Random.Range(-1, 1) * 10, 1.77f, 10), Quaternion.identity);
            }
            time = 0.0f;
        }
    }
}
