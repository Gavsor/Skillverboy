using UnityEngine;
using System.Collections;

public class NubeScript : MonoBehaviour {
	
	private ArmamentoScript arma;
	private NubeScript nube;
	
	void Awake()
		
	{
		arma = GetComponentInChildren<ArmamentoScript> ();
		
		nube = GetComponentInChildren<NubeScript>();
	}
	
	
	void Start () {
		
		
		nube.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (arma != null && arma.PuedeAtacar)
		{
			arma.Ataque(true);
		}	
		
	}
	
	
	void OnTriggerEnter2D(Collider2D cambio){
		if (cambio.tag == "Player") {
			
			nube.enabled = true;
			
			
			
			
		}
	}
	
	
	
	
}
