using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnaltyicsTracking : MonoBehaviour {
	public GoogleAnalyticsV3 googleAnalytics;
	public GameObject start;
	// Use this for initialization
	void Start () {
		start.GetComponent<Button> ().onClick.AddListener (() => { googleAnalytics.LogEvent("Achievement", "Unlocked", "Slay 10 dragons", 5);
		Debug.Log ("In Emperor Palpetine's voice 'Log It'");
		});

	}

}
