using UnityEngine;
using System.Collections;

public class PeligroAviso : MonoBehaviour {

	Animator anim;
	public bool Activado;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		anim.SetBool("Activado", false);
		Activado = false;

		
	}
	
	// Update is called once per frame
	void Update () {
		
		Activado = anim.GetBool("Activado");
		
		
		if (Activado == true) {
			
			anim.SetBool("Activado",true);
			
			
		}
		

}

	void OnTriggerEnter2D(Collider2D cambio){

		if (cambio.tag == "Balita") {
			
			
			anim.SetBool("Activado",true);
		}
			
		}

}
