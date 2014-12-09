using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public float speed;
	
	private Vector2 currentDirection = Vector2.zero;
	// Update is called once per frame
	void Update () {

		//if (currentDirection.Equals(Vector2.zero))
		//{
			Vector2 inputDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
			if (!inputDirection.Equals(Vector2.zero))
			{
				currentDirection = inputDirection;
				this.rigidbody2D.velocity = currentDirection * speed;
			}
		//}
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		currentDirection = Vector3.zero;
		this.rigidbody2D.velocity = Vector3.zero;
	}
}