﻿using UnityEngine;
using System.Collections;

public class Customize_Switch : MonoBehaviour {

	public Button RightArrow;
	public Button LeftArrow;

	// Use this for initialization
	void Start () {
		RightArrow = RightArrow.GetComponent<Button>();
		LeftArrow = LeftArrow.GetComponent<Button>();
	}
	
	public void SinglePress()
	{
		// Change image
		Application.LoadLevel("Calibration");


	}
}