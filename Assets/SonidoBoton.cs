using UnityEngine;
using System.Collections;

public class SonidoBoton : MonoBehaviour {

	public AudioSource boton;

	// Use this for initialization
	void Start () {
	
		boton.audio.Play ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
