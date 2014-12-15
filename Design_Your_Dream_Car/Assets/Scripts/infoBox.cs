using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class infoBox : MonoBehaviour {

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

	private int arrIndex;

	public GameObject infoParent;

	private GameObject infoBoxShadow1;
	private GameObject infoBoxShadow2;
	private GameObject infoBoxShadow3;
	public GameObject infoBoxShadowPrefab;

	private GameObject closeInfoButtonOverlay;
	public GameObject closeInfoButtonOverlayPrefab;


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

	public GameObject nxt2;
	public GameObject nxt3;
	public GameObject nxt4;
	public GameObject nxt6;
	public GameObject nxt7;
	public GameObject nxt8;
	public GameObject nxt9;
	public GameObject nxt10;
	public GameObject p2;
	public GameObject p3;
	public GameObject p4;
	public GameObject p6;
	public GameObject p7;
	public GameObject p8;
	public GameObject p9;
	public GameObject p10;
	 
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
			textSwap(); 
			changeInfoIcon();
			hybridButton.GetComponent<Image>().sprite = inactiveHybrid;
			gasButton.GetComponent<Image>().sprite = inactiveGas;
			electricButton.GetComponent<Image>().sprite = inactiveElectric;
		});
		transmissionInfoButtonfull.GetComponent<Button>().onClick.AddListener(() => { 
			screenIndex = 1; 
			textSwap();
			changeInfoIcon();
			manualButton.GetComponent<Image>().sprite = inactiveManual;
			automaticButton.GetComponent<Image>().sprite = inactiveAutomatic;
		});
		drivetrainInfoButtonfull.GetComponent<Button>().onClick.AddListener(() => { 
			screenIndex = 2; 
			textSwap(); 
			changeInfoIcon();
			fourWheelDriveButton.GetComponent<Image>().sprite = inactiveFourWheelDrive;
			twoWheelDriveButton.GetComponent<Image>().sprite = inactiveTwoWheelDrive;
		});

		bodyStyleInfoButtonfull.GetComponent<Button>().onClick.AddListener(() => {
			screenIndex = 3;
			textSwap ();
			changeInfoIcon();
			truckButton.GetComponent<Image>().sprite = truckInactive;
			coupeButton.GetComponent<Image>().sprite = coupeInactive;
			compactButton.GetComponent<Image>().sprite = compactInactive;
			suvButton.GetComponent<Image>().sprite = suvInactive;
			vanButton.GetComponent<Image>().sprite = vanInactive;
		});

		spoilerInfoButtonfull.GetComponent<Button>().onClick.AddListener(() => {
			screenIndex = 4;
			textSwap ();
			changeInfoIcon();
		});

		wheelInfoButtonfull.GetComponent<Button>().onClick.AddListener(() => {
			screenIndex = 5;
			textSwap ();
			changeInfoIcon();
		});
		colorInfoButtonfull.GetComponent<Button>().onClick.AddListener(() => {
			screenIndex = 6;
			textSwap ();
			changeInfoIcon();
		});
		decalInfoButtonfull.GetComponent<Button>().onClick.AddListener(() => {
			screenIndex = 7;
			textSwap ();
			changeInfoIcon();
		});

		nxt2.GetComponent<Button>().onClick.AddListener( () => { removeInfoText(); screenIndex = 2;});
		nxt3.GetComponent<Button>().onClick.AddListener( () => { removeInfoText(); screenIndex = 3; });
		nxt4.GetComponent<Button>().onClick.AddListener( () => { removeInfoText(); screenIndex = 4; });
		nxt6.GetComponent<Button>().onClick.AddListener( () => { removeInfoText(); screenIndex = 6; });
		nxt7.GetComponent<Button>().onClick.AddListener( () => { removeInfoText(); screenIndex = 7; });
		nxt8.GetComponent<Button>().onClick.AddListener( () => { removeInfoText(); screenIndex = 8; });
		nxt9.GetComponent<Button>().onClick.AddListener( () => { removeInfoText();; screenIndex = 9; });
		nxt10.GetComponent<Button>().onClick.AddListener( () => { removeInfoText(); screenIndex = 10; });

		p2.GetComponent<Button>().onClick.AddListener( () => { removeInfoText(); screenIndex = 2;});
		p3.GetComponent<Button>().onClick.AddListener( () => { removeInfoText(); screenIndex = 3; });
		p4.GetComponent<Button>().onClick.AddListener( () => { removeInfoText(); screenIndex = 4; });
		p6.GetComponent<Button>().onClick.AddListener( () => { removeInfoText(); screenIndex = 6; });
		p7.GetComponent<Button>().onClick.AddListener( () => { removeInfoText(); screenIndex = 7; });
		p8.GetComponent<Button>().onClick.AddListener( () => { removeInfoText(); screenIndex = 8; });
		p9.GetComponent<Button>().onClick.AddListener( () => { removeInfoText();; screenIndex = 9; });
		p10.GetComponent<Button>().onClick.AddListener( () => { removeInfoText(); screenIndex = 10; });

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
			
			infoBoxShadow1.transform.parent = infoParent.transform;
			infoBoxShadow2.transform.parent = infoParent.transform;
			infoBoxShadow3.transform.parent = infoParent.transform;
			
			infoBoxShadow1.transform.localPosition = new Vector3(-330f, -50f);
			infoBoxShadow2.transform.localPosition = new Vector3(0f, -50f);
			infoBoxShadow3.transform.localPosition = new Vector3(330f, -50f);

			textBox1 = Instantiate(textBoxPref) as GameObject;
			textBox2 = Instantiate(textBoxPref) as GameObject;
			textBox3 = Instantiate(textBoxPref) as GameObject;
			
			textBox1.transform.parent = infoParent.transform;
			textBox2.transform.parent = infoParent.transform;
			textBox3.transform.parent = infoParent.transform;

			textBox1.transform.localPosition = new Vector3(-332f, -45.1f);
			textBox2.transform.localPosition = new Vector3(-2f, -45.1f);
			textBox3.transform.localPosition = new Vector3(328f, -45.1f);

			textBox1.GetComponent<Text>().text = "Gas cars are powered by gasoline. Inexpensive and fast but not fuel-efficient, you will need more fuel to go the same distance.";
			textBox2.GetComponent<Text>().text = "Electric cars are powered by electricity. They are the most fuel-efficient, but also expensive and slow.";
			textBox3.GetComponent<Text>().text = "Hybrid cars with a gas engine and an electric motor are less expensive and faster than electric cars and more fuel-efficient than gas cars.";



			closeInfoButtonOverlay = Instantiate(closeInfoButtonOverlayPrefab) as GameObject;

			closeInfoButtonOverlay.transform.parent = infoParent.transform;

			closeInfoButtonOverlay.transform.localPosition = new Vector3(0f, 0f);




			break;
		case 1:
			transmissionInfoButton.GetComponent<Image>().sprite= infoActiveImage;

			infoBoxShadow1 = Instantiate(infoBoxShadowPrefab) as GameObject;
			infoBoxShadow2 = Instantiate(infoBoxShadowPrefab) as GameObject;
			
			infoBoxShadow1.transform.parent = infoParent.transform;
			infoBoxShadow2.transform.parent = infoParent.transform;
			
			infoBoxShadow1.transform.localPosition = new Vector3(-165f, -50f);
			infoBoxShadow2.transform.localPosition = new Vector3(165f, -50f);

			textBox1 = Instantiate(textBoxPref) as GameObject;
			textBox2 = Instantiate(textBoxPref) as GameObject;
			
			
			textBox1.transform.parent = infoParent.transform;
			textBox2.transform.parent = infoParent.transform;
			textBox1.transform.localPosition = new Vector3(-165f, -45.1f);
			textBox2.transform.localPosition = new Vector3(165f, -45.1f);
			
			textBox1.GetComponent<Text>().text = "An automatic transmission changes gears without help from the driver. It drives slower and costs more but is more fuel-efficient.";
			textBox2.GetComponent<Text>().text = "A manual transmission requires the driver to change gears. It usually costs less and drives faster but is less fuel-efficient.";
			
			closeInfoButtonOverlay = Instantiate(closeInfoButtonOverlayPrefab) as GameObject;
			
			closeInfoButtonOverlay.transform.parent = infoParent.transform;
			
			closeInfoButtonOverlay.transform.localPosition = new Vector3(0f, 0f);

			break;
		case 2:
			
			drivetrainInfoButton.GetComponent<Image>().sprite= infoActiveImage;

			infoBoxShadow1 = Instantiate(infoBoxShadowPrefab) as GameObject;
			infoBoxShadow2 = Instantiate(infoBoxShadowPrefab) as GameObject;
			
			infoBoxShadow1.transform.parent = infoParent.transform;
			infoBoxShadow2.transform.parent = infoParent.transform;
			
			infoBoxShadow1.transform.localPosition = new Vector3(-165f, -50f);
			infoBoxShadow2.transform.localPosition = new Vector3(165f, -50f);

			textBox1 = Instantiate(textBoxPref) as GameObject;
			textBox2 = Instantiate(textBoxPref) as GameObject;

			
			textBox1.transform.parent = infoParent.transform;
			textBox2.transform.parent = infoParent.transform;

			textBox1.transform.localPosition = new Vector3(-165f, -45.1f);
			textBox2.transform.localPosition = new Vector3(165f, -45.1f);
			
			textBox1.GetComponent<Text>().text = "2-Wheel-Drive sends power to two of the wheels at once. It costs less and is more fuel-efficient.";
			textBox2.GetComponent<Text>().text = "All-Wheel-Drive sends power to all wheels at once. It costs more and is less fuel-efficient but makes for better handling.";
			
			closeInfoButtonOverlay = Instantiate(closeInfoButtonOverlayPrefab) as GameObject;
			
			closeInfoButtonOverlay.transform.parent = infoParent.transform;
			
			closeInfoButtonOverlay.transform.localPosition = new Vector3(0f, 0f);

			break;
		
		case 3:
			textBox0 = Instantiate(lgTextPanel) as GameObject;
			lg_box_text = Instantiate(lgTextBoxPref) as GameObject;

			textBox0.transform.parent = infoParent.transform;
			lg_box_text.transform.parent = infoParent.transform;

			lg_box_text.GetComponent<Text>().text = "Body style is the car’s shape. Low and small styles are aerodynamic (less drag from the air), faster and more fuel-efficient. Big cars usually cost more.";

			textBox0.transform.localPosition = new Vector3(0f, 0f);
			lg_box_text.transform.localPosition = new Vector3(0f, 0f);

			lg_box_text.GetComponent<Text>().fontSize = 25;

			closeInfoButtonOverlay = Instantiate(closeInfoButtonOverlayPrefab) as GameObject;
			
			closeInfoButtonOverlay.transform.parent = infoParent.transform;
			
			closeInfoButtonOverlay.transform.localPosition = new Vector3(0f, 0f);

			break;
		case 4:
			textBox0 = Instantiate(lgTextPanel) as GameObject;
			lg_box_text = Instantiate(lgTextBoxPref) as GameObject;

			textBox0.transform.parent = infoParent.transform;
			lg_box_text.transform.parent = infoParent.transform;

			lg_box_text.GetComponent<Text>().text = "A spoiler increases fuel-efficiency by spreading airflow around a car. A spoiler increases cost, but makes it safer at higher speeds.";

			textBox0.transform.localPosition = new Vector3(0f, 0f);
			lg_box_text.transform.localPosition = new Vector3(0f, 0f);

			lg_box_text.GetComponent<Text>().fontSize = 25;

			closeInfoButtonOverlay = Instantiate(closeInfoButtonOverlayPrefab) as GameObject;
			
			closeInfoButtonOverlay.transform.parent = infoParent.transform;
			
			closeInfoButtonOverlay.transform.localPosition = new Vector3(0f, 0f);
			
			break;
		case 5:
			textBox0 = Instantiate(lgTextPanel) as GameObject;
			lg_box_text = Instantiate(lgTextBoxPref) as GameObject;
	
			textBox0.transform.parent = infoParent.transform;
			lg_box_text.transform.parent = infoParent.transform;

			lg_box_text.GetComponent<Text>().text = "The type of wheel can increase the cost of your car, but usually won’t affect fuel-efficiency or speed.";

			textBox0.transform.localPosition = new Vector3(0f, 0f);
			lg_box_text.transform.localPosition = new Vector3(0f, 0f);

			lg_box_text.GetComponent<Text>().fontSize = 25;

			closeInfoButtonOverlay = Instantiate(closeInfoButtonOverlayPrefab) as GameObject;
			
			closeInfoButtonOverlay.transform.parent = infoParent.transform;
			
			closeInfoButtonOverlay.transform.localPosition = new Vector3(0f, 0f);
			
			break;
		case 6:
			textBox0 = Instantiate(lgTextPanel) as GameObject;
			lg_box_text = Instantiate(lgTextBoxPref) as GameObject;

			textBox0.transform.parent = infoParent.transform;
			lg_box_text.transform.parent = infoParent.transform;

			lg_box_text.GetComponent<Text>().text = "The paint job affects the cost of your car, but not fuel efficiency or speed.";

			textBox0.transform.localPosition = new Vector3(0f, 0f);
			lg_box_text.transform.localPosition = new Vector3(0f, 0f);
		
			lg_box_text.GetComponent<Text>().fontSize = 25;

			closeInfoButtonOverlay = Instantiate(closeInfoButtonOverlayPrefab) as GameObject;
			
			closeInfoButtonOverlay.transform.parent = infoParent.transform;
			
			closeInfoButtonOverlay.transform.localPosition = new Vector3(0f, 0f);

			break;
		case 7:
			textBox0 = Instantiate(lgTextPanel) as GameObject;
			lg_box_text = Instantiate(lgTextBoxPref) as GameObject;

			textBox0.transform.parent = infoParent.transform;
			lg_box_text.transform.parent = infoParent.transform;

			lg_box_text.GetComponent<Text>().text = "A decal decorates your car and will increase cost, but it won’t affect fuel efficiency or speed.";

			textBox0.transform.localPosition = new Vector3(0f, 0f);
			lg_box_text.transform.localPosition = new Vector3(0f, 0f);

			lg_box_text.GetComponent<Text>().fontSize = 25;

			closeInfoButtonOverlay = Instantiate(closeInfoButtonOverlayPrefab) as GameObject;
			
			closeInfoButtonOverlay.transform.parent = infoParent.transform;
			
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
}
