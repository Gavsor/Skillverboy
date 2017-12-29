using UnityEngine;
using System.Collections;

public class BarraEnemigaIA : MonoBehaviour {

	public int salto= 25;

	public GameObject caja;
	public Vector3 Vector;

	public GameObject balas;

	// Use this for initialization
	void Start () {

		Vector = new Vector3(caja.transform.localPosition.x,caja.transform.localPosition.y,caja.transform.localPosition.z);

		Destroy (balas, 8);
	}


	


	// Update is called once per frame
	void Update () {


			caja.transform.localPosition = Vector;


		
			Vector.x = Vector.x + 0.1f;
		
		
				
				
					
			
		if (balas.gameObject != null) {

						if (Vector.x >= 0) {
				
								Vector.x = 0;
								balas.SetActive (true);
			
			
			
						}

			
			
		} else {
				
			if (Vector.x >= 25) {
				
				Destroy(caja);
				
				
				
			}
		
		}

				




	
	
	
	}





}
