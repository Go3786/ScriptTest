using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//順番に表示
		int[] array = new int[5];
		array [0] = 35;
		array [1] = 60;
		array [2] = 45;
		array [3] = 80;
		array [4] = 10;
		for (int a = 0; a <4; a++) {
			Debug.Log (array [a]);
		}
		//逆順に表示
		for (int b = 4;b>=0;b--){
			Debug.Log (array [b]);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
