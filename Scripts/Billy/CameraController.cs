using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
	public Transform player;

	void LateUpdate ()
	{
		transform.position = new Vector3(player.position.x + 10f, 0f, -25f);
	}
}
