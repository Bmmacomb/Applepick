using UnityEngine;
using System.Collections;

public class Basket : MonoBehaviour {
	public GUIText scoreGT;
	//Brendan Mulhern
	//last modified 1/20/15
	//Purpose: behavior for the basket and some of the scoreing



	
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
			if (score > HighScore.score) {
				HighScore.score = score;
			}
				}

		if (collidedWith.tag == "gapple") {
			Destroy (collidedWith);
			int score = int.Parse(scoreGT.text);
			score += 1000;
			scoreGT.text = score.ToString();
			if (score > HighScore.score) {
				HighScore.score = score;
			}
		}


		if (collidedWith.tag == "bapple") {
			Destroy (collidedWith);
			int score = int.Parse(scoreGT.text);
			score = score - 100;
			if (score < 0){
				score = 0;}

			scoreGT.text = score.ToString();


			if (score > HighScore.score) {
				HighScore.score = score;
			}
		}



		if (collidedWith.tag == "papple") {
			Destroy (collidedWith);
			int score = int.Parse(scoreGT.text);
			score = score - 1000;
			if (score < 0){
				score = 0;}
			scoreGT.text = score.ToString();

			if (score > HighScore.score) {
				HighScore.score = score;
			}
		}


	}
}
