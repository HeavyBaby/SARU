﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity
		= new Vector2 (5.0f, 0);
	}

	// Update is called once per frame
	void Update () {
	}
}

