using UnityEngine;
using System.Collections;
                               
public class CambiadorNiveles : MonoBehaviour {

	GameObject = GameObject.Find("EquipoRosa");
	GameObject = GameObject.Find("EquipoAzul");
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (contador >= 5) {
			Application.LoadLevel("EscenarioNave");
		}
	}

}
