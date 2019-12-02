using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour {

	// Use this for initialization
	public void NextPage (string PageName) {
		Application.LoadLevel (PageName);
	}
}
