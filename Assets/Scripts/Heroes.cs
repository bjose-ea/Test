﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum HeroType
{
	BLUE = 0,
	BROWN = 1,
	GREEN = 2,
	RED = 3,
	VIOLET = 4,
	YELLOW = 5
}


public class Heroes : MonoBehaviour
{
	public HeroType heroType;
//	public string type;
	public Slot currentSlot;
	public Slot destinationSlot;
	public int id;
	//public bool
	public float Health = 100;
	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.W)) {
			GotMatch (3);

		}
	}

	public void GotMatch (int counter)
	{

		if (counter == 3) {
			match3Action ();
		} else if (counter == 4) {
			match4Action ();
		} else if (counter == 5) {
			//Action 3
		} else if (counter == 6) {
			//Action 4
		}
	}

	void match3Action ()
	{
		if (heroType == HeroType.YELLOW) {
			
		}
		Debug.Log ("Doaction");
	}

	void match4Action ()
	{
		if (heroType == HeroType.YELLOW) {

		}

	}

	void decreaseHealth (float damage)
	{
		
	}
}
