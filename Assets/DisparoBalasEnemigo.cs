using UnityEngine;
using System.Collections;

public class DisparoBalasEnemigo : MonoBehaviour {


	public GameObject bala;
	public MovimientoScript movimiento;
	public GameObject explosionn;



	// Use this for initialization
	void Start () {

		StartCoroutine ("Espera");
		StartCoroutine ("BalaPara");

		StartCoroutine ("Explosion");
		Destroy (bala, 2.2f);






	}
		
			
	// Update is called once per frame
	void Update () {

	}




	IEnumerator Espera()
	{	
	

		transform.position = new Vector3 (transform.position.x,transform.position.y,44);

		transform.rotation = Quaternion.Euler(0,0,0);
		yield return new WaitForSeconds(0.2f);
		transform.rotation = Quaternion.Euler(0,0,-30);
		yield return new WaitForSeconds(0.1f);
		transform.position = new Vector3 (transform.position.x,transform.position.y,-4f);
		transform.rotation = Quaternion.Euler(0,0,-60);
		yield return new WaitForSeconds(0.1f);
		transform.rotation = Quaternion.Euler(0,0,-90);
		yield return new WaitForSeconds(0.1f);
		transform.rotation = Quaternion.Euler(0,0,-120);
		yield return new WaitForSeconds(0.1f);
		transform.rotation = Quaternion.Euler(0,0,-150);
		yield return new WaitForSeconds(0.1f);
		transform.rotation = Quaternion.Euler(0,0,-180);
	}


	IEnumerator BalaPara()
	{	
		
		movimiento.enabled = true;
		yield return new WaitForSeconds(0.5f);
		movimiento.enabled = false;

	}


	IEnumerator Explosion()
	{	
		
		explosionn.SetActive (false);
		yield return new WaitForSeconds(1.8f);
		explosionn.SetActive (true);
		
	}
}
