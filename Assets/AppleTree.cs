﻿using UnityEngine;
using System.Collections;
//Brendan Mulhern
//last modified 1/20/15
//Purpose: behavior for the apple tree

public class AppleTree : MonoBehaviour {
	//Prefab for inst apples
	public GameObject applePrefab;
	public GameObject gapplePrefab; //gold apple
	public GameObject papplePrefab; //poison apple (like gold apple but subtracts 1000 points)
	public GameObject bapplePrefab; //bad apple

	//speed at which tree moves
	public float speed = 1f;

	//dist when tree turns around
	public float Left_Right_edge = 10f;

	// chance tree will change direction
	public float chanceToChangeDir = 0.02f;

	//special apple chances
	public float goodAppChan = 0.8f;
	public float gappleChance = 0.01f;
	public float pappleChance = 0.1f;

	//rate at which apples will be instanciated
	public float secBtwnAppleDrops = 1f;

	// Use this for initialization
	void Start() { InvokeRepeating ("DropApple", 2f, secBtwnAppleDrops);
	
	}

	void DropApple(){
		//these are random values to use later
		float chano = Random.value;
		float chan = Random.value;
		// handle the good apples
		if (chano < goodAppChan) {
						if (chan < gappleChance) {
								GameObject gapple = Instantiate (gapplePrefab) as GameObject;
								gapple.transform.position = transform.position;
						} else {
								GameObject apple = Instantiate (applePrefab) as GameObject;
								apple.transform.position = transform.position;
						}
			// else use a bad apple
				} else if (chan < pappleChance) {
						GameObject papple = Instantiate (papplePrefab) as GameObject;
						papple.transform.position = transform.position;
				} else {
			GameObject bapple = Instantiate (bapplePrefab) as GameObject;
			bapple.transform.position = transform.position;

				}

		}
	
	// Update is called once per frame
	void Update () {
		// basic movement
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;
		// cng diretion
		if (pos.x < -Left_Right_edge) {
			speed = Mathf.Abs(speed);//move right
		}
		else if (pos.x > Left_Right_edge){
			speed = -Mathf.Abs(speed);//move left

		}
	
	
}
	void FixedUpdate(){
		// change dir randomly
		if (Random.value < chanceToChangeDir){
			speed *= -1;
		}

	}
}
