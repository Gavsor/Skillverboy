using UnityEngine;
using System.Collections;

public class ActivarBarra : MonoBehaviour {


	Animator anim;
	public bool Activado;

	public bool BarraActivado;



	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		anim.SetBool("Activado", false);
		BarraActivado = false;

	}
	
	// Update is called once per frame
	void Update () {

		Activado = anim.GetBool("Activado");


		if (BarraActivado == true) {
				
			anim.SetBool("Activado",true);

		
		}


	
	}



			
			
		
			
		

}
