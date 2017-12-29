	using UnityEngine;
using System.Collections;

public class orbit : MonoBehaviour {
	public GameObject PuntoEje; 

	public GameObject objeto;

	public bool encendido;


	public float direccion ;
	// Use this for initialization
	void Start () {
		objeto.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);

	}

	// Update is called once per frame
	void Update () {
	

		//Debug.Log("Encendido" + objeto.transform.rotation.z);
		
		if (Input.mousePosition.x < Screen.width / 2) {


			//	if (Input.GetMouseButton(0)) {	

		//		transform.RotateAround (PuntoEje.transform.position, Vector3.back, direccion * Time.deltaTime);

		//		if(objeto.transform.rotation.z >= 0.7f){

		//			Debug.Log("Encendido");
		//			encendido = true;

		//		}else if(objeto.transform.rotation.z <= -0.7f ){

		//			Debug.Log("Apagado");
		//			encendido = false;
		//		}
		
		//}

		}

		else{
			if (Input.GetMouseButton(0) & objeto.transform.rotation.z <= 0.6f){

		//			Debug.Log("Encendido");
		//			encendido = true; {	
				
				transform.RotateAround (PuntoEje.transform.position, Vector3.back, -100 * Time.deltaTime);
				

				
				

					}else{


				if(objeto.transform.rotation.z >= -0.6f){
					
				transform.RotateAround (PuntoEje.transform.position, Vector3.back, 100 * Time.deltaTime);

					}
			}

				
				
			}
				





	}


}
