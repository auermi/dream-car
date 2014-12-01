using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gauge_rotation : MonoBehaviour {

	public float Speed;
	public float Cost;
	public float Fuel;

	void SpeedGaugeRot(){

		Debug.Log (Speed);

		var speedGauge = GameObject.Find ("speed");
		Debug.Log (speedGauge.name);

		float oldVal = speedGauge.transform.localEulerAngles.z;
		Debug.Log (oldVal);

		float newVal = Speed*45;
		Debug.Log (newVal);

		float rotVal = Mathf.Abs(oldVal - newVal);
		Debug.Log (newVal);
		if (360-rotVal > oldVal) {
			speedGauge.transform.Rotate (Vector3.forward, ((360-rotVal)-oldVal), Space.Self);
		} else if (360-rotVal < oldVal) {
			speedGauge.transform.Rotate (Vector3.back, (oldVal-(360-rotVal)), Space.Self);
		} else if (360-rotVal == oldVal) {
			speedGauge.transform.Rotate (Vector3.back, 0f, Space.Self);
		}else if (newVal + oldVal < -180) {
			oldVal = 180;
		} else if (newVal - oldVal > 0) {
			oldVal = 0;
		}
	}

	void FuelGaugeRot(){
		var fuelGauge = GameObject.Find ("effic");
		float oldVal = fuelGauge.transform.localEulerAngles.z;
		float newVal = Fuel*45;
		float rotVal = Mathf.Abs(oldVal - newVal);

		if (360-rotVal > oldVal) {
			fuelGauge.transform.Rotate (Vector3.forward, ((360-rotVal)-oldVal), Space.Self);
		} else if (360-rotVal < oldVal) {
			fuelGauge.transform.Rotate (Vector3.back, (oldVal-(360-rotVal)), Space.Self);
		} else if (360-rotVal == oldVal) {
			fuelGauge.transform.Rotate (Vector3.back, 0f, Space.Self);
		}else if (newVal + oldVal < -180) {
			oldVal = 180;
		} else if (newVal - oldVal > 0) {
			oldVal = 0;
		}
	}
	
	void CostGaugeRot(){

		var costGauge = GameObject.Find ("cost");
		float oldVal = costGauge.transform.localEulerAngles.z;
		float newVal = Cost*45;
		float rotVal = Mathf.Abs(oldVal - newVal);

		if (360-rotVal > oldVal) {
			costGauge.transform.Rotate (Vector3.forward, ((360-rotVal)-oldVal), Space.Self);
		} else if (360-rotVal < oldVal) {
			costGauge.transform.Rotate (Vector3.back, (oldVal-(360-rotVal)), Space.Self);
		} else if (360-rotVal == oldVal) {
			costGauge.transform.Rotate (Vector3.back, 0f, Space.Self);
		}else if (newVal + oldVal < -180) {
			oldVal = 180;
		} else if (newVal - oldVal > 0) {
			oldVal = 0;
		}
	}
}
