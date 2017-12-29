using UnityEngine;
using System.Collections;

public class EfectosEspecialesScript : MonoBehaviour {


	public static EfectosEspecialesScript Instancia;
	public ParticleSystem efectoHumo;
	public ParticleSystem efectoDesintegrar;


	void Awake(){


			if (Instancia != null )
		{
			Debug.LogError("Muchas instancias de EfectosEspecialesScript!");
		}
		Instancia = this;
		}

	public void Explosion(Vector3 posicion)
	{
		instanciar(efectoHumo,posicion);
		instanciar (efectoDesintegrar, posicion);
	
	}

	private ParticleSystem instanciar(ParticleSystem reutilizado, Vector3 posicion)
	{
		ParticleSystem nuevoSistemaParticulas = Instantiate(
			reutilizado,
			posicion,
			Quaternion.identity
		)as ParticleSystem;

		Destroy (

			nuevoSistemaParticulas.gameObject,
			nuevoSistemaParticulas.startLifetime);


		return nuevoSistemaParticulas;
		}


		

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
