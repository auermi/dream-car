//Written by Michael Andrew Auer for the Indianapolis Museum of Art Dream Car iPad Application
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayInformation : MonoBehaviour {

	public GameObject fuelInfoButtonfull;
	public GameObject transmissionInfoButtonfull;
	public GameObject drivetrainInfoButtonfull;
	public GameObject bodyStyleInfoButtonfull;
	public GameObject spoilerInfoButtonfull;
	public GameObject wheelInfoButtonfull;
	public GameObject colorInfoButtonfull;
	public GameObject decalInfoButtonfull;

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

	private GameObject textBox0;
	private GameObject textBox1;
	private GameObject textBox2;
	private GameObject textBox3;

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

	private GameObject infoBoxShadow1;
	private GameObject infoBoxShadow2;
	private GameObject infoBoxShadow3;
	public GameObject infoBoxShadowPrefab;

	private GameObject closeInfoButtonOverlay;
	public GameObject closeInfoButtonOverlayPrefab;


	public Sprite infoActiveImage;
	public Sprite infoInactiveImage;

	public GameObject previous_Button;
	public GameObject next_Button;
	public GameObject restart_Button;
	public GameObject no_button;

	/// <summary>
	/// screenIndex-
	///	0:fuel
	/// 1:transmission
	/// 2:drivetrain
	/// </summary>

	// Use this for initialization
	void Start () {
		fuelInfoButtonfull.GetComponent<Button>().onClick.AddListener(() => { 
			screenIndex = 0;
			removeInfoText();
			textSwap(); 
			changeInfoIcon();
		});
		transmissionInfoButtonfull.GetComponent<Button>().onClick.AddListener(() => { 
			screenIndex = 1; 
			removeInfoText();
			textSwap();
			changeInfoIcon();
		});
		drivetrainInfoButtonfull.GetComponent<Button>().onClick.AddListener(() => { 
			screenIndex = 2; 
			removeInfoText();
			textSwap(); 
			changeInfoIcon();
		});

		bodyStyleInfoButtonfull.GetComponent<Button>().onClick.AddListener(() => {
			screenIndex = 3;
			removeInfoText();
			textSwap ();
			changeInfoIcon();
		});

		spoilerInfoButtonfull.GetComponent<Button>().onClick.AddListener(() => {
			screenIndex = 4;
			removeInfoText();
			textSwap ();
			changeInfoIcon();
		});

		wheelInfoButtonfull.GetComponent<Button>().onClick.AddListener(() => {
			screenIndex = 5;
			removeInfoText();
			textSwap ();
			changeInfoIcon();
		});
		colorInfoButtonfull.GetComponent<Button>().onClick.AddListener(() => {
			screenIndex = 6;
			removeInfoText();
			textSwap ();
			changeInfoIcon();
		});
		decalInfoButtonfull.GetComponent<Button>().onClick.AddListener(() => {
			screenIndex = 7;
			removeInfoText();
			textSwap ();
			changeInfoIcon();
		});


		previous_Button.GetComponent<Button> ().onClick.AddListener (() => { removeInfoText(); ResetInfoIcons(); });
		next_Button.GetComponent<Button> ().onClick.AddListener (() => { removeInfoText(); ResetInfoIcons(); });
		restart_Button.GetComponent<Button> ().onClick.AddListener (() => { removeInfoText(); ResetInfoIcons(); });
		no_button.GetComponent<Button> ().onClick.AddListener (() => { removeInfoText(); ResetInfoIcons(); });


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


		switch (screenIndex)
		{
		case 0:


			infoBoxShadow1 = Instantiate(infoBoxShadowPrefab) as GameObject;
			infoBoxShadow2 = Instantiate(infoBoxShadowPrefab) as GameObject;
			infoBoxShadow3 = Instantiate(infoBoxShadowPrefab) as GameObject;

			infoBoxShadow1.transform.localScale = new Vector3(0.97f, .965f);
			infoBoxShadow2.transform.localScale = new Vector3(0.97f, .965f);
			infoBoxShadow3.transform.localScale = new Vector3(0.97f, .965f);
			
			infoBoxShadow1.transform.SetParent(infoParent.transform);
			infoBoxShadow2.transform.SetParent(infoParent.transform);
			infoBoxShadow3.transform.SetParent(infoParent.transform);
			
			infoBoxShadow1.transform.localPosition = new Vector3(-660f, -100f);
			infoBoxShadow2.transform.localPosition = new Vector3(0f, -100f);
			infoBoxShadow3.transform.localPosition = new Vector3(660f, -100f);

			textBox1 = Instantiate(textBoxPref) as GameObject;
			textBox2 = Instantiate(textBoxPref) as GameObject;
			textBox3 = Instantiate(textBoxPref) as GameObject;

			textBox1.transform.localScale = new Vector3(0.97f, .965f);
			textBox2.transform.localScale = new Vector3(0.97f, .965f);
			textBox3.transform.localScale = new Vector3(0.97f, .965f);
			
			textBox1.transform.SetParent(infoParent.transform);
			textBox2.transform.SetParent(infoParent.transform);
			textBox3.transform.SetParent(infoParent.transform);

			textBox1.transform.localPosition = new Vector3(-660f, -90f);
			textBox2.transform.localPosition = new Vector3(0f, -90f);
			textBox3.transform.localPosition = new Vector3(660f, -90f);

			textBox1.GetComponent<Text>().text = "Gas cars are powered by gasoline. Inexpensive and fast but not fuel-efficient, you will need more fuel to go the same distance.";
			textBox2.GetComponent<Text>().text = "Electric cars are powered by electricity. They are the most fuel-efficient, but also expensive and slow.";
			textBox3.GetComponent<Text>().text = "Hybrid cars with a gas engine and an electric motor are less expensive and faster than electric cars and more fuel-efficient than gas cars.";



			closeInfoButtonOverlay = Instantiate(closeInfoButtonOverlayPrefab) as GameObject;

			closeInfoButtonOverlay.transform.SetParent(infoParent.transform);

			closeInfoButtonOverlay.transform.localPosition = new Vector3(0f, 0f);




			break;
		case 1:
			transmissionInfoButton.GetComponent<Image>().sprite= infoActiveImage;

			infoBoxShadow1 = Instantiate(infoBoxShadowPrefab) as GameObject;
			infoBoxShadow2 = Instantiate(infoBoxShadowPrefab) as GameObject;
			
			infoBoxShadow1.transform.SetParent(infoParent.transform);
			infoBoxShadow2.transform.SetParent(infoParent.transform);
			
			infoBoxShadow1.transform.localPosition = new Vector3(-330f, -100f);
			infoBoxShadow2.transform.localPosition = new Vector3(330f, -100f);

			textBox1 = Instantiate(textBoxPref) as GameObject;
			textBox2 = Instantiate(textBoxPref) as GameObject;
			
			
			textBox1.transform.SetParent(infoParent.transform);
			textBox2.transform.SetParent(infoParent.transform);
			textBox1.transform.localPosition = new Vector3(-330f, -90f);
			textBox2.transform.localPosition = new Vector3(330f, -90f);
			
			textBox1.GetComponent<Text>().text = "An automatic transmission changes gears without help from the driver. It drives slower and costs more but is more fuel-efficient.";
			textBox2.GetComponent<Text>().text = "A manual transmission requires the driver to change gears. It usually costs less and drives faster but is less fuel-efficient.";
			
			closeInfoButtonOverlay = Instantiate(closeInfoButtonOverlayPrefab) as GameObject;
			
			closeInfoButtonOverlay.transform.SetParent(infoParent.transform);
			
			closeInfoButtonOverlay.transform.localPosition = new Vector3(0f, 0f);

			break;
		case 2:
			
			drivetrainInfoButton.GetComponent<Image>().sprite= infoActiveImage;

			infoBoxShadow1 = Instantiate(infoBoxShadowPrefab) as GameObject;
			infoBoxShadow2 = Instantiate(infoBoxShadowPrefab) as GameObject;
			
			infoBoxShadow1.transform.SetParent(infoParent.transform);
			infoBoxShadow2.transform.SetParent(infoParent.transform);
			
			infoBoxShadow1.transform.localPosition = new Vector3(-330f, -100f);
			infoBoxShadow2.transform.localPosition = new Vector3(330f, -100f);

			textBox1 = Instantiate(textBoxPref) as GameObject;
			textBox2 = Instantiate(textBoxPref) as GameObject;

			
			textBox1.transform.SetParent(infoParent.transform);
			textBox2.transform.SetParent(infoParent.transform);

			textBox1.transform.localPosition = new Vector3(-330f, -90f);
			textBox2.transform.localPosition = new Vector3(330f, -90f);
			
			textBox1.GetComponent<Text>().text = "2-Wheel-Drive sends power to two of the wheels at once. It costs less and is more fuel-efficient.";
			textBox2.GetComponent<Text>().text = "All-Wheel-Drive sends power to all wheels at once. It costs more and is less fuel-efficient but makes for better handling.";
			
			closeInfoButtonOverlay = Instantiate(closeInfoButtonOverlayPrefab) as GameObject;
			
			closeInfoButtonOverlay.transform.SetParent(infoParent.transform);
			
			closeInfoButtonOverlay.transform.localPosition = new Vector3(0f, 0f);

			break;
		
		case 3:
			textBox0 = Instantiate(lgTextPanel) as GameObject;
			lg_box_text = Instantiate(lgTextBoxPref) as GameObject;

			textBox0.transform.SetParent(infoParent.transform);
			lg_box_text.transform.SetParent(infoParent.transform);

			lg_box_text.GetComponent<Text>().text = "Body style is the car’s shape. Low and small styles are aerodynamic (less drag from the air), faster and more fuel-efficient. Big cars usually cost more.";

			textBox0.transform.localPosition = new Vector3(0f, 0f);
			lg_box_text.transform.localPosition = new Vector3(0f, 0f);

			lg_box_text.GetComponent<Text>().fontSize = 40;

			closeInfoButtonOverlay = Instantiate(closeInfoButtonOverlayPrefab) as GameObject;
			
			closeInfoButtonOverlay.transform.SetParent(infoParent.transform);
			
			closeInfoButtonOverlay.transform.localPosition = new Vector3(0f, 0f);

			break;
		case 4:
			textBox0 = Instantiate(lgTextPanel) as GameObject;
			lg_box_text = Instantiate(lgTextBoxPref) as GameObject;

			textBox0.transform.SetParent(infoParent.transform);
			lg_box_text.transform.SetParent(infoParent.transform);

			lg_box_text.GetComponent<Text>().text = "A spoiler increases fuel efficiency by spreading airflow around a car. A spoiler increases cost, but makes it safer at higher speeds.";

			textBox0.transform.localPosition = new Vector3(0f, 0f);
			lg_box_text.transform.localPosition = new Vector3(0f, 0f);

			lg_box_text.GetComponent<Text>().fontSize = 40;

			closeInfoButtonOverlay = Instantiate(closeInfoButtonOverlayPrefab) as GameObject;
			
			closeInfoButtonOverlay.transform.SetParent(infoParent.transform);
			
			closeInfoButtonOverlay.transform.localPosition = new Vector3(0f, 0f);
			
			break;
		case 5:
			textBox0 = Instantiate(lgTextPanel) as GameObject;
			lg_box_text = Instantiate(lgTextBoxPref) as GameObject;
	
			textBox0.transform.SetParent(infoParent.transform);
			lg_box_text.transform.SetParent(infoParent.transform);

			lg_box_text.GetComponent<Text>().text = "The type of wheel can increase the cost of your car, but usually won’t affect fuel efficiency or speed.";

			textBox0.transform.localPosition = new Vector3(0f, 0f);
			lg_box_text.transform.localPosition = new Vector3(0f, 0f);

			lg_box_text.GetComponent<Text>().fontSize = 40;

			closeInfoButtonOverlay = Instantiate(closeInfoButtonOverlayPrefab) as GameObject;
			
			closeInfoButtonOverlay.transform.SetParent(infoParent.transform);
			
			closeInfoButtonOverlay.transform.localPosition = new Vector3(0f, 0f);
			
			break;
		case 6:
			textBox0 = Instantiate(lgTextPanel) as GameObject;
			lg_box_text = Instantiate(lgTextBoxPref) as GameObject;

			textBox0.transform.SetParent(infoParent.transform);
			lg_box_text.transform.SetParent(infoParent.transform);

			lg_box_text.GetComponent<Text>().text = "The paint job affects the cost of your car, but not fuel efficiency or speed.";

			textBox0.transform.localPosition = new Vector3(0f, 0f);
			lg_box_text.transform.localPosition = new Vector3(0f, 0f);
		
			lg_box_text.GetComponent<Text>().fontSize = 40;

			closeInfoButtonOverlay = Instantiate(closeInfoButtonOverlayPrefab) as GameObject;
			
			closeInfoButtonOverlay.transform.SetParent(infoParent.transform);
			
			closeInfoButtonOverlay.transform.localPosition = new Vector3(0f, 0f);

			break;
		case 7:
			textBox0 = Instantiate(lgTextPanel) as GameObject;
			lg_box_text = Instantiate(lgTextBoxPref) as GameObject;

			textBox0.transform.SetParent(infoParent.transform);
			lg_box_text.transform.SetParent(infoParent.transform);

			lg_box_text.GetComponent<Text>().text = "A decal decorates your car and will increase cost, but it won’t affect fuel efficiency or speed.";

			textBox0.transform.localPosition = new Vector3(0f, 0f);
			lg_box_text.transform.localPosition = new Vector3(0f, 0f);

			lg_box_text.GetComponent<Text>().fontSize = 40;

			closeInfoButtonOverlay = Instantiate(closeInfoButtonOverlayPrefab) as GameObject;
			
			closeInfoButtonOverlay.transform.SetParent(infoParent.transform);
			
			closeInfoButtonOverlay.transform.localPosition = new Vector3(0f, 0f);
			
			break;
		default:
			break;
		}

		closeInfoButtonOverlay.GetComponent<Button>().onClick.AddListener(() => { removeInfoText(); deactivateInfoIcon(); });
	}

	void removeInfoText()
	{

		changeInfoIcon();

		Destroy(closeInfoButtonOverlay);
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
		if (infoBoxShadow1 != null)
		{
			Destroy(infoBoxShadow1);
			if (infoBoxShadow2 != null)
			{
				Destroy(infoBoxShadow2);
				if (infoBoxShadow3 != null)
				{
					Destroy(infoBoxShadow3);
				}
			}
		}
		if (screenIndex > 2){
			Destroy(textBox0);
			Destroy (lg_box_text);
		}


	}

	void changeInfoIcon()
	{
		if (closeInfoButtonOverlay != null)
		{
			switch(screenIndex)
			{
			case 0:
				fuelInfoButton.GetComponent<Image>().sprite = infoActiveImage;
				break;
			case 1:
				transmissionInfoButton.GetComponent<Image>().sprite = infoActiveImage;
				break;
			case 2: 
				drivetrainInfoButton.GetComponent<Image>().sprite = infoActiveImage;
				break;
			case 3:
				bodyStyleInfoButton.GetComponent<Image>().sprite = infoActiveImage;
				break;
			case 4:
				spoilerInfoButton.GetComponent<Image>().sprite = infoActiveImage;
				break;
			case 5:
				wheelInfoButton.GetComponent<Image>().sprite = infoActiveImage;
				break;
			case 6:
				colorInfoButton.GetComponent<Image>().sprite = infoActiveImage;
				break;
			case 7:
				decalInfoButton.GetComponent<Image>().sprite = infoActiveImage;
				break;
			default:
				break;
			}
		}

			

	}
	void deactivateInfoIcon()
	{
		switch(screenIndex)
		{
		case 0:
			fuelInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
			break;
		case 1:
			transmissionInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
			break;
		case 2: 
			drivetrainInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
			break;
		case 3:
			bodyStyleInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
			break;
		case 4:
			spoilerInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
			break;
		case 5:
			wheelInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
			break;
		case 6:
			colorInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
			break;
		case 7:
			decalInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
			break;
		default:
			break;
		}
	}

	void ResetInfoIcons ()
	{
		fuelInfoButton.GetComponent<Image> ().sprite = infoInactiveImage;
		transmissionInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
		drivetrainInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
		bodyStyleInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
		spoilerInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
		wheelInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
		colorInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
		decalInfoButton.GetComponent<Image>().sprite = infoInactiveImage;
	}
}
