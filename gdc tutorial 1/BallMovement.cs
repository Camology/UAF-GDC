using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {


	private Rigidbody2D rb;
	private Vector2 movement;
	public float speed = 50;

	// Use this for initialization
	void Start () {
		float moveInitialX = Random.Range (-0.9f, 0.9f);
		float moveInitialY = Random.Range (-1.0f, 1.0f);
		rb = GetComponent<Rigidbody2D> ();
		movement = new Vector2(moveInitialX, moveInitialY);
		rb.velocity = movement.normalized * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2d(Collision2D col) {
		if (col.gameObject.name == "RacketLeft" || col.gameObject.name == "RacketRight") {
			Vector2 dir = new Vector2 ();
			float y = hitFactor (transform.position,
				          		col.transform.position,
				          		col.collider.bounds.size.y);
			if (col.gameObject.name == "RacketLeft") {
				dir = new Vector2 (1, y).normalized;
			} else {
				dir = new Vector2 (-1, y).normalized;
			}
			GetComponent<Rigidbody2D> ().velocity = dir * speed;
		}
	}

	void OnTriggerEnter2D(Collider2D c) {
		Destroy (gameObject);
	}

	float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight) {
		return (ballPos.y - racketPos.y) / racketHeight;
	}
}
