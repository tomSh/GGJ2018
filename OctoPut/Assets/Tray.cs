using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters;
using UnityEngine;

public class Tray : MonoBehaviour
{
	public GameObject[] envelops;
	public GameObject Fish;
	private float _time = 5;
	private double _spawnTime = 5;
	private double exceleration = 0.02;
	private int _phisingChance = 10;
	private double _minimunSpawn = 0.10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		_time += Time.deltaTime;
		if (_time > _spawnTime)
		{
			_time = 0;
			if (_spawnTime > _minimunSpawn)
			{
				_spawnTime = _spawnTime - exceleration;
			}

			if (shouldPhish())
			{
				SpwanPhish();
			}
			else
			{
				_phisingChance++;
				SpawnEnveope();
			}
				
		}

		CheckMenuOption();
	}

	private static void CheckMenuOption()
	{
		if (Input.GetKeyDown(KeyCode.R))
		{
			Application.LoadLevel(Application.loadedLevel);
		}

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}

	private void SpwanPhish()
	{
		GameObject.Instantiate(Fish);
	}

	private bool shouldPhish()
	{
		var i = Random.Range(0, 99);
		return i < _phisingChance;
	}

	private void SpawnEnveope()
	{
		var i = Random.Range(0, envelops.Length);
		GameObject.Instantiate(envelops[i]);
	}
}
