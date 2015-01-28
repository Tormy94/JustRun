﻿using UnityEngine;
using System.Collections;

public class Destructor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		string tag = other.tag;
		switch (tag) {
		case "Player":
			NotificationCenter.DefaultCenter().PostNotification(this,"PersonajeHaMuerto");
			GameObject oscar = GameObject.Find("Player");
			//GameObject leo = GameObject.Find("Leonardo");
			//leo.SetActive(false);
			oscar.SetActive(false);
			break;
		case "Leonardo":
			//Quitar comentarios cuando hagamos la implementacion del contador de Leonardo
		//	NotificationCenter.DefaultCenter().PostNotification(this, "LeonardoHaMuerto");
			//Destroy (other.gameObject);
			break;
		default: 
			Destroy (other.gameObject);
			break;
		}
	}
}
