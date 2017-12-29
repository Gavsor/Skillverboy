using UnityEngine;
using System.Collections;

public class DisparoScript : MonoBehaviour {



	public int danho = 1;
	public float tiempoendestruirse = 500f;


	public bool esDisparoEnemigo = false;


	// Use this for initialization
	void Start () {
		Destroy(gameObject, tiempoendestruirse);


	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
