using UnityEngine;
using System.Collections;

public class ApplePicker : MonoBehaviour {
	public GameObject basketPrefab;
	public int num_baskets = 3;
	public float basketBotY = -14f;
	public float basketSpaY = 2f;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < num_baskets; i++) {
			GameObject tBasketGo = Instantiate(basketPrefab) as GameObject;
			Vector3 pos = Vector3.zero;
			pos.y = basketBotY + (basketSpaY * i);
			tBasketGo.transform.position = pos;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
