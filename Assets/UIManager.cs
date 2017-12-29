using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class UIManager : MonoBehaviour {



	public void DisableBoolInAnimator(Animator anim){ 

		anim.SetBool("isDisplayed",false);
	}


	public void EnableBoolInAnimator(Animator anim){ 
		anim.SetBool("isDisplayed",true);
	}


	public void NavigateTo(int scene){
			
		Application.LoadLevel (scene);
	}

	public void Facebook(){
		Application.OpenURL ("fb://page/130117237561280");

	}

	public void Youtube(){
		Application.OpenURL ("https://youtube.com/channel/UCIvDT7evNGJR7_4FdVzbRng");
	}

	public void Instagram(){
		Application.OpenURL ("instagram://user?username=mueblesgadiavi");
	}

}
