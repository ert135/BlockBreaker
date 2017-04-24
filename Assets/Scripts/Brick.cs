﻿using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	
	public int maxHits;
	private int timesHit;

	// Use this for initialization
	void Start () {
		this.timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log("Hit green brick");
		this.timesHit++;
	}
}
