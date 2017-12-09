using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour {

    public float speed = 20f;
    public GameObject ball;
    GameObject attachedBall = null;
	// Use this for initialization
	void Start () {
        SpawnBall();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Translate( Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, 0f);

        if (attachedBall)
        {
            Rigidbody2D ballRigidbody = attachedBall.GetComponent<Rigidbody2D>();
            ballRigidbody.position = transform.position + new Vector3(0, 8f, 0);

            if (Input.GetButtonDown("LaunchBall"))
            {
                Debug.Log("I'M HERE IN LAUNCHING");
                // Fire the ball
                //ballRigidbody.isKinematic = false;
                ballRigidbody.bodyType = RigidbodyType2D.Dynamic;
                ballRigidbody.AddForce(Vector2.up * 10000f);
                attachedBall = null;
            }
        }
        }

    void SpawnBall()
    {
        if (ball == null)
        {
            Debug.Log("error danger");
            return;
        }

        attachedBall = (GameObject)Instantiate(ball, transform.position + new Vector3(0, 8f, 0), Quaternion.identity);
    }
}
