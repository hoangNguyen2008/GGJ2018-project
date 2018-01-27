﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour 
{
	private LineRenderer lineRenderer;
	public Transform laserHit;

	// Use this for initialization
	void Start () 
	{
		lineRenderer = GetComponent<LineRenderer> ();
		lineRenderer.enabled = false;
		lineRenderer.useWorldSpace = true;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit2D hit = Physics2D.Raycast (transform.position, transform.up);
		Debug.DrawLine (transform.position, hit.point);
		laserHit.position = hit.point;

		lineRenderer.SetPosition (0, transform.position);
		lineRenderer.SetPosition (1, laserHit.position);
		if (Input.GetKey (KeyCode.Space)) {
			lineRenderer.enabled = true;
		} else {
			lineRenderer.enabled = false;
		}
	}
}
