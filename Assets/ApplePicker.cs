using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ApplePicker : MonoBehaviour {
	public GUIText scoreGT;
	public GameObject basketPrefab;
	public int num_baskets = 3;
	public float basketBotY = -14f;
	public float basketSpaY = 2f;
	public List<GameObject> basketList;
	public static int lvl;


	// Use this for initialization
	void Start () {
		lvl = 0;
		basketList = new List<GameObject>();
		for (int i = 0; i < num_baskets; i++) {
			GameObject tBasketGo = Instantiate(basketPrefab) as GameObject;
			Vector3 pos = Vector3.zero;
			pos.y = basketBotY + (basketSpaY * i);
			tBasketGo.transform.position = pos;

			basketList.Add(tBasketGo);
		}
	
	}
	public void AppleDestroyed(){
		GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("apple");
		//had to add handlers for other apple "types"
		GameObject[] tGAppleArray = GameObject.FindGameObjectsWithTag("gapple");
		GameObject[] tBAppleArray = GameObject.FindGameObjectsWithTag("bapple");
		GameObject[] tPAppleArray = GameObject.FindGameObjectsWithTag("papple");
		foreach(GameObject tGo in tAppleArray){
			Destroy(tGo);
		}

		foreach(GameObject tGo in tGAppleArray){
			Destroy(tGo);
		}

		foreach(GameObject tGo in tBAppleArray){
			Destroy(tGo);
		}

		foreach(GameObject tGo in tPAppleArray){
			Destroy(tGo);
		}

		///destroy one basket
		//get index
		int basketIndex = basketList.Count - 1;
		// get a reference to that object
		GameObject tBasketGO = basketList [basketIndex];
		// remove from list and destroy object
		basketList.RemoveAt (basketIndex);
		Destroy (tBasketGO);

		// restart if no baskets left
		if (basketList.Count == 0) {
					Application.LoadLevel ("Scene_0");
				}
	
	}


	// Update is called once per frame
	void Update () {

	
	}

	public int getLvl()
	{

		return lvl;
	}

}
