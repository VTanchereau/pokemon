using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovements : MonoBehaviour {

    public Transform target;
    Camera myCam;

	// Use this for initialization
	void Start () {
        this.myCam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        this.myCam.orthographicSize = Screen.height / 100f;

        if (this.target)
        {
            transform.position = Vector3.Lerp(transform.position, this.target.position, 1f) + new Vector3(0, 0, -10);
        }
    }
}
