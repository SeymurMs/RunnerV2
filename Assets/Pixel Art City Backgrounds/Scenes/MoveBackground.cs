﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour {



	public float speed;
	private float x;
	public float PontoDeDestino;
	public float PontoOriginal;



	// Use this for initialization
	void Start () {
		//PontoOriginal = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {


		x = transform.localPosition.x;
		x += speed * Time.deltaTime;

        transform.localPosition = new Vector3 (x, transform.localPosition.y, transform.localPosition.z);



		if (x <= PontoDeDestino){

			x = PontoOriginal;
			transform.localPosition = new Vector3 (x, transform.localPosition.y, transform.localPosition.z);
		}


	}
}
