using UnityEngine;
using System.Collections;

public class ArmamentoScript : MonoBehaviour {

	public Transform disparoReutilizado;
	
	public float tiempoEsperaDisparos = 0.25f;
	
	private float tiempoEntreDisparos;
	




	// Use this for initialization
	void Start () {
		tiempoEntreDisparos = 0f;
	}
	
	// Update is called once per frame
	void Update () {
			
		if (tiempoEsperaDisparos > 0) 
		{
			tiempoEntreDisparos -= Time.deltaTime;
		}
	}



	public void Ataque(bool esEnemigo)
	{
		if (PuedeAtacar)
		{	
			tiempoEntreDisparos = tiempoEsperaDisparos;
			var disparooTransform = Instantiate(disparoReutilizado) as Transform;
			disparooTransform.position = transform.position;
			
			DisparandoScript disparoo = disparooTransform.gameObject.GetComponent<DisparandoScript>();
			if(disparoo != null)
			{
				disparoo.esDisparoEnemigo = esEnemigo;
				
			}
			
			Movimiento movimiento = disparooTransform.gameObject.GetComponent<Movimiento>();
			if(movimiento != null)
			{
				movimiento.direccion = this.transform.right;
				
			}
			
			
			
		}
		
	}
	
	public bool PuedeAtacar
		
	{
		get
		{
			return tiempoEntreDisparos <= 0f;
		}
	}
	




}
