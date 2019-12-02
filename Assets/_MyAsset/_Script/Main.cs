using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
	public GameObject Image1,Image2,Image3;
	private int CurrentImage;
	// Use this for initialization
	void Start () {
		CurrentImage = 0;
		Image1.SetActive(true);
		Image2.SetActive(false);
		Image3.SetActive(false);
	}
	
	public void GoNext(){
		if(CurrentImage == 0){
			CurrentImage = 1;
		}
		else if(CurrentImage == 1){
			CurrentImage = 2;
		}
		else if(CurrentImage == 2){
			CurrentImage = 0;
		}

		ImageView();
	}

	public void GoPrev(){
		if(CurrentImage == 2){
			CurrentImage = 1;
		}
		else if(CurrentImage == 1){
			CurrentImage = 0;
		}
		else if(CurrentImage == 0){
			CurrentImage = 2;
		}

		ImageView();
	}


	private void ImageView(){
		if(CurrentImage == 0){
			Image1.SetActive(true);
			Image2.SetActive(false);
			Image3.SetActive(false);
		}
		else if(CurrentImage == 1){
			Image1.SetActive(false);
			Image2.SetActive(true);
			Image3.SetActive(false);
		}
		else if(CurrentImage == 2){
			Image1.SetActive(false);
			Image2.SetActive(false);
			Image3.SetActive(true);
		}
	}

	public void GoToLastPage(){
		Application.LoadLevel ("Scene_02");
	}
}
