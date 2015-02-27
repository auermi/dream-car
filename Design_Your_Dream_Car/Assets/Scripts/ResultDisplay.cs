//Written by Michael Andrew Auer for the Indianapolis Museum of Art Dream Car iPad Application
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResultDisplay : MonoBehaviour {

	//Put name and car name on the screen

	public GameObject result_TextField;

	private string result_TextField_Text;

	//We need to access the values of the gauges buy tapping into the game obj containing the script
	public GameObject gaugeScript_Object;

	private float cost_Total;
	private float efficiency_Total;
	private float speed_Total;

	//Strings to plug into the result
	private string costChoice;
	private string efficiencyChoice;
	private string speedChoice;

	//Track Screen number so we can choose when to calculate & display the information
	public GameObject start_Button;
	public GameObject restart_Button;
	public GameObject next_Button;
	public GameObject previous_Button;
	private int sceneIndex;
	public GameObject no_button;

	// Use this for initialization
	void Start () {
		//Initialize some vars and add event listeners for scene index and the text
		costChoice = " ";
		efficiencyChoice = " ";
		speedChoice = " ";
		sceneIndex = 0;
		start_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++;});
		restart_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0;});
		no_button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0;});
		next_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++; CheckIfDisplay();});
		previous_Button.GetComponent<Button>().onClick.AddListener(()=> {sceneIndex--;});
	}
	
	void CalculateTextOptions()
	{
		//Referencing total values from GaugeRotation.cs
		GaugeRotation gaugeRotation_Script = gaugeScript_Object.GetComponent<GaugeRotation> ();
		cost_Total = gaugeRotation_Script.total_Cost;
		efficiency_Total = gaugeRotation_Script.total_Efficiency;
		speed_Total = gaugeRotation_Script.total_Speed;
		//Determine Cost word
		if (cost_Total >= 8)
		{
			costChoice = "expensive";
		}
		else
		{
			costChoice = "inexpensive";
		}
		//Determine Efficiency word
		if (efficiency_Total >= 5)
		{
			efficiencyChoice = "fuel-efficient";
		}
		else
		{
			efficiencyChoice = "not fuel-efficient";
		}
		//Determine Speed word
		if (speed_Total >= 4)
		{
			speedChoice = "fast";
		}
		else 
		{
			speedChoice = "slow";
		}

		result_TextField_Text = "Your dream car is " + costChoice + ", " + efficiencyChoice + ", and " + speedChoice + ".";
		result_TextField.GetComponent<Text> ().text = result_TextField_Text;

	}
	void CheckIfDisplay()
	{
		if (sceneIndex == 12)
		{
			CalculateTextOptions();
		}
	}
}
