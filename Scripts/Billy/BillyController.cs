﻿using UnityEngine;
using System.Collections;

public class BillyController : MonoBehaviour
{
	public float life = 100f;
	public float speed = 10f;
	public float jumpStrength = 10f;

	private bool isDead;
	private bool isGrounded;

	private float h;
	private float v;
	private Rigidbody playerRigidbody;

	private void Start ()
	{
		playerRigidbody = GetComponent<Rigidbody> ();
		isGrounded = false;
	}

	private void FixedUpdate ()
	{
		h = Input.GetAxis ("Horizontal");
		v = Input.GetAxis("Vertical");

		if(!isDying()){
			move();
			if(Input.GetKey(KeyCode.Space))
				jump();
		}
	}

	private void move()
	{
		playerRigidbody.MovePosition (new Vector3(h * speed * Time.deltaTime + transform.position.x, transform.position.y, v * speed * Time.deltaTime + transform.position.z));
	}

	private void jump()
	{
		if (isGrounded) {
			playerRigidbody.AddForce (new Vector3 (0f, jumpStrength * 10000f, 0f));
			isGrounded = false;
		}
	}

	private bool isDying()
	{
		return isDead = life <= 0f;
	}
	
	private void OnCollisionEnter(Collision other)
	{
		isGrounded = other.gameObject.tag == "Ground" || isGrounded;
	}
	
	private void OnCollisionExit(Collision other)
	{
		isGrounded = !(other.gameObject.tag == "Ground") && isGrounded;
	}
}



















