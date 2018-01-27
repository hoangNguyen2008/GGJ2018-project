using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
	private LineRenderer mLineRenderer;
	public Transform laserHit;

	void Start ()
	{
		