using UnityEngine;
using System.Collections;
//Brendan Mulhern
//last modified 1/20/15
//Purpose: behavior for apple and gold apple (gapple) objects

public class Apple : MonoBehaviour {
	public static float BottomY = -20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < BottomY) {
			Destroy ( this.gameObject);	
			// get ref to ApplePicker component of main camera
			ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
			// call appledestroyed
			apScript.AppleDestroyed();
		}
	
	}
}
