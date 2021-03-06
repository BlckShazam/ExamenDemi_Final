﻿     using UnityEngine;
using System.Collections;

public class Player01 : MonoBehaviour {
	private Rigidbody2D rb;
	public float velocidad = 5f;
	public float fuerza = 10;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			movimientoDerecha ();
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			movimientoIzquierda ();
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			movimientoArriba ();
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			movimientoAbajo ();
		}
	}
	void movimientoDerecha (){
		rb.velocity = new Vector2(velocidad*fuerza, rb.velocity.y);
		transform.localScale = new Vector3(1,1,1);
		} 

	void movimientoIzquierda(){
		rb.velocity = new Vector2 (-velocidad * fuerza, rb.velocity.x);
		transform.localScale = new Vector3 (-1, 1, 1);
		}

	void movimientoArriba (){
		rb.velocity = new Vector2 (0, velocidad * fuerza);
		transform.localScale = new Vector3 (1, 1, 1);
		}
		void movimientoAbajo (){
			rb.velocity = new Vector2(0, -velocidad*fuerza);
			transform.localScale = new Vector3(1,-1,1);
		}
}