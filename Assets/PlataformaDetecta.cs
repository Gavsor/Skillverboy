using UnityEngine;
using System.Collections;
using System;



public class PlataformaDetecta : MonoBehaviour {

	public float VelocidadH = 0.3f;
	
	public DireccionH SentidoH = DireccionH.Derecha;
	
	public float VelocidadV = 0.0f;
	
	public DireccionV SentidoV = DireccionV.Arriba;
	
	public float MaxRecorridoPingPong = 5.0f;
	
	
	private Transform PlatformTransform;
	private float WalkedDistanceH = 0.0f;
	private float WalkedDistanceV = 0.0f;
	private float ReferencePingPongHPosition;
	private float ReferencePingPongVPosition;
	
	private Vector3 InitialPlatformPosition;
	

	
	public float VelocidadHLuego = 0.3f;
	public float VelocidadVLuego = 0.0f;

	public float limitedistancia = 5f;


	public PlataformaDetecta plataformadetecta;


	public float semueveen = 0f;

	
	// Use this for initialization
	void Start () {
		
		
		PlatformTransform = transform;
		
		InitialPlatformPosition = PlatformTransform.position;
		ReferencePingPongHPosition = PlatformTransform.position.x;
		ReferencePingPongVPosition = PlatformTransform.position.y;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		// Calculamos la distancia horizontal recorrida desde el último rebote
		WalkedDistanceH = Math.Abs(PlatformTransform.position.x - ReferencePingPongHPosition);
		
		// Calculamos la distancia vertical recorrida desde el último rebote
		WalkedDistanceV = Math.Abs(PlatformTransform.position.y - ReferencePingPongVPosition);
		
		if (MaxRecorridoPingPong != -1 && WalkedDistanceH >= MaxRecorridoPingPong)
		{
			// Si la función de Ping-Pong esta activada y se ha hecho el máximo recorrido en horizontal, la plataforma cambia de sentido
			if (SentidoH == DireccionH.Izquierda)
			{
				SentidoH = DireccionH.Derecha;
			}
			else
			{
				SentidoH = DireccionH.Izquierda;
			}
			
			// Actualizamos la posición horizontal de referencia para el cálculo de rebote horizontal (ping-pong)
			ReferencePingPongHPosition = PlatformTransform.position.x;
		}
		
		if (MaxRecorridoPingPong != -1 && WalkedDistanceV >= MaxRecorridoPingPong)
		{
			// Si la función de Ping-Pong está activada y se ha hecho el máximo recorrido en vertical, la plataforma cambia de sentido
			if (SentidoV == DireccionV.Arriba)
			{
				SentidoV = DireccionV.Abajo;
			}
			else
			{
				SentidoV = DireccionV.Arriba;
			}
			
			// Actualizamos la posicion vertical de referencia para el calculo de rebote vertical (ping-pong)
			ReferencePingPongVPosition = PlatformTransform.position.y;
		}
		
		// Configuramos el sentido del movimiento horizontal
		if (SentidoH == DireccionH.Izquierda)
		{
			VelocidadH = -Math.Abs(VelocidadH);
		}
		else
		{
			VelocidadH = Math.Abs(VelocidadH);
		}
		
		// Configuramos el sentido del movimiento vertical
		if (SentidoV == DireccionV.Abajo)
		{
			VelocidadV = -Math.Abs(VelocidadV);
		}
		else
		{
			VelocidadV = Math.Abs(VelocidadV);
		}
		
		// Movemos la plataforma
		PlatformTransform.Translate(new Vector3(VelocidadH, VelocidadV, 0) * Time.deltaTime);
	}



	void OnTriggerEnter2D(Collider2D cambio){
		if (cambio.tag == "Player") {
			


			Invoke("empiezamover",semueveen);




			



		}
	}
	
	

	void empiezamover(){
	
		if (SentidoH == DireccionH.Izquierda)
		{
			VelocidadH = -Math.Abs(VelocidadHLuego);
		}
		else
		{
			VelocidadH = Math.Abs(VelocidadHLuego);
		}
		
		// Configuramos el sentido del movimiento vertical
		if (SentidoV == DireccionV.Abajo)
		{
			VelocidadV = -Math.Abs(VelocidadVLuego);
		}
		else
		{
			VelocidadV = Math.Abs(VelocidadVLuego);
		}
		
		// Movemos la plataforma
		PlatformTransform.Translate(new Vector3(VelocidadH, VelocidadV, 0) * Time.deltaTime);

		Invoke("limite",limitedistancia);
				
	}




	void limite(){
	
		MaxRecorridoPingPong = 0f;
		VelocidadVLuego = 0f;
		plataformadetecta.enabled = false;
			
	}

	
	
	void OnTriggerStay(Collider other)
	{
		// Incluímos como hijo de la plataforma a cualquier objeto que se pose sobre ella
		other.transform.parent = transform;
	}
	
	void OnTriggerExit(Collider other)
	{
		// Excluímos como hijo de la plataforma a cualquier objeto que se separe de ella
		other.transform.parent = null;
	}
	
	
	
}
