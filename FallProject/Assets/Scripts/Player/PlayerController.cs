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
	private float moveSpeed = 0.01f;
	[SerializeField]
	private float jumpForce = 100.0f;
	
	private int layerMask = 1 << 8;
	private RaycastHit hit;
	private void Start()
	{
		layerMask = ~layerMask;
	}
	 
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

		if (Input.GetKeyDown("space"))
		{
			Physics.Raycast(playerModel.transform.position, playerModel.transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity, layerMask);
			Debug.DrawRay(playerModel.transform.position, playerModel.transform.TransformDirection(Vector3.down) * hit.distance, Color.red);

			if (hit.distance < 1)
			{
				playerModel.GetComponent<Rigidbody>().AddForce(transform.up * jumpForce);
			}
			
		}
	}

	private void cameraFollow()
	{
		playerCamera.transform.position = Vector3.Slerp(playerCamera.transform.position, new Vector3(playerModel.transform.position.x, playerModel.transform.position.y, playerModel.transform.position.z - 20), 30 * Time.deltaTime);
	}

	private void FixedUpdate()
	{
		playerMovement();
		cameraFollow();
	}
}
