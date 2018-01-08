using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class UIManager : MonoBehaviour
{
	public static UIManager instance = null;

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