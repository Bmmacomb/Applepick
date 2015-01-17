using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {
	static public int score = 1000;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GUIText gt = this.GetComponent<GUIText>();
		gt.text = "High Score: " + score;

		if (score > PlayerPrefs.GetInt ("ApplePickerHighScore")) {
				
						PlayerPrefs.SetInt ("ApplePickerHighScore", score);
				}
	}

	void Awake(){
		// if APPLEpickerHS exists load it
		if (PlayerPrefs.HasKey ("ApplePickerHighScore")) {
			score = PlayerPrefs.GetInt("ApplePickerHighScore");
		}
		// assign it to player prefs
		PlayerPrefs.SetInt ("ApplePickerHighScore", score);
	}

}
