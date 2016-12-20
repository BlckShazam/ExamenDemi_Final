using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PorteriaGoles : MonoBehaviour {
	
	public int contador = 0;
	Text TextoContador;
	// Use this for initialization
	void Start () {
		TextoContador = GetComponent<Text> ();

		TextoContador.text = contador + "ROSAS";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2d (Collider2D objeto){
		if (objeto.tag == "Pelota" && contador<=5) {
			contador++;
		}
	}
}
