using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDispenser : MonoBehaviour {

	public GameObject ball;

	void Awake() {
		Instantiate (ball, transform.position, transform.rotation);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectsWithTag ("Ball").Length == 0) {
			Instantiate (ball, transform.position, transform.rotation);
		}
	}
}
