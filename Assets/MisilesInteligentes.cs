using UnityEngine;
using System.Collections;

public class MisilesInteligentes : MonoBehaviour {

	//public GenerarObjeto Punto1Salida;
	//public GenerarObjeto Punto2Salida;
	//public GenerarObjeto Punto3Salida;
	//public GenerarObjeto Izquierda1Salida;



	//public GameObject Punto1;
	//public GameObject Punto2;
	//public GameObject Punto3;
	//public GameObject Izquierda1;




	public CameraFollow camera;
	//public VoltearNave nave;

	//public float number;


	// Lista de misiles

	public GameObject Misil_1;
	public GameObject Misil_2;
	public GameObject Misil_3;
	public GameObject Misil_4;
	public GameObject Misil_5;
	public GameObject Misil_6;
	public GameObject Misil_7;
	public GameObject Misil_8;
	public GameObject Misil_9;
	public GameObject Misil_10;
	public GameObject Misil_11;
	public GameObject Misil_12;
	public GameObject Misil_13;
	public GameObject Misil_14;
	public GameObject Misil_15;
	public GameObject Misil_16;
	public GameObject Misil_17;
	public GameObject Misil_18;
	public GameObject Misil_19;
	public GameObject Misil_20;
	public GameObject Misil_21;
	public GameObject Misil_22;
	public GameObject Misil_23;
	public GameObject Misil_24;
	public GameObject BarraEnemiga1;
	public GameObject BarraEnemiga2;









	// PROGRAMO LAS BALAS DE IZQUIERDA Y DERECHA 
	void Start () {

		//Invoke ("Generar", 55);
			
						StartCoroutine ("Misiles");	

	

	}
	
	// Update is called once per frame
	void Update () {

		
		
		//if (camera.playe == true) {
			
	//		Punto1Salida.enabled = false;
	//		Punto2Salida.enabled = false;
	//		Punto3Salida.enabled = false;
	//		Izquierda1Salida.enabled = false;

			
	//	}
		
		
	//	if (number == 1) {
			
			
	//		Punto1Salida.enabled = true;
	//		Punto2Salida.enabled = true;
	//		Punto3Salida.enabled = true;
	//		Izquierda1Salida.enabled = false;
	//		Punto1.SetActive(true);
	//		Punto2.SetActive(true);
	//		Punto3.SetActive(true);
	//		Izquierda1.SetActive(false);
			
			
	//	} else if (number == 2) {
			
			
	//		Punto1Salida.enabled = false;
	//		Punto2Salida.enabled = false;
	//		Punto3Salida.enabled = false;
	//		Izquierda1Salida.enabled = true;
	//		Punto1.SetActive(false);
	//		Punto2.SetActive(false);
	//		Punto3.SetActive(false);
	//		Izquierda1.SetActive(true);
	//		
			
	//	}
		

}



//	void Generar(){
		
		
//		Invoke ("Generar", Random.Range (8,10));	
//		number = Random.Range (1, 3);
		
		
//	}



	IEnumerator Misiles()
	{	
		//comienza58
		yield return new WaitForSeconds(10f);
		Misil_1.SetActive(true);
		yield return new WaitForSeconds(3f);
		Misil_2.SetActive (true);
		yield return new WaitForSeconds(0.1f);
		BarraEnemiga1.SetActive(true);
		yield return new WaitForSeconds(7f);
		Misil_3.SetActive(true);
		yield return new WaitForSeconds(0.1f);
		BarraEnemiga2.SetActive(true);
		yield return new WaitForSeconds(8f);
		Misil_4.SetActive(true);
		yield return new WaitForSeconds(2f);
		Misil_5.SetActive(true);
		yield return new WaitForSeconds(1f);
		Misil_6.SetActive(true);
		yield return new WaitForSeconds(2f);
		Misil_7.SetActive(true);
		yield return new WaitForSeconds(0.5f);
		Misil_8.SetActive(true);
		yield return new WaitForSeconds(0.5f);
		Misil_9.SetActive(true);
		yield return new WaitForSeconds(1f);
		Misil_10.SetActive(true);
		yield return new WaitForSeconds(3f);
		Misil_11.SetActive(true);
		yield return new WaitForSeconds(3f);
		Misil_12.SetActive(true);
		yield return new WaitForSeconds(2f);
		Misil_13.SetActive(true);
		yield return new WaitForSeconds(2f);
		Misil_14.SetActive(true);
		yield return new WaitForSeconds(2f);
		Misil_15.SetActive(true);
		yield return new WaitForSeconds(2f);
		Misil_16.SetActive(true);
		yield return new WaitForSeconds(2f);
		Misil_17.SetActive(true);
		yield return new WaitForSeconds(2f);
		Misil_18.SetActive(true);
		yield return new WaitForSeconds(2f);
		Misil_19.SetActive(true);
		yield return new WaitForSeconds(2f);
		Misil_20.SetActive(true);
		yield return new WaitForSeconds(2f);
		Misil_21.SetActive(true);
		yield return new WaitForSeconds(2f);
		Misil_22.SetActive(true);
		yield return new WaitForSeconds(2f);
		Misil_23.SetActive(true);
		yield return new WaitForSeconds(2f);
		Misil_24.SetActive(true);
	


		
	}


}
