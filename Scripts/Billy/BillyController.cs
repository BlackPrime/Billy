using UnityEngine;
using System.Collections;

public class BillyController : MonoBehaviour
{
	public float life = 100f;
	public float speedX = 100f;
	public float speedY = 10f;
	public float jumpStrength = 10f;

	private bool isDead;
	private bool isGrounded;

	private float h;
	private float v;
	private float j;
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
		j = Input.GetAxis("Jump");

		if(!isDying()){
			move();
			if(j > 0f)
				jump();
		}
	}

	private void move()
	{
		playerRigidbody.MovePosition (new Vector3(h * speedX * Time.deltaTime + transform.position.x, transform.position.y, v * speedY * Time.deltaTime + transform.position.z));
		if (h < 0)
			playerRigidbody.transform.LookAt (transform.position - new Vector3 (0f, 0f, 1f));
		else if(h > 0)
			playerRigidbody.transform.LookAt (transform.position + new Vector3 (0f, 0f, 1f));
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




















