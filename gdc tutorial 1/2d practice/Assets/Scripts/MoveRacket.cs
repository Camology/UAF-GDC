using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket : MonoBehaviour {

	public float speed = 50;
	public string axis = "Vertical";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		float v = Input.GetAxisRaw (axis);
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, v) * speed;
	}
}
