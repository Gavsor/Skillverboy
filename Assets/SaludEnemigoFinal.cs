using UnityEngine;
using System.Collections;

public class SaludEnemigoFinal : MonoBehaviour {
	
	public int ps = 5;
	Animator anim;
	public bool Muriendo;


	public bool Muerto;

	
	
	public bool esEnemigo = true;
	
	public GameObject Enemigo;

	
	public PlataformaMovil plataformamovil;
	
	
	
	
	public VidaEnemigoBarra vida1;
	public VidaEnemigoBarra vida2;
	public VidaEnemigoBarra vida3;
	public VidaEnemigoBarra vida4;
	public VidaEnemigoBarra vida5;


	public GameObject Explosion1;
	public GameObject Explosion2;
	public GameObject Explosion3;
	public GameObject Explosion4;
	public GameObject Explosion5;


	public GameObject CuerpoBrazo;

	Rigidbody2D rb2d;

	public GameObject GeneradorBola;
	public GameObject BolaRoja;

	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator>();
		anim.SetBool ("FueAtacado", false);
		Muriendo = false;
		anim.SetBool ("Muerto", false);
		Muerto = false;


	}
	
	// Update is called once per frame
	void Update () {
		if (Muriendo == true) {
			anim.SetBool ("FueAtacado", true);
			
		}

		if (Muerto == true) {
			anim.SetBool ("Muerto",true);		
		}
	}
	
	IEnumerator MuereEnemigo()
	{	
		
		
		Explosion5.SetActive(false);
		Muerto = true;
		BolaRoja.SetActive (false);
		yield return new WaitForSeconds(2.2f);
		rb2d.gravityScale = 0;
		plataformamovil.enabled = false;
		yield return new WaitForSeconds(1.9f);
		Enemigo.SetActive(false);
		Destroy(Enemigo);

	
	

		
	}

	IEnumerator DesactivarExplosiones()
	{	
		


		Explosion4.SetActive(true);
		yield return new WaitForSeconds(0.05f);
		Explosion3.SetActive(true);
		yield return new WaitForSeconds(0.09f);
		Explosion2.SetActive(true);
		yield return new WaitForSeconds(0.03f);
		Explosion1.SetActive(true);
		yield return new WaitForSeconds(0.09f);
		Destroy(GeneradorBola);

		Explosion4.SetActive(false);
		yield return new WaitForSeconds(0.09f);
		Explosion3.SetActive(false);
		yield return new WaitForSeconds(0.09f);
		Explosion2.SetActive(false);
		yield return new WaitForSeconds(0.09f);
		Explosion1.SetActive(false);
		yield return new WaitForSeconds(0.09f);


		Explosion4.SetActive(true);
		yield return new WaitForSeconds(0.09f);
		Explosion3.SetActive(true);
		yield return new WaitForSeconds(0.09f);
		Explosion2.SetActive(true);
		yield return new WaitForSeconds(0.09f);
		Explosion1.SetActive(true);
		yield return new WaitForSeconds(0.09f);
		
		
		Explosion4.SetActive(false);
		yield return new WaitForSeconds(0.09f);
		Explosion3.SetActive(false);
		yield return new WaitForSeconds(0.09f);
		Explosion2.SetActive(false);
		yield return new WaitForSeconds(0.09f);
		Explosion1.SetActive(false);
		yield return new WaitForSeconds(0.09f);


		
		Explosion4.SetActive(true);
		yield return new WaitForSeconds(0.09f);
		Explosion3.SetActive(true);
		yield return new WaitForSeconds(0.09f);
		Explosion2.SetActive(true);
		yield return new WaitForSeconds(0.09f);
		Explosion1.SetActive(true);
		yield return new WaitForSeconds(2.09f);
		
		
		Explosion4.SetActive(false);
		yield return new WaitForSeconds(2.09f);
		Explosion3.SetActive(false);
		yield return new WaitForSeconds(2.09f);
		Explosion2.SetActive(false);
		yield return new WaitForSeconds(2.09f);
		Explosion1.SetActive(false);
		yield return new WaitForSeconds(2.01f);




		Explosion5.SetActive(true);
		yield return new WaitForSeconds(0.35f);

		Explosion5.SetActive(false);


		
		
		
	}



	
	void OnTriggerEnter2D(Collider2D collider)
	{		
		DisparandoScript disparo = collider.gameObject.GetComponent<DisparandoScript>();
		if (disparo != null) {
			if (disparo.esDisparoEnemigo != esEnemigo) {
				ps -= disparo.danho;
				
				//Destroy (disparo.gameObject);
				
				if (ps <= 0) {
					EfectosEspecialesScript.Instancia.Explosion(transform.position);
					vida1.Apagado = true;
					
					NotificationCenter.DefaultCenter().PostNotification(this,"PersonajeHaMuerto");
					//GameObject personaje = GameObject.Find("Enemigo");
					StartCoroutine ("MuereEnemigo");
					StartCoroutine("DesactivarExplosiones");
					




					
					
					
				}
				
				
				
				
				
				
				
				
				if (ps == 4) {
					EfectosEspecialesScript.Instancia.Explosion(transform.position);

					vida5.Apagado = true;
					Explosion1.SetActive(true);
					Muriendo = true;

				}
				
				
				if (ps == 3) {
					EfectosEspecialesScript.Instancia.Explosion(transform.position);
					vida4.Apagado = true;
					Explosion2.SetActive(true);



					Explosion1.SetActive(false);

				}
				
				if (ps == 2) {
					EfectosEspecialesScript.Instancia.Explosion(transform.position);
					vida3.Apagado = true;
					Explosion3.SetActive(true);
					CuerpoBrazo.SetActive(false);




					Explosion2.SetActive(false);
					Explosion1.SetActive(false);
				}
				
				
				if (ps == 1) {
					EfectosEspecialesScript.Instancia.Explosion(transform.position);
					vida2.Apagado = true;
					Explosion4.SetActive(true);


					Explosion3.SetActive(false);

				}
				
				
				
				
				
				
				
				
				
				
			}
			
		}
	}
	
	
	// Use this for initialization

}
