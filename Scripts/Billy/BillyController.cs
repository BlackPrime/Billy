using UnityEngine;
using System.Collections;

public class BillyController : MonoBehaviour
{

	private float h;
	private float v;
	private Rigidbody2D playerRigidbody;

	private void Start ()
	{
		playerRigidbody = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate ()
	{
		
	}
}
