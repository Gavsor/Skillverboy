using UnityEngine;
using System.Collections;

public class ActivarElectricidad : MonoBehaviour {

	 Animator anim;

	public bool CorrienteDesactivada;
	public ActivarBarra ActivarBarra;
	public bool CorrienteActivada = false;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		anim.SetBool ("CorrienteDesactivada", true);
		CorrienteActivada = false;
	}
	
	// Update is called once per frame
	void Update () {

		CorrienteDesactivada = anim.GetBool ("CorrienteDesactivada");


		if(CorrienteActivada == true){
			StartCoroutine ("Espera");
		
		}



			
		}




	IEnumerator Espera()
	{	
		
		anim.SetBool("CorrienteDesactivada",true);
		yield return new WaitForSeconds(0.2f);
		anim.SetBool("CorrienteDesactivada",false);
	}





	}





