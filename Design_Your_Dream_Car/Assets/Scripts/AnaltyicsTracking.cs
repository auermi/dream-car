using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnaltyicsTracking : MonoBehaviour {

	//Call Analytics Methods on this 
	public GoogleAnalyticsV3 googleAnalytics;

	//We are tracking which screen we are on with these buttons
	public GameObject startButton;
	public GameObject restartButton;
	public GameObject nextButton;
	public GameObject previousButton;
	public GameObject noButton;

	//Ranges 0-14 based on the current screen	
	private int sceneIndex;

	//We are tracking interactions with all these objects using Google Analytics

	//Fuel 
	public GameObject gasButton;
	public GameObject hybridButton;
	public GameObject electricButton;

	//Transmission 
	public GameObject automaticButton;
	public GameObject manualButton;

	//Drivetrain
	public GameObject twoWheelDriveButton;
	public GameObject allWheelDriveButton;

	//Body
	public GameObject truckButton;
	public GameObject suvButton;
	public GameObject vanButton;
	public GameObject coupeButton;
	public GameObject compactButton;

	//Spoiler
	public GameObject spoilerButton;
	public GameObject noSpoilerButton;

	//Wheels
	public GameObject basicWheelButton;
	public GameObject sportWheelButton;
	public GameObject luxuryWheelButton;

	//Color
	public GameObject redColorButton;
	public GameObject greenColorButton;
	public GameObject yellowColorButton;
	public GameObject orangeColorButton;
	public GameObject turquoiseColorButton;
	public GameObject tanColorButton;
	public GameObject pinkColorButton;
	public GameObject greyColorButton;
	public GameObject limeColorButton;
	public GameObject blueColorButton;
	public GameObject glaucousColorButton;

	//Decal
	public GameObject flameDecalButton;
	public GameObject stripeDecalButton;
	public GameObject starDecalButton;
	public GameObject noDecalButton;

	//Email (No Button is already referenced above)
	public GameObject yesButton;





	// Use this for initialization
	void Start () {


		//Event Listeners that track which screen we are on
		startButton.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++;});
		restartButton.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0;});
		noButton.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0; googleAnalytics.LogEvent("User Selection", "Navigation", "No Button", 0); });
		nextButton.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++; LogScreenUse(); googleAnalytics.LogEvent("User Selection", "Navigation", "Previoius Button", 0);});
		previousButton.GetComponent<Button>().onClick.AddListener(()=> {sceneIndex--; LogScreenUse(); });

		//Tracked objects for Google Analytics (No Button is already tracked above)

		//Fuel
		gasButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Fuel Type", "Gas Button", 0);});
		electricButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Fuel Type", "Electric Button", 0);});
		hybridButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Fuel Type", "Hybrid Button", 0);});

		//Transmission
		automaticButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Transmission Type", "Automatic Button", 0);});
		manualButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Transmission Type", "Manual Button", 0);});

		//Drivetrain
		twoWheelDriveButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Drivetrain Type", "Two Wheel Drive Button", 0);});
		allWheelDriveButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Drivetrain Type", "All Wheel Drive Button", 0);});

		//Body
		truckButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Body Type", "Truck Button", 0);});
		suvButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Body Type", "SUV Button", 0);});
		vanButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Body Type", "Van Button", 0);});
		coupeButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Body Type", "Coupe Button", 0);});
		compactButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Body Type", "Compact Button", 0);});

		//Spoiler
		spoilerButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Spoiler Type", "Spoiler Button", 0);});
		noSpoilerButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Spoiler Type", "No Spoiler Button", 0);});

		//Wheels
		basicWheelButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Wheel Type", "Basic Wheel Button", 0);});
		sportWheelButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Wheel Type", "Sport Wheel Button", 0);});
		luxuryWheelButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Wheel Type", "Luxury Wheel Button", 0);});

		//Color
		redColorButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Color Type", "Red Color Button", 0);});
		greenColorButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Color Type", "Green Color Button", 0);});
		yellowColorButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Color Type", "Yellow Color Button", 0);});
		orangeColorButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Color Type", "Orange Color Button", 0);});
		turquoiseColorButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Color Type", "Turquoise Color Button", 0);});
		tanColorButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Color Type", "Tan Color Button", 0);});
		pinkColorButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Color Type", "Pink Color Button", 0);});
		greyColorButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Color Type", "Grey Color Button", 0);});
		limeColorButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Color Type", "Lime Color Button", 0);});
		blueColorButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Color Type", "Blue Color Button", 0);});
		glaucousColorButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Color Type", "Glaucous Color Button", 0);});

		//Decal
		flameDecalButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Decal Type", "Flame Decal Button", 0);});
		stripeDecalButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Decal Type", "Stripe Decal Button", 0);});
		starDecalButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Decal Type", "Star Decal Button", 0);});
		noDecalButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Decal Type", "No Decal Button", 0);});

		//Email (No button is already tracked above)
		yesButton.GetComponent<Button> ().onClick.AddListener (() => {googleAnalytics.LogEvent("User Selection", "Navigation", "Yes Button", 0);});

	}


	//Based on the screen, log that screen's event.
	//This is called after the scene index is increased/decreased
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
