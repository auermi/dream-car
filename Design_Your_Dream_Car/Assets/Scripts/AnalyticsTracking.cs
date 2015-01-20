using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnalyticsTracking : MonoBehaviour {

	public GoogleAnalyticsV3 googleAnalytics;


	public GameObject start_Button;
	public GameObject restart_Button;
	public GameObject done_Button;



	// Use this for initialization
	void Start () {
		start_Button.GetComponent<Button>().onClick.AddListener(() => { googleAnalytics.StartSession (); });
		restart_Button.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.StopSession(); googleAnalytics.DispatchHits();});
		done_Button.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.StopSession(); googleAnalytics.DispatchHits();});
	}
	

}
