using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	public Texture2D cursorTexture;
	public Vector2 offset = Vector2.zero;

	void Start()
	{
		Cursor.SetCursor(cursorTexture, offset, CursorMode.ForceSoftware);
	}
}
