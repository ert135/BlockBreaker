﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	private Vector3 paddleToBallVector;
	private bool hasStarted = false;
	private Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();
		this.hasStarted = false;
		paddleToBallVector = this.transform.position - paddle.transform.position;
		this.rigidBody = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("has started " + this.hasStarted);
		if(!this.hasStarted){
			this.transform.position = paddle.transform.position + paddleToBallVector;
			
			if(Input.GetMouseButtonDown(0)){
				this.hasStarted = true;
				this.rigidBody.velocity = new Vector2(2f, 10f);
			}
		}
	}
}
