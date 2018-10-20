﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickedUp : MonoBehaviour {
	public	bool playerHasItem;
	public bool interactuable = false;
	// Use this for initialization
	void Start () {
		playerHasItem = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (interactuable==true) {
			if (Input.GetKeyDown ("k")) {
				PlayerPickedItem ();
			}
		}
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag ("Player") == true) {
			interactuable = true;
		}
	}
	void OnTriggerExit2D(Collider2D col)
	{
		interactuable =false;
	}
	public void PlayerPickedItem (){
		this.gameObject.GetComponent<SpriteRenderer>().enabled = false;	
		this.gameObject.GetComponent<CircleCollider2D>().enabled = false;	
		playerHasItem = true;
		print ("agarre item");
	}
	public bool CheckItemIsPicked(){
		return playerHasItem;
	}
}
