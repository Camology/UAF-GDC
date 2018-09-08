using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

	public float speed = 50;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = Vector2.right * speed;
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

		if (col.gameObject.name == "WallLeft" || col.gameObject.name == "WallRight") {
			//destroyBall ();
		}
	}

	float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight) {
		return (ballPos.y - racketPos.y) / racketHeight;
	}
}
