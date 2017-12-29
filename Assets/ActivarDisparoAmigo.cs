using UnityEngine;
using System.Collections;

public class ActivarDisparoAmigo : MonoBehaviour {


	Animator anim;

	public bool disparo = false;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		anim.SetBool ("Ataque", false);
		disparo = false;
	}


	IEnumerator Disparando()
	{	
		
		disparo = false;
		anim.SetBool("Ataque",true);
		yield return new WaitForSeconds(2);
		anim.SetBool("Ataque", false);
		disparo = false;
	}


	// Update is called once per frame
	void Update () {
		if (disparo == true) {
		

			StartCoroutine ("Disparando");
		}
		
	}



		

}
