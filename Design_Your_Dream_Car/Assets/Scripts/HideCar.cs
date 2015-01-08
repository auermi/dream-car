//Written by Michael Andrew Auer for the Indianapolis Museum of Art Dream Car iPad Application
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HideCar : MonoBehaviour {

	//Car parts we need to shift
	public GameObject car_Container;
	public GameObject decal_Container;
	public GameObject spoiler_Container;
	public GameObject wheel_Container;

	//Shift Positions
	private Vector3 offscreen;
	private Vector3 onscreen;

	//Track scene index
	int sceneIndex;
	public GameObject start_Button;
	public GameObject restart_Button;
	public GameObject done_Button;
	public GameObject next_Button;
	public GameObject previous_Button;

	// Use this for initialization
	void Start () {
		offscreen = new Vector3 (0f, 1536f, 0f);
		start_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++; CheckToShift(); });
		restart_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0; CheckToShift();});
		done_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0; CheckToShift();});
		next_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++; CheckToShift();});
		previous_Button.GetComponent<Button>().onClick.AddListener(()=> {sceneIndex--; CheckToShift();});
	}
	
	void ShiftCarOut()
	{
		car_Container.transform.localPosition = offscreen;
		decal_Container.transform.localPosition = offscreen;
		spoiler_Container.transform.localPosition = offscreen;
		wheel_Container.transform.localPosition = offscreen;
	}

	void ShiftCarIn()
	{
		car_Container.transform.localPosition = onscreen;
		decal_Container.transform.localPosition = onscreen;
		spoiler_Container.transform.localPosition = onscreen;
		wheel_Container.transform.localPosition = onscreen;
	}

	void CheckToShift()
	{
		if (sceneIndex == 11 || sceneIndex == 13)
		{
			ShiftCarOut();
		}
		else
		{
			ShiftCarIn();
		}
	}
}
