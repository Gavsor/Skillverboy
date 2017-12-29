using UnityEngine;
using System.Collections;

public class Destructor : MonoBehaviour {

	public GameObject MenuMuerteUI;





	// Use this for initialization
	void Start () {

		MenuMuerteUI.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			NotificationCenter.DefaultCenter().PostNotification(this,"PersonajeHaMuerto");
			GameObject personaje = GameObject.Find("Humano");
			personaje.SetActive(false);



		}else{

			Destroy(other.gameObject);
			//MenuMuerteUI.SetActive(true);
			//Time.timeScale = 0;
	}

}

}