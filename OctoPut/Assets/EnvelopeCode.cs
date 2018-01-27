using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvelopeCode : MonoBehaviour {
	private Vector3 DEFAULT_SPAWN = new Vector3(-8.37f, 5f, -0.1f);
	private bool _moveOnMouse = false;
	
	public string Color;

	// Use this for initialization
	void Start ()
	{
		InitAtStart();
	}

	public void InitAtStart()
	{
		_moveOnMouse = false;
		transform.position = DEFAULT_SPAWN;
	}

	// Update is called once per frame
	void Update () {
		if (_moveOnMouse)
		{
			TrackMouse();
		}
	}

	private void TrackMouse()
	{
		var mousePosition = Input.mousePosition;
		var screenToWorldPoint = Camera.main.ScreenToWorldPoint(mousePosition);
		screenToWorldPoint.z = (float) -0.1f;
		transform.position = screenToWorldPoint;
	}

	private void OnMouseDown()
	{
		_moveOnMouse = true;
	}

	private void OnMouseUp()
	{
		_moveOnMouse = false;
	}
}
