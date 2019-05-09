using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TampilObjek : MonoBehaviour {
	public GameObject pesawatdanbandara;
	public GameObject kapaldanpelabuhan;
	public GameObject sungai;
	public GameObject jalanarteri;
	public GameObject jalankolektor;
	public GameObject pura;
	public GameObject sawah;
	public Dropdown dropdownMenu;
	private bool tampil;
	public GameObject gambar;

	// Use this for initialization
	void Start () {
		pesawatdanbandara.SetActive (false);
		kapaldanpelabuhan.SetActive (false);
		sungai.SetActive (false);
		jalanarteri.SetActive (false);
		jalankolektor.SetActive (false);
		pura.SetActive (false);
		sawah.SetActive (false);

		tampil = false;

	}
	
	// Update is called once per frame
	void Update () {
	// find yhe selected index
		int menuIndex = dropdownMenu.GetComponent<Dropdown> ().value;

		//find all options available within the dropdown menu
		List<Dropdown.OptionData> menuOptions = dropdownMenu.GetComponent<Dropdown> ().options;

			// get string value of the selected index 
		string value = menuOptions [menuIndex].text;
		Debug.Log ("Option " + value);
		if(value.Equals("Sarana")){
			gambar.GetComponent<RawImage> ().texture = Resources.Load<Texture2D> ("sarana prasarana");
		}
		else if(value.Equals("Jalan Arteri")){
			gambar.GetComponent<RawImage> ().texture = Resources.Load<Texture2D>("jalanarteri");

		}
		else if(value.Equals("Jalan Kolektor")){
			gambar.GetComponent<RawImage> ().texture = Resources.Load<Texture2D>("jalankolektor");

		}
		else if(value.Equals("Sungai")){
			gambar.GetComponent<RawImage> ().texture = Resources.Load<Texture2D>("sungai");

		}

		else if(value.Equals("Bandara")){
			gambar.GetComponent<RawImage> ().texture = Resources.Load<Texture2D>("pesawat");

		}


		else if(value.Equals("Pelabuhan")){
			gambar.GetComponent<RawImage> ().texture = Resources.Load<Texture2D>("pelabuhan");

		}
		else if(value.Equals("Pura")){
			gambar.GetComponent<RawImage> ().texture = Resources.Load<Texture2D>("tempat_suci");
		
		}
		else if(value.Equals("Sawah")){
			gambar.GetComponent<RawImage> ().texture = Resources.Load<Texture2D>("sawah");
		
		}
			

	}
		

	public void tampiljalanarteri(){
		if (tampil == false) {

			tampil = true;
			pesawatdanbandara.SetActive (false);
			kapaldanpelabuhan.SetActive (false);
			sungai.SetActive (false);
			jalanarteri.SetActive (true);
			jalankolektor.SetActive (false);
			pura.SetActive (false);
			sawah.SetActive (false);

		} else {
			tutup ();
		}
	}

	public void tampiljalankolektor(){
		if (tampil == false) {

			tampil = true;
			pesawatdanbandara.SetActive (false);
			kapaldanpelabuhan.SetActive (false);
			sungai.SetActive (false);
			jalanarteri.SetActive (false);
			jalankolektor.SetActive (true);
			pura.SetActive (false);
			sawah.SetActive (false);

		} else {
			tutup ();
		}
	}

	public void tampilsungai(){
		if (tampil == false) {

			tampil = true;
			pesawatdanbandara.SetActive (false);
			kapaldanpelabuhan.SetActive (false);
			sungai.SetActive (true);
			jalanarteri.SetActive (false);
			jalankolektor.SetActive (false);
			pura.SetActive (false);
			sawah.SetActive (false);

		} else {
			tutup ();
		}
	}


	public void tampilbandara(){
		if (tampil == false) {

			tampil = true;
			pesawatdanbandara.SetActive (true);
			kapaldanpelabuhan.SetActive (false);
			sungai.SetActive (false);
			jalanarteri.SetActive (false);
			jalankolektor.SetActive (false);
			pura.SetActive (false);
			sawah.SetActive (false);

		} else {
			tutup ();
		}
	}

	public void tampilkapaldanpelabuhan(){
		if (tampil == false) {

			tampil = true;
			pesawatdanbandara.SetActive (false);
			kapaldanpelabuhan.SetActive (true);
			sungai.SetActive (false);
			jalanarteri.SetActive (false);
			jalankolektor.SetActive (false);
			pura.SetActive (false);
			sawah.SetActive (false);

		} else {
			tutup ();
		}
	}


	public void tampilpura(){
		if (tampil == false) {

			tampil = true;
			pesawatdanbandara.SetActive (false);
			kapaldanpelabuhan.SetActive (false);
			sungai.SetActive (false);
			jalanarteri.SetActive (false);
			jalankolektor.SetActive (false);
			pura.SetActive (true);
			sawah.SetActive (false);

		} else {
			tutup ();
		}
	}


	public void tampilsawah(){
		if (tampil == false) {

			tampil = true;
			pesawatdanbandara.SetActive (false);
			kapaldanpelabuhan.SetActive (false);
			sungai.SetActive (false);
			jalanarteri.SetActive (false);
			jalankolektor.SetActive (false);
			pura.SetActive (false);
			sawah.SetActive (true);

		} else {
			tutup ();
		}
	}

	public void tutup(){
		pesawatdanbandara.SetActive (false);
		kapaldanpelabuhan.SetActive (false);
		sungai.SetActive (false);
		jalanarteri.SetActive (false);
		jalankolektor.SetActive (false);
		pura.SetActive (false);
		sawah.SetActive (false);
		tampil = false;
	}


	public void tampilkanobjek() {
		// find yhe selected index
		int menuIndex = dropdownMenu.GetComponent<Dropdown> ().value;

		//find all options available within the dropdown menu
		List<Dropdown.OptionData> menuOptions = dropdownMenu.GetComponent<Dropdown> ().options;

		// get string value of the selected index 
		string value = menuOptions [menuIndex].text;
		Debug.Log ("Option " + value);
		if(value.Equals("Sarana")){
			gambar.GetComponent<RawImage> ().texture = Resources.Load<Texture2D> ("sarana prasarana");
		}
		else if(value.Equals("Jalan Arteri")){
			gambar.GetComponent<RawImage> ().texture = Resources.Load<Texture2D>("jalanarteri");
			tampiljalanarteri ();
		}
		else if(value.Equals("Jalan Kolektor")){
			gambar.GetComponent<RawImage> ().texture = Resources.Load<Texture2D>("jalankolektor");
			tampiljalankolektor ();
		}
		else if(value.Equals("Sungai")){
			gambar.GetComponent<RawImage> ().texture = Resources.Load<Texture2D>("sungai");
			tampilsungai ();
		}

		else if(value.Equals("Bandara")){
			gambar.GetComponent<RawImage> ().texture = Resources.Load<Texture2D>("pesawat");
			tampilbandara ();
		}

		else if(value.Equals("Pelabuhan")){
			gambar.GetComponent<RawImage> ().texture = Resources.Load<Texture2D>("pelabuhan");
			tampilkapaldanpelabuhan ();
		}
		else if(value.Equals("Pura")){
			gambar.GetComponent<RawImage> ().texture = Resources.Load<Texture2D>("tempat_suci");
			tampilpura ();
		}
		else if(value.Equals("Sawah")){
			gambar.GetComponent<RawImage> ().texture = Resources.Load<Texture2D>("sawah");
			tampilsawah ();
		}


	}
		


}
