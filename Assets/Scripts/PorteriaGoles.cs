using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PorteriaGoles : MonoBehaviour {
	public Text texto;

	public int contador = 0;
	Text TextoContador;
	// Use this for initialization
	void Start () {
		TextoContador = GetComponent<Text> ();

		TextoContador.text = contador + "ROSAS";
	}
	
	// Update is called once per frame
	void Update () {
		if (contador <= 5) {
			contador++;
		}
	
	}
}
