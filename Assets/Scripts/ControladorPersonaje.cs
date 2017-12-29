using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControladorPersonaje : MonoBehaviour {


	public float fuerzaSalto = 100f;
	private bool enSuelo = true;
	public Transform comprobadorSuelo;
	private float comprobadorRadio = 0.07f;
	public LayerMask mascaraSuelo;




	private bool corriendo = false;

	//private bool dobleSalto = false;
	public float velocidad = 1f;
	public bool slice = false;
	private Animator animator;

	public float fuerzaslice = -10f;




	public bool DOBLESALTO = false;











	Animator anim;
	//Rigidbody2D rigid;
	
	public bool Deslizar;
	
	public float VelocidadNormal = 5f;
	public float VelocidadQuitaDeslizar = 0.1f;





	void Awake(){
		animator = GetComponent<Animator>();


	}
	
	// Use this for initialization
	void Start () {
		corriendo = true;

		NotificationCenter.DefaultCenter().PostNotification(this,"PersonajeEmpiezaACorrer");

		DOBLESALTO = false;
		Deslizar = true;


		anim = GetComponent<Animator>();
		//rigid = GetComponent<Rigidbody2D>();

		
	}
	
	void FixedUpdate(){

		if (corriendo) {
						rigidbody2D.velocity = new Vector2 (velocidad, rigidbody2D.velocity.y);

					
		}

			





		
		animator.SetFloat ("VelX", rigidbody2D.velocity.x);
		enSuelo = Physics2D.OverlapCircle(comprobadorSuelo.position, comprobadorRadio, mascaraSuelo);
		animator.SetBool("isGrounded", enSuelo);



		if (enSuelo) {
				
			DOBLESALTO = false;
		}



	}
	
	// Update is called once per frame









	IEnumerator Espera()
	{	

		anim.SetBool("Dezlizar",true);
		yield return new WaitForSeconds(1);
		anim.SetBool("Dezlizar", false);
	}
	


	//public void Mostrar()
	//{
	
	//					if (!Deslizar) {
								
	//		rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, fuerzaslice);
	//							StartCoroutine ("Espera");
							
				

							
						
	//			}
	//}

	
	void Update () {
		
		Deslizar = anim.GetBool("Dezlizar");










	if (Input.mousePosition.x < Screen.width / 2) {


			if (Input.GetMouseButtonDown(0)) {
				
				if(!Deslizar){	
					StartCoroutine ("Espera");
				
					
					
				}
			}
	
		}else{


			if (enSuelo && Input.GetMouseButton(0) ) {


				
				rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, fuerzaSalto);
		
			}else{
			
				if(DOBLESALTO){
					
					//	
					if(Input.GetMouseButtonDown(0)){

						//		
						rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, 40);	
			
						//	
						DOBLESALTO = false;
						//	
					}
					//
				}
			}








			//







		
			}

						

					
				
		}		
			
		
		
	}




		




