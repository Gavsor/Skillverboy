using UnityEngine;
using System.Collections;

public class SaludVeloz : MonoBehaviour {

	public GameObject MenuMuerteUI;

	public GameObject PanelTienda;


	
	public int ps = 2;
	public float velocidad = 5f;
	public bool esEnemigo = true;
	//float timejuego = 5f;
	Animator anim;
	public bool Muerto;
	
	public AudioSource musicaapagado;
	
	private ScoreManager theScoreManager;

	public CameraFollow camerafollow;
	
	public GameObject Veloz;
	void Start () {
		anim = GetComponent<Animator>();
		//MenuMuerteUI.SetActive (false);
		theScoreManager = FindObjectOfType<ScoreManager> ();
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		Muerto = anim.GetBool("Muerto");
		//timejuego = Time.deltaTime;
		
		
		
		if (ps <= 0) {

			Veloz.SetActive(false);
			theScoreManager.scoreInscreasing = false;
			anim.SetBool("Muerto", true);
			EfectosEspecialesScript.Instancia.Explosion(transform.position);

			
			Invoke("Muerte",1);
		
			
			
			
			
		}
		
	}
	
	
	
	
	
	void OnTriggerEnter2D(Collider2D collider)
	{		
		DisparoScript disparo = collider.gameObject.GetComponent<DisparoScript> ();
		if (disparo != null) {
			if (disparo.esDisparoEnemigo != esEnemigo) {
				ps -= disparo.danho;
				//Destroy (disparo.gameObject);
				
				
				if (ps <= 0) {
					EfectosEspecialesScript.Instancia.Explosion(transform.position);
					anim.SetBool("Muerto", true);
					
					
				}
				
				
				
				
			}
		}
		
	}
	
	
	
	
	
	void FixedUpdate(){
		
		if (Muerto) {
			rigidbody2D.velocity = new Vector2 (velocidad, rigidbody2D.velocity.y);
			
		}
		
		
		
		anim.SetFloat ("VelX", rigidbody2D.velocity.x);
		
	}
	
	
	void Muerte(){
		

		//NotificationCenter.DefaultCenter ().PostNotification (this, "PersonajeHaMuerto");
		//GameObject personaje = GameObject.Find ("Veloz");

		Time.timeScale = 0;
		//Destroy (personaje.gameObject);

		MenuMuerteUI.SetActive(true);
			
		
		//musicaapagado.audio.Stop();
		
		camerafollow.enabled = false;
		
	}	


	public void Revivir(){

				if (PlayerPrefs.GetInt ("corazon") >= 1) {

						PlayerPrefs.SetInt ("corazon", PlayerPrefs.GetInt ("corazon") - 1);
						anim.SetBool ("Muerto", false);
						Veloz.SetActive (true);
						Veloz.transform.position = new Vector3 (816.29f, 1.2f, -0.6f);
		
		
						ps = 1;
						MenuMuerteUI.SetActive (false);
						camerafollow.enabled = true;

				} else if (PlayerPrefs.GetInt ("corazon") == 0) {
						PanelTienda.SetActive(true);
				}
		}

	public void corazon(){
			// Mas corazones
	//	PlayerPrefs.SetInt ("corazon", PlayerPrefs.GetInt ("corazon") + 1);
		anim.SetBool ("Muerto", false);
		Veloz.SetActive (true);
		Veloz.transform.position = new Vector3 (816.29f, 1.2f, -0.6f);
		ps = 1;
		MenuMuerteUI.SetActive (false);
		camerafollow.enabled = true;
		PanelTienda.SetActive(false);
	}

	// Use this for initialization
	
}