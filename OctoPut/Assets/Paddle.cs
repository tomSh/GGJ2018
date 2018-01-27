using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
	public string Key;
	public int Thrust;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(Key))
		{
			PushPaddle();
		}

	}

	private void OnMouseDown()
	{
		PushPaddle();
	}

	private void PushPaddle()
	{
		gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * Thrust * 100);
	}
}
