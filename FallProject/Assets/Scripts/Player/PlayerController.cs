using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField]
	private GameObject playerModel;
	[SerializeField]
	private GameObject playerCamera;

	[SerializeField]
	private float moveSpeed = 0.1f;

	private void playerMovement()
	{
		if (Input.GetKey("d"))
		{
			playerModel.transform.position = new Vector3(playerModel.transform.position.x + moveSpeed, playerModel.transform.position.y, playerModel.transform.position.z);
		}

		if (Input.GetKey("a"))
		{
			playerModel.transform.position = new Vector3(playerModel.transform.position.x - moveSpeed, playerModel.transform.position.y, playerModel.transform.position.z);
		}
	}

	private void Update()
	{
		playerMovement();
	}
}
