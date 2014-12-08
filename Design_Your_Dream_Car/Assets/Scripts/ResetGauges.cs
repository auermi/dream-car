using UnityEngine;
using System.Collections;

public class ResetGauges : MonoBehaviour {

	private static GameObject speedGauge;
	private static GameObject FEGauge;
	private static GameObject costGauge;

	// Use this for initialization
	void Start () {
	
		speedGauge = GameObject.Find ("speed");
		FEGauge = GameObject.Find ("effic");
		costGauge = GameObject.Find ("cost");

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void reset()
	{
		//Debug.Log ("Hi");
		speedGauge.transform.eulerAngles = new Vector3(0, 0, 360);
		FEGauge.transform.eulerAngles = new Vector3(0, 0, 360);
		costGauge.transform.eulerAngles = new Vector3(0, 0, 360);
		
	}
}
