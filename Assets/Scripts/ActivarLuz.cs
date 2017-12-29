using UnityEngine;
using System.Collections;

public class ActivarLuz : MonoBehaviour {
	Animator anim;
	

	public bool LuzActivada ;
	public bool LuzActivadaa = false;
	
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();


	}
	
	// Update is called once per frame
	void Update () {
		
		LuzActivada = anim.GetBool ("LuzActivada");
		
		
	//	if (LuzActivadaa == true) {
						
	//		anim.SetBool("LuzActivada",true);
		
	//	}


		
		
		
		
	}

	void OnTriggerEnter2D(Collider2D cambio){
		if (cambio.tag == "Player") {
			

			StartCoroutine ("Espera");
			
		}
		
		
		
	}



	
	
	
	
IEnumerator Espera()
	{	
		//LuzActivadaa = true;
		anim.SetBool("LuzActivada",true);
		yield return new WaitForSeconds(2f);
		anim.SetBool("LuzActivada",false);
		//LuzActivadaa = false;
	}
	
	

}
