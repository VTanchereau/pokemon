﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class GameManager : MonoBehaviour
{
	public static GameManager instance = null;

	void Awake()
	{
		if (instance == null) {
			instance = this;
		} 
		else if (instance != this) {
			Destroy (gameObject);   
		}
	}
}