﻿using UnityEngine;
using System.Collections;

public class StartBar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();
			
			if (Physics.Raycast(ray, out hit)){
				GameObject obj = hit.collider.gameObject;
				//Debug.Log(obj.name);
				//Debug.Log(this.name);
				if(obj.name == this.name){
					Debug.Log(obj.name + "hit!");
					Application.LoadLevel("CharacterSelect");
				}
			}
		}
	}
}
