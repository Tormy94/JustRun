using UnityEngine;
using System.Collections;
using System;

public class SaltoLeonardo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		if(collider.tag == "Leonardo"){
			NotificationCenter.DefaultCenter().PostNotification(this, "SaltoLeonardo");
			Destroy(gameObject);
		}

	}
}
