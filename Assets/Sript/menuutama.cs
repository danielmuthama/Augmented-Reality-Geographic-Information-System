using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuutama : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	
// Update is called once per frame
	void Update () {
		
	}
	
public void ke_kembali(){
		Application.LoadLevel (0);
	}

public void ke_mulai(){
		Application.LoadLevel (1);
	}
	
public void ke_tentang(){
		Application.LoadLevel (2);
	}
	
public void ke_bantuan(){
		Application.LoadLevel (3);
	}
	
public void ke_keluar(){
		Application.Quit ();
	}


}
