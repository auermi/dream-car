//Written by Michael Andrew Auer for the Indianapolis Museum of Art Dream Car iPad Application
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GaugeRotation : MonoBehaviour {

	//Gauges
	public GameObject cost_Gauge;
	public GameObject efficiency_Gauge;
	public GameObject speed_Gauge;
	
	//Values
	//Cost
	private int fuel_Cost;
	private int drivetrain_Cost;
	private int transmission_Cost;
	private int bodyStyle_Cost;
	private int spoiler_Cost;
	private int wheels_Cost;
	private int paintCoat_Cost;
	private int decal_Cost;
	//Fuel Efficiency
	private int fuel_Efficiency;
	private int drivetrain_Efficiency;
	private int transmission_Efficiency;
	private int bodyStyle_Efficiency;
	private int spoiler_Efficiency;
	//Speed
	private int fuel_Speed;
	private int transmission_Speed;
	private int bodyStyle_Speed;
	private int spoiler_Speed;

	//Totals
	public float total_Cost;
	public float total_Efficiency;
	public float total_Speed;
	
	//All buttons that impact gauges
	public GameObject gas_Button;
	public GameObject electric_Button;
	public GameObject hybrid_Button;
	public GameObject twoWheelDrive_Button;
	public GameObject allWheelDrive_Button;
	public GameObject automatic_Button;
	public GameObject manual_Button;
	public GameObject coupe_Button;
	public GameObject compact_Button;
	public GameObject minivan_Button;
	public GameObject truck_Button;
	public GameObject suv_Button;
	public GameObject spoiler_Button;
	public GameObject noSpoiler_Button;
	public GameObject sportyWheel_Button;
	public GameObject luxuryWheel_Button;
	public GameObject basicWheel_Button;
	public GameObject redColor_Button;
	public GameObject greenColor_Button;
	public GameObject yellowColor_Button;
	public GameObject orangeColor_Button;
	public GameObject turquoiseColor_Button;
	public GameObject carrotColor_Button;
	public GameObject pinkColor_Button;
	public GameObject greyColor_Button;
	public GameObject limeColor_Button;
	public GameObject blueColor_Button;
	public GameObject glaucousColor_Button;
	public GameObject flame_Button;
	public GameObject stripe_Button;
	public GameObject stars_Button;
	public GameObject noDecal_Button;

	//Restart Button
	public GameObject restart_Button;

	//Previous Button so we can remove values going backwards
	public GameObject previous_Button;

	//Next Button so we can track the scene Index
	public GameObject next_Button;

	//We need to track the scene index here
	private int scene_Index;

	//Tracking the start button here to up scene index by one
	public GameObject start_Button;

	public GameObject no_button;

	// Use this for initialization
	//Set all values equal to zero
	void Start () {
		scene_Index = 0;
		ZeroGaugueValues ();

		//Set listeners for all Buttons affecting gauge values
		gas_Button.GetComponent<Button> ().onClick.AddListener (() => { fuel_Cost = 1; fuel_Efficiency = 1; fuel_Speed = 3; CalculateCostGauge(); CalculateFuelEfficiencyGauge(); CalculateSpeedGauge(); });
		hybrid_Button.GetComponent<Button>().onClick.AddListener (() => { fuel_Cost = 2; fuel_Efficiency = 2; fuel_Speed = 2; CalculateCostGauge(); CalculateFuelEfficiencyGauge(); CalculateSpeedGauge();});
		electric_Button.GetComponent<Button> ().onClick.AddListener (() => { fuel_Cost = 3; fuel_Efficiency = 3; fuel_Speed = 1; CalculateCostGauge(); CalculateFuelEfficiencyGauge(); CalculateSpeedGauge(); });
		twoWheelDrive_Button.GetComponent<Button> ().onClick.AddListener (() => { drivetrain_Cost = 0; drivetrain_Efficiency = 1; CalculateCostGauge(); CalculateFuelEfficiencyGauge(); });
		allWheelDrive_Button.GetComponent<Button> ().onClick.AddListener (() => { drivetrain_Cost = 1; drivetrain_Efficiency = 0; CalculateCostGauge(); CalculateFuelEfficiencyGauge(); });
		automatic_Button.GetComponent<Button> ().onClick.AddListener (() => { transmission_Cost = 1; transmission_Efficiency = 1; transmission_Speed = 0; CalculateCostGauge (); CalculateFuelEfficiencyGauge(); CalculateSpeedGauge(); });
		manual_Button.GetComponent<Button> ().onClick.AddListener (() => { transmission_Cost = 0; transmission_Efficiency = 0; transmission_Speed = 1; CalculateCostGauge (); CalculateFuelEfficiencyGauge(); CalculateSpeedGauge(); });
		coupe_Button.GetComponent<Button>().onClick.AddListener (() => { bodyStyle_Cost = 1; bodyStyle_Efficiency = 3; bodyStyle_Speed = 4; CalculateCostGauge(); CalculateFuelEfficiencyGauge(); CalculateSpeedGauge(); });
		compact_Button.GetComponent<Button>().onClick.AddListener (() => { bodyStyle_Cost = 0; bodyStyle_Efficiency = 4; bodyStyle_Speed = 3; CalculateCostGauge(); CalculateFuelEfficiencyGauge(); CalculateSpeedGauge(); });
		minivan_Button.GetComponent<Button>().onClick.AddListener ( () => { bodyStyle_Cost = 2; bodyStyle_Efficiency = 2; bodyStyle_Speed = 2; CalculateCostGauge(); CalculateFuelEfficiencyGauge(); CalculateSpeedGauge(); });
		truck_Button.GetComponent<Button>().onClick.AddListener ( () => { bodyStyle_Cost = 4; bodyStyle_Efficiency = 0; bodyStyle_Speed = 0; CalculateCostGauge(); CalculateFuelEfficiencyGauge(); CalculateSpeedGauge(); });
		suv_Button.GetComponent<Button>().onClick.AddListener ( () => { bodyStyle_Cost = 3; bodyStyle_Efficiency = 1; bodyStyle_Speed = 2; CalculateCostGauge(); CalculateFuelEfficiencyGauge(); CalculateSpeedGauge(); });
		spoiler_Button.GetComponent<Button>().onClick.AddListener ( () => { spoiler_Cost = 1; spoiler_Efficiency = 1; spoiler_Speed = 1; CalculateCostGauge(); CalculateFuelEfficiencyGauge(); CalculateSpeedGauge(); });
		noSpoiler_Button.GetComponent<Button>().onClick.AddListener ( () => { spoiler_Cost = 0; spoiler_Efficiency = 0; spoiler_Speed = 0; CalculateCostGauge(); CalculateFuelEfficiencyGauge(); CalculateSpeedGauge();});
		sportyWheel_Button.GetComponent<Button>().onClick.AddListener ( () => { wheels_Cost = 1; CalculateCostGauge(); });
		luxuryWheel_Button.GetComponent<Button>().onClick.AddListener ( () => { wheels_Cost = 2; CalculateCostGauge(); });
		basicWheel_Button.GetComponent<Button> ().onClick.AddListener (() => { wheels_Cost = 0; CalculateCostGauge(); });
		redColor_Button.GetComponent<Button>().onClick.AddListener ( () => { paintCoat_Cost = 0; CalculateCostGauge(); });
		greenColor_Button.GetComponent<Button>().onClick.AddListener ( () => { paintCoat_Cost = 0; CalculateCostGauge(); });
		yellowColor_Button.GetComponent<Button>().onClick.AddListener ( () => { paintCoat_Cost = 0; CalculateCostGauge(); });
		orangeColor_Button.GetComponent<Button>().onClick.AddListener ( () => { paintCoat_Cost = 0; CalculateCostGauge(); });
		turquoiseColor_Button.GetComponent<Button>().onClick.AddListener ( () => { paintCoat_Cost = 0; CalculateCostGauge(); });
		carrotColor_Button.GetComponent<Button>().onClick.AddListener ( () => { paintCoat_Cost = 1; CalculateCostGauge(); });
		pinkColor_Button.GetComponent<Button>().onClick.AddListener ( () => { paintCoat_Cost = 1; CalculateCostGauge(); });
		greyColor_Button.GetComponent<Button>().onClick.AddListener ( () => { paintCoat_Cost = 1; CalculateCostGauge(); });
		limeColor_Button.GetComponent<Button>().onClick.AddListener ( () => { paintCoat_Cost = 1; CalculateCostGauge(); });
		blueColor_Button.GetComponent<Button>().onClick.AddListener ( () => { paintCoat_Cost = 1; CalculateCostGauge(); });
		glaucousColor_Button.GetComponent<Button>().onClick.AddListener ( () => { paintCoat_Cost = 1; CalculateCostGauge(); });
		flame_Button.GetComponent<Button> ().onClick.AddListener (() => { decal_Cost = 2; CalculateCostGauge(); });
		stripe_Button.GetComponent<Button>().onClick.AddListener (() => { decal_Cost = 2; CalculateCostGauge(); });
		stars_Button.GetComponent<Button>().onClick.AddListener ( () => { decal_Cost = 2; CalculateCostGauge(); });
		noDecal_Button.GetComponent<Button>().onClick.AddListener ( () => { decal_Cost = 0; CalculateCostGauge(); });

		//Reset Values
		restart_Button.GetComponent<Button> ().onClick.AddListener (() => { scene_Index = 0; ZeroGaugueValues();});
		no_button.GetComponent<Button> ().onClick.AddListener (() => { scene_Index = 0; ZeroGaugueValues(); });

		//Watches to re-adjust values and track scene index
		previous_Button.GetComponent<Button>().onClick.AddListener (() => { scene_Index--; RemovePreviousSlideValues(); });
		next_Button.GetComponent<Button>().onClick.AddListener (() => { scene_Index++; });
		start_Button.GetComponent<Button>().onClick.AddListener (() => { scene_Index++;});


	}
	//Adds all values together and then converts them to a value that can not exceed 180 so that the cost gauge will not overrotate
	void CalculateCostGauge ()
	{
		total_Cost = fuel_Cost + drivetrain_Cost + transmission_Cost + bodyStyle_Cost + spoiler_Cost + wheels_Cost + paintCoat_Cost + decal_Cost;
		float convertedTotal_Cost = total_Cost * -11f;
		cost_Gauge.transform.eulerAngles = new Vector3 (0f, 0f, convertedTotal_Cost + 56.34f);
	}
	void CalculateFuelEfficiencyGauge()
	{
		total_Efficiency = fuel_Efficiency + drivetrain_Efficiency + transmission_Efficiency + bodyStyle_Efficiency + spoiler_Efficiency;
		float convertedTotal_Efficiency = total_Efficiency * -17f;
		efficiency_Gauge.transform.eulerAngles = new Vector3 (0f, 0f, convertedTotal_Efficiency + 56.34f);

	}
	void CalculateSpeedGauge()
	{
		total_Speed = fuel_Speed + transmission_Speed + bodyStyle_Speed + spoiler_Speed;
		float convertedTotal_Speed = total_Speed * -21.5f;
		speed_Gauge.transform.eulerAngles = new Vector3 (0f, 0f, convertedTotal_Speed+ 56.34f);
	}
	void ZeroGaugueValues()
	{
		fuel_Cost = 0;
		drivetrain_Cost = 0;
		transmission_Cost = 0;
		bodyStyle_Cost = 0;
		spoiler_Cost = 0;
		wheels_Cost = 0;
		paintCoat_Cost = 0;
		decal_Cost = 0;
		total_Cost = 0;
		fuel_Efficiency = 0;
		drivetrain_Efficiency = 0;
		transmission_Efficiency = 0;
		bodyStyle_Efficiency = 0;
		spoiler_Efficiency = 0;
		fuel_Speed = 0;
		transmission_Speed = 0;
		bodyStyle_Speed = 0;
		spoiler_Speed = 0;

		//Recalculate
		CalculateCostGauge ();
		CalculateFuelEfficiencyGauge ();
		CalculateSpeedGauge ();
	}

	//Remove previous slide values and recalculate gauge values
	//Values are -1 because subtraction/addition of scene index occurs before this script is cued 
	void RemovePreviousSlideValues()
	{
		switch (scene_Index) 
		{
			case 1:
				fuel_Cost = 0;
				fuel_Efficiency = 0;
				 fuel_Speed = 0;
				break;
			case 2:
				transmission_Cost = 0;
				transmission_Efficiency = 0;
				transmission_Speed = 0;
				break;
			case 3:
				drivetrain_Cost = 0;
				drivetrain_Efficiency = 0;
				break;
			case 5:
				bodyStyle_Cost = 0;
				bodyStyle_Efficiency = 0;
				bodyStyle_Speed = 0;
				break;
			case 6:
				spoiler_Cost = 0;
				spoiler_Efficiency = 0;
				spoiler_Speed = 0;
				break;
			case 7:
				wheels_Cost = 0;
				break;
			case 8:
				paintCoat_Cost = 0;
				break;
			case 9: 
				decal_Cost = 0;
				break;
			default:
				break;
		}
		//Recalculate
		CalculateCostGauge ();
		CalculateFuelEfficiencyGauge ();
		CalculateSpeedGauge ();
	}
}
