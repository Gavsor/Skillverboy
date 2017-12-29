using UnityEngine;
using System.Collections;

public class MuerePortal : MonoBehaviour {


	Animator anim;
	public bool Destruido;
	public float TiempoEnDestruirse = 4.9f;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		anim.SetBool("Destruido", false);
	}
	
	// Update is called once per frame
	void Update () {
		Destruido = anim.GetBool("Destruido");
	}

	void OnTriggerEnter2D(Collider2D cambio){
				if (cambio.tag == "Player") {

				
			Invoke("destruye",TiempoEnDestruirse);

				}


	
		}


	void destruye(){

		anim.SetBool("Destruido", true);

	}

}
