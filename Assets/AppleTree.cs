using UnityEngine;
using System.Collections;

public class AppleTree : MonoBehaviour {
	//Prefab for inst apples
	public GameObject applePrefab;

	//speed at which tree moves
	public float speed = 1f;

	//dist when tree turns around
	public float Left_Right_edge = 10f;

	// chance tree will change direction
	public float chanceToChangeDir = 0.02f;

	//rate at which apples will be instanciated
	public float secBtwnAppleDrops = 1f;

	// Use this for initialization
	void Start() { InvokeRepeating ("DropApple", 2f, secBtwnAppleDrops);
	
	}

	void DropApple(){
		GameObject apple = Instantiate(applePrefab) as GameObject;
		apple.transform.position = transform.position;
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
