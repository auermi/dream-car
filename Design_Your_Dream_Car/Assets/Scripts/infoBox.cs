﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class infoBox : MonoBehaviour {

	public GameObject fuelInfoButton;
	public GameObject transmissionInfoButton;
	public GameObject drivetrainInfoButton;
	public GameObject bodyStyleInfoButton;
	public GameObject spoilerInfoButton;
	public GameObject wheelInfoButton;
	public GameObject colorInfoButton;
	public GameObject decalInfoButton;

	public GameObject textBoxPref;
	public GameObject lgTextBoxPref;
	public GameObject lgTextPanel;
	public GameObject x_button;

	private GameObject textBox0;
	private GameObject textBox1;
	private GameObject textBox2;
	private GameObject textBox3;

	private GameObject closeWindowButton;
	private GameObject lg_box_text;

	public GameObject hybridButton;
	public GameObject gasButton;
	public GameObject electricButton;
	public GameObject manualButton;
	public GameObject automaticButton;
	public GameObject fourWheelDriveButton;
	public GameObject twoWheelDriveButton;
	public GameObject truckButton;
	public GameObject coupeButton;
	public GameObject compactButton;
	public GameObject vanButton;
	public GameObject suvButton;

	private int screenIndex;

	public GameObject infoParent;

	private Color32 infoActiveColor = new Color32(80, 80, 80, 255);
	private Color32 infoInactiveColor = new Color32(255,255,255,255);

	public Sprite infoActiveImage;
	public Sprite infoInactiveImage;

	public Sprite inactiveGas;
	public Sprite inactiveHybrid;
	public Sprite inactiveElectric;
	public Sprite inactiveManual;
	public Sprite inactiveAutomatic;
	public Sprite inactiveFourWheelDrive;
	public Sprite inactiveTwoWheelDrive;
	public Sprite truckInactive;
	public Sprite coupeInactive;
	public Sprite compactInactive;
	public Sprite vanInactive;
	public Sprite suvInactive;

	/// <summary>
	/// screenIndex-
	///	0:fuel
	/// 1:transmission
	/// 2:drivetrain
	/// </summary>

	// Use this for initialization
	void Start () {
		fuelInfoButton.GetComponent<Button>().onClick.AddListener(() => { 
			screenIndex = 0; 
			textSwap(); 
			fuelInfoButton.GetComponent<Image>().sprite = infoActiveImage; 
			hybridButton.GetComponent<Image>().sprite = inactiveHybrid;
			gasButton.GetComponent<Image>().sprite = inactiveGas;
			electricButton.GetComponent<Image>().sprite = inactiveElectric;
		});
			
		transmissionInfoButton.GetComponent<Button>().onClick.AddListener(() => { 
			screenIndex = 1; 
			textSwap(); 
			transmissionInfoButton.GetComponent<Image>().sprite = infoActiveImage;  
			manualButton.GetComponent<Image>().sprite = inactiveManual;
			automaticButton.GetComponent<Image>().sprite = inactiveAutomatic;
		});
		drivetrainInfoButton.GetComponent<Button>().onClick.AddListener(() => { 
			screenIndex = 2; 
			textSwap(); 
			drivetrainInfoButton.GetComponent<Image>().sprite = infoActiveImage; 
			fourWheelDriveButton.GetComponent<Image>().sprite = inactiveFourWheelDrive;
			twoWheelDriveButton.GetComponent<Image>().sprite = inactiveTwoWheelDrive;
		});

		bodyStyleInfoButton.GetComponent<Button>().onClick.AddListener(() => {
			screenIndex = 3;
			textSwap ();
			bodyStyleInfoButton.GetComponent<Image>().sprite = infoActiveImage;
			truckButton.GetComponent<Image>().sprite = truckInactive;
			coupeButton.GetComponent<Image>().sprite = coupeInactive;
			compactButton.GetComponent<Image>().sprite = compactInactive;
			suvButton.GetComponent<Image>().sprite = suvInactive;
			vanButton.GetComponent<Image>().sprite = vanInactive;
		});

		spoilerInfoButton.GetComponent<Button>().onClick.AddListener(() => {
			screenIndex = 4;
			textSwap ();
			spoilerInfoButton.GetComponent<Image>().sprite = infoActiveImage;
		});

		wheelInfoButton.GetComponent<Button>().onClick.AddListener(() => {
			screenIndex = 5;
			textSwap ();
			wheelInfoButton.GetComponent<Image>().sprite = infoActiveImage;
		});
		colorInfoButton.GetComponent<Button>().onClick.AddListener(() => {
			screenIndex = 6;
			textSwap ();
			colorInfoButton.GetComponent<Image>().sprite = infoActiveImage;
		});
		decalInfoButton.GetComponent<Button>().onClick.AddListener(() => {
			screenIndex = 7;
			textSwap ();
			decalInfoButton.GetComponent<Image>().sprite = infoActiveImage;
		});

	}
	

	void textSwap()
	{
		if (textBox0 != null)
		{
			Destroy(textBox0);
		}
		if (textBox1 != null)
		{
			Destroy(textBox1);
			if (textBox2 != null)
			{
				Destroy(textBox2);
				if (textBox3 != null)
				{
					Destroy(textBox3);
				}
			}
		}
		if (screenIndex < 3)
		{
			textBox1 = Instantiate(textBoxPref) as GameObject;
			textBox2 = Instantiate(textBoxPref) as GameObject;
			textBox3 = Instantiate(textBoxPref) as GameObject;
			
			textBox1.transform.parent = infoParent.transform;
			textBox2.transform.parent = infoParent.transform;
			textBox3.transform.parent = infoParent.transform;
		}

		switch (screenIndex)
		{
		case 0:
			textBox1.transform.localPosition = new Vector3(-332f, -45.1f);
			textBox2.transform.localPosition = new Vector3(-2f, -45.1f);
			textBox3.transform.localPosition = new Vector3(328f, -45.1f);

			textBox1.GetComponent<Text>().text = "Gas cars use gasoline for fuel (power). They are the least expensive and the fastest, but also the least fuel-efficient (you need more fuel to go the same distance).";
			textBox2.GetComponent<Text>().text = "Electric cars use electricity for fuel (power). They are the most fuel-efficient (you can go farther with less fuel), but also the most expensive and slowest.";
			textBox3.GetComponent<Text>().text = "Hybrid cars use two different power sources, like a gas engine and an electric motor. Hybrid cars cost less and drive faster than electric cars. They are more fuel-efficient than gas cars.";

			hybridButton.GetComponent<Image>().color = infoActiveColor;
			gasButton.GetComponent<Image>().color = infoActiveColor;
			electricButton.GetComponent<Image>().color = infoActiveColor;
			break;

		case 1:
			textBox1.transform.localPosition = new Vector3(-332f, -45.1f);
			textBox2.transform.localPosition = new Vector3(-2f, -45.1f);
			
			textBox1.GetComponent<Text>().text = "With All-Wheel-Drive, all four wheels receive power at the same time increasing control and traction in all road conditions. It costs more and is less fuel-efficient.";
			textBox2.GetComponent<Text>().text = "With 2-Wheel-Drive, only two of the wheels receive power at the same time. It costs less and is more fuel-efficient.";
			
			fourWheelDriveButton.GetComponent<Image>().color = infoActiveColor;
			twoWheelDriveButton.GetComponent<Image>().color = infoActiveColor;
			break;
		case 2:
			textBox1.transform.localPosition = new Vector3(-332f, -45.1f);
			textBox2.transform.localPosition = new Vector3(-2f, -45.1f);
			
			textBox1.GetComponent<Text>().text = "An automatic transmission changes gears without help from the driver. It drives slower and costs more but is more fuel-efficient.";
			textBox2.GetComponent<Text>().text = "A manual transmission requires the driver to change gears. It usually costs less and drives faster but is less fuel-efficient.";
			
			manualButton.GetComponent<Image>().color = infoActiveColor;
			automaticButton.GetComponent<Image>().color = infoActiveColor;
			break;
		case 3:
			textBox0 = Instantiate(lgTextPanel) as GameObject;
			lg_box_text = Instantiate(lgTextBoxPref) as GameObject;
			closeWindowButton = Instantiate(x_button) as GameObject;
			textBox0.transform.parent = infoParent.transform;
			lg_box_text.transform.parent = infoParent.transform;
			closeWindowButton.transform.parent = infoParent.transform;
			lg_box_text.GetComponent<Text>().text = "Body style is the shape of your car. Shapes that are low and small reduce the drag from the air, making them more aerodynamic, faster, and more fuel-efficient. Larger cars are usually more expensive.";
			textBox0.transform.localPosition = new Vector3(0f, 0f);
			lg_box_text.transform.localPosition = new Vector3(0f, -60f);
			closeWindowButton.transform.localPosition = new Vector3(400f, 145f);
			lg_box_text.GetComponent<Text>().fontSize = 30;

			break;
		case 4:
			textBox0 = Instantiate(lgTextPanel) as GameObject;
			lg_box_text = Instantiate(lgTextBoxPref) as GameObject;
			closeWindowButton = Instantiate(x_button) as GameObject;
			textBox0.transform.parent = infoParent.transform;
			lg_box_text.transform.parent = infoParent.transform;
			closeWindowButton.transform.parent = infoParent.transform;
			lg_box_text.GetComponent<Text>().text = "A spoiler spreads the flow of air around a car, making the car more fuel-efficient and safer at higher speeds. Adding a spoiler increases the cost of your car.";
			textBox0.transform.localPosition = new Vector3(0f, 0f);
			lg_box_text.transform.localPosition = new Vector3(0f, -60f);
			closeWindowButton.transform.localPosition = new Vector3(400f, 145f);
			lg_box_text.GetComponent<Text>().fontSize = 30;
			
			break;
		case 5:
			textBox0 = Instantiate(lgTextPanel) as GameObject;
			lg_box_text = Instantiate(lgTextBoxPref) as GameObject;
			closeWindowButton = Instantiate(x_button) as GameObject;
			textBox0.transform.parent = infoParent.transform;
			lg_box_text.transform.parent = infoParent.transform;
			closeWindowButton.transform.parent = infoParent.transform;
			lg_box_text.GetComponent<Text>().text = "The wheel design affects the cost of your car. Unless the wheels are very lightweight, they usually won’t affect fuel efficiency or speed.";
			textBox0.transform.localPosition = new Vector3(0f, 0f);
			lg_box_text.transform.localPosition = new Vector3(0f, -60f);
			closeWindowButton.transform.localPosition = new Vector3(400f, 145f);
			lg_box_text.GetComponent<Text>().fontSize = 30;
			
			break;
		case 6:
			textBox0 = Instantiate(lgTextPanel) as GameObject;
			lg_box_text = Instantiate(lgTextBoxPref) as GameObject;
			closeWindowButton = Instantiate(x_button) as GameObject;
			textBox0.transform.parent = infoParent.transform;
			lg_box_text.transform.parent = infoParent.transform;
			closeWindowButton.transform.parent = infoParent.transform;
			lg_box_text.GetComponent<Text>().text = "The paint job affects the cost of your car, but it won’t affect fuel efficiency or speed.";
			textBox0.transform.localPosition = new Vector3(0f, 0f);
			lg_box_text.transform.localPosition = new Vector3(0f, -60f);
			closeWindowButton.transform.localPosition = new Vector3(400f, 145f);
			lg_box_text.GetComponent<Text>().fontSize = 30;
			
			break;
		case 7:
			textBox0 = Instantiate(lgTextPanel) as GameObject;
			lg_box_text = Instantiate(lgTextBoxPref) as GameObject;
			closeWindowButton = Instantiate(x_button) as GameObject;
			textBox0.transform.parent = infoParent.transform;
			lg_box_text.transform.parent = infoParent.transform;
			closeWindowButton.transform.parent = infoParent.transform;
			lg_box_text.GetComponent<Text>().text = "A decal decorates your car and will increase cost, but it won’t affect fuel efficiency or speed.";
			textBox0.transform.localPosition = new Vector3(0f, 0f);
			lg_box_text.transform.localPosition = new Vector3(0f, -60f);
			closeWindowButton.transform.localPosition = new Vector3(400f, 145f);
			lg_box_text.GetComponent<Text>().fontSize = 30;
			
			break;
		default:
			break;
		}
		if (textBox1 != null)
		{
			if (textBox2 != null)
			{
				if (textBox3 != null)
				{
					textBox1.GetComponent<Button>().onClick.AddListener(() => { removeInfoText(); });
					textBox2.GetComponent<Button>().onClick.AddListener(() => { removeInfoText(); });
					textBox3.GetComponent<Button>().onClick.AddListener(() => { removeInfoText(); });
				}	
			}
		}
		if (closeWindowButton != null)
		{
			closeWindowButton.GetComponent<Button>().onClick.AddListener(() => { removeInfoText(); });
		}
	}

	void removeInfoText()
	{
		if (textBox1 != null)
		{
			Destroy(textBox1);
			if (textBox2 != null)
			{
				Destroy(textBox2);
				if (textBox3 != null)
				{
					Destroy(textBox3);
				}
			}
		}
		switch (screenIndex)
		{
		case 0:
			electricButton.GetComponent<Image>().color = infoInactiveColor;
			gasButton.GetComponent<Image>().color = infoInactiveColor;
			hybridButton.GetComponent<Image>().color = infoInactiveColor;
			fuelInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
			transmissionInfoButton.GetComponent<Image>().sprite= infoInactiveImage;
			drivetrainInfoButton.GetComponent<Image>().sprite= infoInactiveImage;
			break;
		case 1:
			electricButton.GetComponent<Image>().color = infoInactiveColor;
			gasButton.GetComponent<Image>().color = infoInactiveColor;
			hybridButton.GetComponent<Image>().color = infoInactiveColor;
			fuelInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
			transmissionInfoButton.GetComponent<Image>().sprite= infoInactiveImage;
			drivetrainInfoButton.GetComponent<Image>().sprite= infoInactiveImage;
			break;
		case 2:
			electricButton.GetComponent<Image>().color = infoInactiveColor;
			gasButton.GetComponent<Image>().color = infoInactiveColor;
			hybridButton.GetComponent<Image>().color = infoInactiveColor;
			fuelInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
			transmissionInfoButton.GetComponent<Image>().sprite= infoInactiveImage;
			drivetrainInfoButton.GetComponent<Image>().sprite= infoInactiveImage;
			break;
		case 3:
			Destroy(textBox0);
			Destroy (lg_box_text);
			Destroy (closeWindowButton);
			bodyStyleInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
			break;
		case 4:
			Destroy(textBox0);
			Destroy (lg_box_text);
			Destroy (closeWindowButton);
			spoilerInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
			break;
		case 5:
			Destroy(textBox0);
			Destroy (lg_box_text);
			Destroy (closeWindowButton);
			wheelInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
			break;
		case 7:
			Destroy(textBox0);
			Destroy (lg_box_text);
			Destroy (closeWindowButton);
			decalInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
			break;
		default:
			break;
	}	}

}