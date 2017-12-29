using UnityEngine;
using System.Collections;

public class DeathMenu : MonoBehaviour {



	public string mainMenuLevel;



	public AudioClip buttonsource;


	// Use this for initialization
	public void RestartGame(){
		PlayerPrefs.SetInt("energia",PlayerPrefs.GetInt("energia") - 1);
		print ("-1");
		Application.LoadLevel(Application.loadedLevel);

	}





	public void QuitToMain(){

		audio.PlayOneShot(buttonsource);
		Invoke ("CargarNivelJuego",0.7f);

	

	}

	void CargarNivelJuego(){
		
		
		Application.LoadLevel ("Niveles");
	}


}
