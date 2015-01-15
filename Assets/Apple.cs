using UnityEngine;
using System.Collections;

public class Apple : MonoBehaviour {
	public static float BottomY = -20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < BottomY) {
			Destroy ( this.gameObject);		
		}
	
	}
}
