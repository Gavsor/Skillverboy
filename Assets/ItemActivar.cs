using UnityEngine;
using System.Collections;

public class ItemActivar : MonoBehaviour {
	Animator anim;
	public bool item = false;
	public bool itemactivado;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		anim.SetBool ("itemActivado", false);

	}
	
	// Update is called once per frame
	void Update () {

		if (itemactivado == true) {
						anim.SetBool ("itemActivado", true);
				}

	}

	void OnTriggerEnter2D(Collider2D cambio){
		if (cambio.tag == "Player") {

			itemactivado=true;
			
				
			}

			
		}

}
