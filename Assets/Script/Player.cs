using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	private float _moveSpeed = 2;
	private Rigidbody2D _myRig;

	private void Start()
	{
		_myRig = gameObject.GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		float myInput = Input.GetAxisRaw("Horizontal");


		if (myInput <=0 )
		{
			_myRig.velocity = new Vector2(  myInput * _moveSpeed, _myRig.velocity.y);
		}

		if (myInput > 0)
		{
			_myRig.velocity = new Vector2(myInput * _moveSpeed, _myRig.velocity.y);
		}

	}


}
