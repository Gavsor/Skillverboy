using UnityEngine;
using System.Collections;

public class ArmaScript : MonoBehaviour {


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
			if (PuedeAtacarr)
		{	
			tiempoEntreDisparos = tiempoEsperaDisparos;
			var disparoTransform = Instantiate(disparoReutilizado) as Transform;
			disparoTransform.position = transform.position;

			DisparoScript disparo = disparoTransform.gameObject.GetComponent<DisparoScript>();
			if(disparo != null)
			{
				disparo.esDisparoEnemigo = esEnemigo;

			}

			MovimientoScript movimiento = disparoTransform.gameObject.GetComponent<MovimientoScript>();
			if(movimiento != null)
			{
				movimiento.direccion = this.transform.right;

			}



		}

	}












	public bool PuedeAtacarr
		
	{
		get
		{
			return tiempoEntreDisparos <= 0f;
		}
	}



	
	
}

