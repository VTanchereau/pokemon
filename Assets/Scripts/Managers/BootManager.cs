using UnityEngine;
using System.Collections;


public class BootManager : MonoBehaviour 
{
	public GameObject gameMgr;
	public GameObject UIMgr;
	public GameObject soundMgr;

	void Awake ()
	{
		if (GameManager.instance == null) {
			Instantiate (gameMgr);
		}
		if (UIManager.instance == null) {
			Instantiate (UIMgr);
		}
		if (SoundManager.instance == null) {
			Instantiate(soundMgr);
		}

		Destroy(gameObject);
	}
}