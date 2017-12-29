using UnityEngine;
using System.Collections;

public class ActivarGrupo : MonoBehaviour {

	public GameObject Grupo;
	public float TiempoaActivarse = 0f;
	public float TiempoADesactivarse = 0f;


	// Use this for initialization
	void Start () {
		Grupo.SetActive (false);

		Invoke ("activarse", TiempoaActivarse);
		Invoke ("desactivarse", TiempoADesactivarse);

	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void activarse(){
	
		Grupo.SetActive (true);
		
	}

	void desactivarse(){
	
		Grupo.SetActive (false);

	}


}
