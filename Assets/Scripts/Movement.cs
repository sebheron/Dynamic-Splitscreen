using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	//Get the keycodes for all the various directions of movement.
	public KeyCode Forward;
	public KeyCode Backward;
	public KeyCode Left;
	public KeyCode Right;

	void FixedUpdate () {
		//Modify the players position relative to the key pressed.
		if (Input.GetKey (Forward))
			transform.position += Vector3.forward/10;
		else if (Input.GetKey (Backward))
			transform.position += Vector3.back/10;
		if (Input.GetKey (Left))
			transform.position += Vector3.left/10;
		else if (Input.GetKey (Right))
			transform.position += Vector3.right/10;
	}
}
