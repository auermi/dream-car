using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResetScreenPosition : MonoBehaviour {

	public GameObject restartBtn;

	public GameObject speedGauge = GameObject.Find ("speed");
	public GameObject FEGauge = GameObject.Find ("effic");
	public GameObject costGauge = GameObject.Find ("cost");

	// Use this for initialization
	void Start () {
		restartBtn.GetComponent<Button>().onClick.AddListener( () => { resetSlides(); });
	}
	
	void resetSlides()
	{

		speedGauge.transform.Rotate (Vector3.forward, 360, Space.Self);
		FEGauge.transform.Rotate (Vector3.forward, 360, Space.Self);
		costGauge.transform.Rotate (Vector3.forward, 360, Space.Self);

	}
}
