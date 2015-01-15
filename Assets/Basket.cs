﻿using UnityEngine;
using System.Collections;

public class Basket : MonoBehaviour {
	public GUIText scoreGT;



	
	// Update is called once per frame
	void Update () {
		//get mouse pointer's current position
		Vector3 mousePos2D = Input.mousePosition;
		// z position
		mousePos2D.z = -Camera.main.transform.position.z;
		// convert from 2d screen space to 3d game space
		Vector3 mousePos3D = Camera.main.ScreenToWorldPoint (mousePos2D);
		//move basket to x pos of mouse
		Vector3 pos = this.transform.position;
		pos.x = mousePos3D.x;
		this.transform.position = pos;
	
	}
	void Start(){
		//find ref to score counter
		GameObject scoreGO = GameObject.Find ("scoreCounter");
		//cet text component
		scoreGT = scoreGO.GetComponent<GUIText>();
		scoreGT.text = "0";
	}

	void OnCollisionEnter(Collision coll){
				//find out what hit basket
				GameObject collidedWith = coll.gameObject;
				if (collidedWith.tag == "apple") {
						Destroy (collidedWith);
			int score = int.Parse(scoreGT.text);
			score += 100;
			scoreGT.text = score.ToString();
				}

		if (collidedWith.tag == "gapple") {
			Destroy (collidedWith);
			int score = int.Parse(scoreGT.text);
			score += 1000;
			scoreGT.text = score.ToString();
		}
		}
}
