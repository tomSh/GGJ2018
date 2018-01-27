using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentacleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		var mousePosition = Input.mousePosition;
		var screenToWorldPoint = Camera.main.ScreenToWorldPoint(mousePosition);
		screenToWorldPoint.z = (float) -0.1f;
		transform.position = screenToWorldPoint;
	}
}
