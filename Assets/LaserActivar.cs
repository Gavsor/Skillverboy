using UnityEngine;
using System.Collections;

public class LaserActivar : MonoBehaviour {
	public ItemActivar ItemActivar;
	Animator anim;
	public bool activado;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();


		if (activado == false) {
			anim.SetBool ("laserActivado", false);
			anim.SetBool ("LaserDesaparecido",true);
				}


		if(activado == true){
			anim.SetBool ("laserActivado", true);
			anim.SetBool ("LaserDesaparecido",false);

					
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (ItemActivar.itemactivado == true) {
				
			if(activado == false){

			anim.SetBool ("laserActivado", true);
				anim.SetBool ("LaserDesaparecido",false);
			}


			if(activado == true){
			
				anim.SetBool ("laserActivado", false);
				anim.SetBool ("LaserDesaparecido",false);

					
			}




		
		}
	}
}
