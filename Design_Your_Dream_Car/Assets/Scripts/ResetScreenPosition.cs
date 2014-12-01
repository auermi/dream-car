using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;

public class ResetScreenPosition : MonoBehaviour {

	public GameObject restartBtn;
	public GameObject screen0;
	public GameObject screen1;
	public GameObject screen2;
	public GameObject screen3;
	public GameObject screen4;
	public GameObject screen5;
	public GameObject screen6;
	public GameObject screen7;
	public GameObject screen8;
	public GameObject screen9;
	public GameObject screen10;
	public GameObject screen11;
	public GameObject screen12;

	// Use this for initialization
	void Start () {
		restartBtn.GetComponent<Button>().onClick.AddListener( () => { resetSlides(); });
	}
	
	void resetSlides()
	{
		screen0.transform.localPosition  = new Vector3(0f, 0f);
		screen1.transform.localPosition  = new Vector3(1024f, 0f);
		screen2.transform.localPosition  = new Vector3(1024f, 0f);
		screen3.transform.localPosition  = new Vector3(1024f, 0f);
		screen4.transform.localPosition  = new Vector3(1024f, 0f);
		screen5.transform.localPosition  = new Vector3(1024f, 0f);
		screen6.transform.localPosition  = new Vector3(1024f, 0f);
		screen7.transform.localPosition  = new Vector3(1024f, 0f);
		screen8.transform.localPosition  = new Vector3(1024f, 0f);
		screen9.transform.localPosition  = new Vector3(1024f, 0f);
		screen10.transform.localPosition = new Vector3(1024f, 0f);
		screen11.transform.localPosition  = new Vector3(1024f, 0f);
		screen12.transform.localPosition = new Vector3(1024f, 0f);


		/*
		GameObject[] slides = GameObject.FindGameObjectsWithTag("Screen").OrderBy(go => go.name).ToArray();
		for (var i = 0; i < slides.Length; i++) {
			slides[i].transform.localPosition = new Vector3(0f, 0f);
		}
		GameObject.FindGameObjectsWithTag("Screen").transform.localPosition = new Vector3(0f, 0f);*/

	}
}
