using UnityEngine;
using System.Collections;

public class badApple : MonoBehaviour {
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
