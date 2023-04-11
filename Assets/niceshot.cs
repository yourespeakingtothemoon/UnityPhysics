using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class niceshot : MonoBehaviour
{
	[SerializeField] AudioSource a;
	[SerializeField] AudioSource b;


	//when colliding with a "nice" object play both sounds
	void OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.tag == "Player")
		{
		
			a.Play();
			b.Play();
		}
		if (collision.gameObject.tag == "nice")
		{
			a.Play();
			b.Play();
		}
	}
}

