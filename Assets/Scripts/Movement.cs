using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	float Speed = 0.1f;
	float jumpSpeed = 0.2f;

	void Update () {
		{
			if (Input.GetKey("a") )
			{
				transform.position = new Vector2 (transform.position.x - Speed,transform.position.y);
			}
			if ( Input.GetKey("d") )
			{
				transform.position = new Vector2 (transform.position.x + Speed,transform.position.y);
	}
			if (Input.GetKey ("space")) {	
				transform.position = new Vector2 (transform.position.x, transform.position.y + jumpSpeed);
			}
}
	}
}