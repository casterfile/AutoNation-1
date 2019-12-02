using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {
	public GameObject ViewPoint;
	public Text Output,Output2;
	// Use this for initialization
	void Start () {
		
         if(!Input.gyro.enabled)
         {
             Input.gyro.enabled = true;
         }

	}
	//340 -7
	//20 6
	
	// Update is called once per frame
	string NumOut;
	void Update () {
		//ViewPoint.transform.Rotate (0, -Input.gyro.rotationRateUnbiased.y, 0);
		
		// if(-Input.gyro.attitude.z >= -0.6 && -Input.gyro.attitude.z <= -0.7){
			
		// 	ViewPoint.transform.Rotate (0, 0, -Input.gyro.rotationRateUnbiased.z);
		// }


		// if(-Input.gyro.attitude.z >= 0.5){
			
		// 	ViewPoint.transform.Rotate (0, 0, -Input.gyro.rotationRateUnbiased.z);
		// }else if(-Input.gyro.attitude.z >= 0.8){
		// 	ViewPoint.transform.Rotate (0, 0, -Input.gyro.rotationRateUnbiased.z);
		// }
		// if(ViewPoint.transform.rotation.eulerAngles.z >= 330 && ViewPoint.transform.rotation.eulerAngles.z <= 360){
		// 	ViewPoint.transform.Rotate (0, 0, -Input.gyro.rotationRateUnbiased.z);
		// }else{
		// 	ViewPoint.transform.Rotate (0, 0, 331);
		// }
		
		// if(ViewPoint.transform.rotation.eulerAngles.z >= -1 && ViewPoint.transform.rotation.eulerAngles.z <= 30){
		// 	ViewPoint.transform.Rotate (0, 0, -Input.gyro.rotationRateUnbiased.z);
		// }else if(ViewPoint.transform.rotation.eulerAngles.z > 30 && ViewPoint.transform.rotation.eulerAngles.z <= 300){
		// 	ViewPoint.transform.Rotate (0, 0, 29);
		// }else if(ViewPoint.transform.rotation.eulerAngles.z > 340 && ViewPoint.transform.rotation.eulerAngles.z <= 360){
		// 	ViewPoint.transform.Rotate (0, 0, -Input.gyro.rotationRateUnbiased.z);
		// }else if(ViewPoint.transform.rotation.eulerAngles.z > 300 && ViewPoint.transform.rotation.eulerAngles.z <= 340){
		// 	ViewPoint.transform.Rotate (0, 0, 340);
		// }

		// if(ViewPoint.transform.rotation.eulerAngles.z >= -1 && ViewPoint.transform.rotation.eulerAngles.z <= 30){
			
		// }
		ViewPoint.transform.Rotate (0, 0, Input.gyro.rotationRateUnbiased.z);
		// if(ViewPoint.transform.rotation.eulerAngles.z >= -30 && ViewPoint.transform.rotation.eulerAngles.z < 0 ){
		// 	ViewPoint.transform.Rotate (0, 0, -Input.gyro.rotationRateUnbiased.z);
		// }else{f
		// 	ViewPoint.transform.Rotate (0, 0, -29);
		// }
		// ViewPoint.transform.Rotate (0, 0, -Input.gyro.rotationRateUnbiased.z);
		// Output.text = ""+-Input.gyro.rotationRateUnbiased.z;
		Output.text = ""+-Input.gyro.attitude.z;
		// Output.text = NumOut;
		Output2.text = ""+ViewPoint.transform.rotation.eulerAngles.z;
	}

	public void GoToLastPage(){
		Application.LoadLevel ("Scene_03");
	}
}
