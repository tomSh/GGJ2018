using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PipeHead : MonoBehaviour
{
	public string Color;

	private void OnCollisionEnter2D(Collision2D other)
	{
		var envelopeCode = other.gameObject.GetComponent<EnvelopeCode>();
		if (envelopeCode != null)
		{
			if (envelopeCode.Color == this.Color)
			{
				ScoreTracker.Success();
				GameObject.Destroy(other.gameObject);
			} else {
				envelopeCode.InitAtStart();
			}
		}
		
	}
}