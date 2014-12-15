using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gauge_rotation : MonoBehaviour {
	
	//Values for each button
	public float Speed;
	public float Cost;
	public float Fuel;
	
	//Value at the start of each slide
	private float speedValue;
	private float costValue;
	private float fuelValue;
	
	//Gauge needle objects
	private static GameObject speedGauge;
	private static GameObject fuelGauge;
	private static GameObject costGauge;
	
	//slides array from navigation script
	private static GameObject[] slides = navigation.slides;
	
	//get interactable property
	private Transform button;
	
	
	//Initialization thingy
	void Start(){
		speedGauge = GameObject.Find ("speed");
		fuelGauge = GameObject.Find ("effic");
		costGauge = GameObject.Find ("cost");
		
		speedValue = speedGauge.transform.eulerAngles.z;
		fuelValue = fuelGauge.transform.eulerAngles.z;
		costValue = costGauge.transform.eulerAngles.z;
		
		//button = this.gameObject.transform;
		
		
	}
	
	void Update(){
		
	}
	
	/*void changeVal(){
		for(var i=0; i <slides.Length; i++) {
			if(slides[i].transform.localPosition.x == 0){
				var curSlide = new GameObject;
				curSlide = slides[i].gameObject;
				break;
				Debug.Log (curSlide.name);
			}
		}
		while (curSlide) {			

			//Debug.Log (fuelValue);
			//Debug.Log (costValue);

			SpeedGaugeRot();
			FuelGaugeRot();
			CostGaugeRot();
			
			if (button.GetComponent<Button>().IsInteractable() == true)
			{
				button.GetComponent<Button>().interactable = false;
			}
			else //Else make it interactable
			{
				button.GetComponent<Button>().interactable = true;
			}
		}
	}*/
	
	
	void SpeedGaugeRot(){
		
		//float oldVal = speedGauge.transform.localEulerAngles.z;
		//Debug.Log (speedValue);
		float newVal = Speed*45;
		float rotVal = 360 - (Mathf.Abs(speedValue - newVal));
		
		if (newVal > speedValue) {
			speedGauge.transform.eulerAngles = new Vector3(0, 0, rotVal);
			//speedGauge.transform.Rotate (Vector3.forward, ((360-rotVal)-speedValue), Space.Self);
		} else if (newVal < speedValue) {
			if(speedValue - newVal < 180){
				speedGauge.transform.eulerAngles = new Vector3(0, 0, 180);
			} else {
				speedGauge.transform.eulerAngles = new Vector3(0, 0, rotVal);
			}
			//speedGauge.transform.Rotate (Vector3.back, (speedValue-rotVal), Space.Self);
		} else if (newVal == speedValue){
			speedGauge.transform.eulerAngles = new Vector3(0, 0, speedValue);
		} else if (newVal == 0) {
			speedGauge.transform.eulerAngles = new Vector3(0, 0, speedValue);
			//speedGauge.transform.Rotate (Vector3.back, 0f, Space.Self);
		} else if (newVal + speedValue > 360) {
			speedGauge.transform.eulerAngles = new Vector3(0, 0, 360);
			//speedGauge.transform.Rotate (Vector3.back, ((360-rotVal) + speedValue)-360, Space.Self);
			//oldVal = 180;
		} else if (newVal - speedValue < 180) {
			speedGauge.transform.eulerAngles = new Vector3(0, 0, 180);
			//speedGauge.transform.Rotate (Vector3.back, (180-((360-rotVal)- speedValue)), Space.Self);
		}
	}
	
	void FuelGaugeRot(){
		
		//float oldVal = fuelGauge.transform.localEulerAngles.z;
		float newVal = Fuel*45;
		float rotVal = 360 - (Mathf.Abs(fuelValue - newVal));
		
		if (newVal > speedValue) {
			fuelGauge.transform.eulerAngles = new Vector3(0, 0, rotVal);
			//speedGauge.transform.Rotate (Vector3.forward, ((360-rotVal)-speedValue), Space.Self);
		} else if (newVal < fuelValue) {
			if(fuelValue - newVal < 180){
				fuelGauge.transform.eulerAngles = new Vector3(0, 0, 180);
			} else {
				fuelGauge.transform.eulerAngles = new Vector3(0, 0, rotVal);
			}
			//speedGauge.transform.Rotate (Vector3.back, (speedValue-rotVal), Space.Self);
		} else if (newVal == fuelValue){
			speedGauge.transform.eulerAngles = new Vector3(0, 0, fuelValue);
		} else if (newVal == 0) {
			speedGauge.transform.eulerAngles = new Vector3(0, 0, fuelValue);
			//speedGauge.transform.Rotate (Vector3.back, 0f, Space.Self);
		}else if (newVal + fuelValue > 360) {
			fuelGauge.transform.eulerAngles = new Vector3(0, 0, 360);
			//speedGauge.transform.Rotate (Vector3.back, ((360-rotVal) + speedValue)-360, Space.Self);
			//oldVal = 180;
		} else if (newVal - fuelValue < 180) {
			fuelGauge.transform.eulerAngles = new Vector3(0, 0, 180);
			//speedGauge.transform.Rotate (Vector3.back, (180-((360-rotVal)- speedValue)), Space.Self);
		}
	}
	
	void CostGaugeRot(){
		
		//float oldVal = costGauge.transform.localEulerAngles.z;
		float newVal = Cost*45;
		float rotVal = (Mathf.Abs(costValue - newVal));
		Debug.Log (newVal);
		Debug.Log (rotVal);
		if (rotVal > costValue || newVal > costValue) {
			costGauge.transform.eulerAngles = new Vector3 (0, 0, costValue);
			//speedGauge.transform.Rotate (Vector3.forward, ((360-rotVal)-speedValue), Space.Self);
		} else if (newVal < costValue && newVal != 0) {
			if(costValue - newVal < 180){
				costGauge.transform.eulerAngles = new Vector3(0, 0, 180);
			} else {
				costGauge.transform.eulerAngles = new Vector3(0, 0, rotVal);
			}
		} else if (newVal == 0) {
			costGauge.transform.eulerAngles = new Vector3 (0, 0, costValue);
			//speedGauge.transform.Rotate (Vector3.back, 0f, Space.Self);
		}
	}
}
