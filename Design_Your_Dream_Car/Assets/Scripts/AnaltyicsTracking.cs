using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnaltyicsTracking : MonoBehaviour {
	public GoogleAnalyticsV3 googleAnalytics;
	public GameObject start;
	public GameObject start_Button;
	public GameObject restart_Button;
	public GameObject next_Button;
	public GameObject previous_Button;
	private int sceneIndex;
	public GameObject no_button;
	// Use this for initialization
	void Start () {
		start.GetComponent<Button> ().onClick.AddListener (() => { googleAnalytics.LogEvent("Achievement", "Unlocked", "Slay 10 dragons", 5);
		Debug.Log ("In Emperor Palpetine's voice 'Log It'");
		});
		start_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++;});
		restart_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0;});
		no_button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0;});
		next_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++; Debug.Log(sceneIndex); LogScreenUse(); });
		previous_Button.GetComponent<Button>().onClick.AddListener(()=> {sceneIndex--;});

	}

	void LogScreenUse() {
		if (sceneIndex == 1) {
			googleAnalytics.LogScreen("Engineer Description");
		}
		if (sceneIndex == 2) {
			googleAnalytics.LogScreen("Fuel");
		}
		if (sceneIndex == 3) {
			googleAnalytics.LogScreen("Transmission");
		}
		if (sceneIndex == 4) {
			googleAnalytics.LogScreen("Drivetrain");
		}
		if (sceneIndex == 5) {
			googleAnalytics.LogScreen("Desiginer Description");
		}
		if (sceneIndex == 6) {
			googleAnalytics.LogScreen("Body");
		}
		if (sceneIndex == 7) {
			googleAnalytics.LogScreen("Spoiler");
		}
		if (sceneIndex == 8) {
			googleAnalytics.LogScreen("Wheels");
		}
		if (sceneIndex == 9) {
			googleAnalytics.LogScreen("Color");
		}
		if (sceneIndex == 10) {
			googleAnalytics.LogScreen("Decal");
		}
		if (sceneIndex == 11) {
			googleAnalytics.LogScreen("Naming");
		}
		if (sceneIndex == 12) {
			googleAnalytics.LogScreen("Spoiler");
		}
		if (sceneIndex == 13) {
			googleAnalytics.LogScreen("Summary");
		}
		if (sceneIndex == 14) {
			googleAnalytics.LogScreen("Email");
		}
	}

}
