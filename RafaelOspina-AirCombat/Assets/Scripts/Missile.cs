﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 10);
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (0, 0, 50.0f * Time.deltaTime);
	}

	void OnCollisionEnter(Collision collision) {

		if (collision.collider.gameObject.tag == "Enemy") {

			GameObject explosion = GameObject.Instantiate (Resources.Load ("Prefabs/Explosion") as GameObject);
			explosion.transform.position = collision.collider.gameObject.transform.position;
			Destroy (collision.collider.gameObject);
			Destroy (this.gameObject);
		}

		if (collision.collider.gameObject.tag != "Enemy") {

			//GameObject son = collision.collider.gameObject.transform.Find ("LuzVerde").gameObject;
			//son.GetComponent <Light> ().color = new Color (0, 0, 1);
			Destroy (this.gameObject);

		}
	}
}
