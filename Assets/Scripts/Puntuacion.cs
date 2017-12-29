using UnityEngine;
using System.Collections;

public class Puntuacion : MonoBehaviour {
		
	public int score;
	public TextMesh marcador;


	void Start () {


		NotificationCenter.DefaultCenter ().AddObserver (this, "IncrementarPuntos");
		ActualizarMarcador ();

		if (PlayerPrefs.HasKey ("Score")) 
		{
			if (Application.loadedLevel == 0)
			{
				PlayerPrefs.DeleteKey("Score");
				score = 0;
			}
			else
			{
			
		
				score = PlayerPrefs.GetInt("Score");	
				ActualizarMarcador ();

			}



				}
	}

	void IncrementarPuntos(Notification notification){

		int puntosAIncrementar = (int)notification.data;
		score += puntosAIncrementar;
		ActualizarMarcador ();
	}

	void ActualizarMarcador(){
			marcador.text = score.ToString ();
	}

	void Update () {
	
	}
}
