using UnityEngine;
using System.Collections;

public class badApple : MonoBehaviour {
	//Brendan Mulhern
	//last modified 1/20/15
	//Purpose: behavior for bad apple and poison apple objects
	/**this is almost exactly the same as the apple script except it gives 100 points when these objects fall off the screen
	 **/
	public GUIText scoreGT;
	public static float BottomY = -20f;
	
	// Use this for initialization
	void Start () {
		GameObject scoreGO = GameObject.Find ("scoreCounter");
		//cet text component
		scoreGT = scoreGO.GetComponent<GUIText>();

		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < BottomY) {
			Destroy ( this.gameObject);	
			int score = int.Parse(scoreGT.text);
			score += 100;
			scoreGT.text = score.ToString();

			if (score > HighScore.score) {
				HighScore.score = score;
			}
		}
		
	}
}
