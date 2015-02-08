//Written by Michael Andrew Auer for the Indianapolis Museum of Art Dream Car iPad Application
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarCreation : MonoBehaviour {

	public GoogleAnalyticsV3 googleAnalytics;

	public GameObject next_Button;
	public Sprite next_Button_Active;

	//Gathering the gameobject that transition is attached to so we can access the scene index
	public GameObject appSlider_ref;

	//Assign Previous Button so we can remove car parts on click
	public GameObject previous_Button;

	public GameObject truck;
	public GameObject suv;
	public GameObject van;
	public GameObject coupe;
	public GameObject compact;

	public GameObject spoilerContainer;
	public GameObject decalContainer;
	public GameObject bodyContainer;
	public GameObject wheelContainer;

	public GameObject truckButton;
	public GameObject suvButton;
	public GameObject vanButton;
	public GameObject coupeButton;
	public GameObject compactButton;

	public GameObject spoilerButton;
	public GameObject noSpoilerButton;

	public GameObject basicWheelButton;
	public GameObject luxuryWheelButton;
	public GameObject sportyWheelButton;

	public GameObject redButton;
	public GameObject greenButton;
	public GameObject yellowButton;
	public GameObject orangeButton;
	public GameObject turquoiseButton;
	public GameObject carrotButton;
	public GameObject pinkButton;
	public GameObject greyButton;
	public GameObject limeButton;
	public GameObject navyButton;
	public GameObject glaucousButton;

	public GameObject vanSpoiler;
	public GameObject truckSpoiler;
	public GameObject coupeSpoiler;
	public GameObject compactSpoiler;
	public GameObject suvSpoiler;

	public GameObject starButton;
	public GameObject flameButton;
	public GameObject stripeButton;
	public GameObject noDecalButton;

	public GameObject stripe;
	public GameObject flame;
	public GameObject star;

	public GameObject basicWheel;
	public GameObject luxuryWheel;
	public GameObject sportWheel;

	private GameObject leftWheel;
	private GameObject rightWheel;

	private GameObject car;
	private GameObject spoiler;
	private GameObject wheels;
	private GameObject decal;
	private GameObject decal2;

	private int carIndex;
	private int wheelIndex;
	private int colorIndex;
	private int decalIndex;

	private Color32 redColor = new Color32(238, 52, 36, 255);
	private Color32 greenColor = new Color32(0, 169, 79, 255);
	private Color32 yellowColor = new Color32(235, 231, 41, 255);
	private Color32 orangeColor = new Color32(243, 116, 33, 255);
	private Color32 turquoiseColor = new Color32(0, 177, 176, 255);
	private Color32 carrotColor = new Color32(231, 166, 20, 255);
	private Color32 pinkColor = new Color32(248, 179, 186, 255);
	private Color32 greyColor = new Color32(186, 186, 186, 255);
	private Color32 limeColor = new Color32(123, 193, 67, 255);
	private Color32 navyColor = new Color32(0, 75, 135, 255);
	private Color32 glaucousColor = new Color32(65, 89, 96, 255);
	
	public GameObject gasButton;
	public GameObject electricButton;
	public GameObject hybridButton;
	public GameObject automaticButton;
	public GameObject manualButton;
	public GameObject twoWheelDriveButton;
	public GameObject allWheelDriveButton;

	public Sprite gasButtonSprite;
	public Sprite electricButtonSprite;
	public Sprite hybridButtonSprite;
	public Sprite automaticButtonSprite;
	public Sprite manualButtonSprite;
	public Sprite twoWheelDriveButtonSprite;
	public Sprite allWheelDriveButtonSprite;

	public Sprite spoilerSprite;
	public Sprite noSpoilerSprite;
	public Sprite basicWheelSprite;
	public Sprite luxuryWheelSprite;
	public Sprite sportyWheelSprite;
	public Sprite starSprite;
	public Sprite flameSprite;
	public Sprite stripeSprite;
	public Sprite truckSprite;
	public Sprite suvSprite;
	public Sprite vanSprite;
	public Sprite compactSprite;
	public Sprite coupeSprite;

	public GameObject resetButton;

	public Sprite basicWheelButtonSprite;
	public Sprite luxuryWheelButtonSprite;
	public Sprite sportyWheelButtonSprite;
	public Sprite noSpoilerButtonSprite;
	public Sprite spoilerButtonSprite;
	public Sprite stripeButtonSprite;
	public Sprite starsButtonSprite;
	public Sprite flamesButtonSprite;
	public Sprite noDecalButtonSprite;
	public Sprite noDecalButtonActiveSprite;
	public Sprite noSpoilerActivebuttonSprite;
	public Sprite spoilerActiveButtonSprite;
	public Sprite whiteSpoiler;

	public GameObject stripe_compact;


	/// <summary>
	/// carIndex=
	/// 0:Truck
	/// 1:SUV
	/// 2:Van
	/// 3:Coupe
	/// 4:Compact
	///
	/// wheelIndex=
	/// 0:Sport
	/// 1:Luxury
	/// 2:Basic
	///
	/// colorIndex=
	/// 0:Red
	/// 1:Green
	/// 2:Yellow
	/// 3:Orange
	/// 4:Turquoise
	/// 5:Carrot
	/// 6:Pink
	/// 7:Grey
	/// 8:Lime
	/// 9:Navy
	/// 10:Glaucous
	///
	/// decalIndex=
	/// 0:star
	/// 1:flame
	/// 2:stripe
	/// </summary>

	public GameObject no_button;

	// Use this for initialization
	void Start () {

		//Fuel-Type Event Listeners
		gasButton.GetComponent<Button>().onClick.AddListener( () => { EnableNextButton();});
		electricButton.GetComponent<Button>().onClick.AddListener( () => { EnableNextButton();});
		hybridButton.GetComponent<Button>().onClick.AddListener( () => { EnableNextButton();});

		//Transmission Event Listeners
		automaticButton.GetComponent<Button>().onClick.AddListener( () => { EnableNextButton();});
		manualButton.GetComponent<Button>().onClick.AddListener( () => { EnableNextButton();});

		//Drivetrain Event Listeners
		twoWheelDriveButton.GetComponent<Button>().onClick.AddListener( () => { EnableNextButton();});
		allWheelDriveButton.GetComponent<Button>().onClick.AddListener( () => { EnableNextButton();});

		//Car Body Event Listeners
		truckButton.GetComponent<Button>().onClick.AddListener(() => {
			truckSwap();
			EnableNextButton();
		});
		suvButton.GetComponent<Button>().onClick.AddListener(() => {
			suvSwap();
			EnableNextButton();
		});
		vanButton.GetComponent<Button>().onClick.AddListener(() => {
			vanSwap();
			EnableNextButton();
		});
		coupeButton.GetComponent<Button>().onClick.AddListener(() => {
			coupeSwap();
			EnableNextButton();
		});
		compactButton.GetComponent<Button>().onClick.AddListener(() => {
			compactSwap();
			EnableNextButton();
		});

		//Spoiler Event Listeners
		spoilerButton.GetComponent<Button>().onClick.AddListener(() => {
			addSpoiler();
			EnableNextButton();
		});
		noSpoilerButton.GetComponent<Button>().onClick.AddListener(() => {
			removeSpoiler();
			EnableNextButton();
		});

		//Wheel Event Listeners
		basicWheelButton.GetComponent<Button>().onClick.AddListener(() => {
			wheelIndex = 2;
			wheelSwap();
			EnableNextButton();
		});
		luxuryWheelButton.GetComponent<Button>().onClick.AddListener(() => {
			wheelIndex = 1;
			wheelSwap();
			EnableNextButton();
		});
		sportyWheelButton.GetComponent<Button>().onClick.AddListener(() => {
			wheelIndex = 0;
			wheelSwap();
			EnableNextButton();
		});

		//Color Event Listeners
		redButton.GetComponent<Button>().onClick.AddListener(() => {
			colorIndex = 0;
			colorChange();
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = redColor;
			}
			EnableNextButton();
		});
		greenButton.GetComponent<Button>().onClick.AddListener( () => {
			colorIndex = 1;
			colorChange();
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = greenColor;
			}
			EnableNextButton();
		});
		yellowButton.GetComponent<Button>().onClick.AddListener( () => {
			colorIndex = 2;
			colorChange();
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = yellowColor;
			}
			EnableNextButton();
		});
		orangeButton.GetComponent<Button>().onClick.AddListener( () => {
			colorIndex = 3;
			colorChange();
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = orangeColor;
			}
			EnableNextButton();
		});
		turquoiseButton.GetComponent<Button>().onClick.AddListener( () => {
			colorIndex = 4;
			colorChange();
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = turquoiseColor;
			}
			EnableNextButton();
		});
		carrotButton.GetComponent<Button>().onClick.AddListener( () => {
			colorIndex = 5;
			colorChange();
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = carrotColor;
			}
			EnableNextButton();
		});
		pinkButton.GetComponent<Button>().onClick.AddListener( () => {
			colorIndex = 6;
			colorChange();
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = pinkColor;
			}
			EnableNextButton();
		});
		greyButton.GetComponent<Button>().onClick.AddListener( () => {
			colorIndex = 7;
			colorChange();
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = greyColor;
			}
			EnableNextButton();
		});
		limeButton.GetComponent<Button>().onClick.AddListener( () => {
			colorIndex = 8;
			colorChange();
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = limeColor;
			}
			EnableNextButton();
		});
		navyButton.GetComponent<Button>().onClick.AddListener( () => {
			colorIndex = 9;
			colorChange();
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = navyColor;
			}
			EnableNextButton();
		});
		glaucousButton.GetComponent<Button>().onClick.AddListener( () => {
			colorIndex = 10;
			colorChange();
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = glaucousColor;
			}
			EnableNextButton();
		});

		//Decal Event Listeners
		starButton.GetComponent<Button>().onClick.AddListener( () => {
			decalIndex = 0;
			decalChange();
			EnableNextButton();
		});
		flameButton.GetComponent<Button>().onClick.AddListener( () => {
			decalIndex = 1;
			decalChange();
			EnableNextButton();
		});
		stripeButton.GetComponent<Button>().onClick.AddListener( () => {
			decalIndex = 2;
			decalChange();
			EnableNextButton();
		});
		noDecalButton.GetComponent<Button>().onClick.AddListener( () => {
			noDecalButton.GetComponent<Image>().sprite = noDecalButtonActiveSprite;
			removeDecal();
			EnableNextButton();
		});


		//if previous button is pressed we need to check and see if any car parts need to be removed
		previous_Button.GetComponent<Button> ().onClick.AddListener (() => { RemovePreviousCarPart(); });
		//Restart Button handler resets everything
		resetButton.GetComponent<Button> ().onClick.AddListener (() => { resetSelections(); });
		no_button.GetComponent<Button> ().onClick.AddListener (() => { resetSelections(); });
	
	}

	void truckSwap()
	{
		if (car != null)
		{
			Destroy(car);
		}
		carIndex = 0;
		car = Instantiate(truck) as GameObject;
		car.transform.parent = bodyContainer.transform;
		car.transform.localPosition = new Vector3(0f,0f);
	}
	void suvSwap()
	{
		if (car != null)
		{
			Destroy(car);
		}
		carIndex = 1;
		car = Instantiate(suv) as GameObject;
		car.transform.parent = bodyContainer.transform;
		car.transform.localPosition = new Vector3(0f,0f);
	}
	void vanSwap()
	{
		if (car != null)
		{
			Destroy(car);
		}
		carIndex = 2;
		car = Instantiate(van) as GameObject;
		car.transform.parent = bodyContainer.transform;
		car.transform.localPosition = new Vector3(0f,0f);
	}
	void coupeSwap()
	{
		if (car != null)
		{
			Destroy(car);
		}
		carIndex = 3;
		car = Instantiate(coupe) as GameObject;
		car.transform.parent = bodyContainer.transform;
		car.transform.localPosition = new Vector3(0f,0f);
	}
	void compactSwap()
	{
		if (car != null)
		{
			Destroy(car);
		}
		carIndex = 4;
		car = Instantiate(compact) as GameObject;
		car.transform.parent = bodyContainer.transform;
		car.transform.localPosition = new Vector3(0f,0f);
	}

	void addSpoiler ()
	{
		switch(carIndex)
		{
			case 0:
				if (spoiler != null){
					Destroy(spoiler);
				}
				spoiler = Instantiate(truckSpoiler) as GameObject;
				spoiler.transform.parent = spoilerContainer.transform;
				spoiler.transform.localPosition = new Vector3(-500f, 70f);
				break;

			case 1:
				if (spoiler != null){
					Destroy(spoiler);
				}
				spoiler = Instantiate(suvSpoiler) as GameObject;
				spoiler.transform.parent = spoilerContainer.transform;
				spoiler.transform.localPosition = new Vector3(-530f, 245f);
				break;

			case 2:
				if (spoiler != null){
					Destroy(spoiler);
				}
				spoiler = Instantiate(vanSpoiler) as GameObject;
				spoiler.transform.parent = spoilerContainer.transform;
				spoiler.transform.localPosition = new Vector3(-640f, 55f);
				break;

			case 3:
				if (spoiler != null){
					Destroy(spoiler);
				}
				spoiler = Instantiate(coupeSpoiler) as GameObject;
				spoiler.transform.parent = spoilerContainer.transform;
				spoiler.transform.localPosition = new Vector3(-575f, 75f);
				break;

			case 4:
				if (spoiler != null){
					Destroy(spoiler);
				}
				spoiler = Instantiate(compactSpoiler) as GameObject;
				spoiler.transform.parent = spoilerContainer.transform;
				spoiler.transform.localPosition = new Vector3(-400f, 75f);
				break;

			default:
				break;
		}

	}


	void wheelSwap()
	{
		if (leftWheel != null)
		{
			Destroy(leftWheel);
		}
		if (rightWheel != null)
		{
			Destroy(rightWheel);
		}
		
		switch (carIndex)
		{
		case 0:
			switch (wheelIndex)
			{
			case 0:
				leftWheel = Instantiate(sportWheel) as GameObject;
				rightWheel = Instantiate (sportWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-373f, -180f);
				rightWheel.transform.localPosition = new Vector3(463f, -180f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(1f, 1f);
				break;
			case 1:
				leftWheel = Instantiate(luxuryWheel) as GameObject;
				rightWheel = Instantiate (luxuryWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-373f, -180f);
				rightWheel.transform.localPosition = new Vector3(463f, -180f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(1f, 1f);
				break;
			case 2:
				leftWheel = Instantiate(basicWheel) as GameObject;
				rightWheel = Instantiate (basicWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-373f, -180f);
				rightWheel.transform.localPosition = new Vector3(463f, -180f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(1f, 1f);
				break;
			default:
				break;
			}
			break;
		case 1:
			switch (wheelIndex)
			{
			case 0:
				leftWheel = Instantiate(sportWheel) as GameObject;
				rightWheel = Instantiate (sportWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-377f, -200f);
				rightWheel.transform.localPosition = new Vector3(463f, -200f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(1.05f, 1.05f);
				break;
			case 1:
				leftWheel = Instantiate(luxuryWheel) as GameObject;
				rightWheel = Instantiate (luxuryWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-377f, -200f);
				rightWheel.transform.localPosition = new Vector3(463f, -200f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(1.05f, 1.05f);
				break;
			case 2:
				leftWheel = Instantiate(basicWheel) as GameObject;
				rightWheel = Instantiate (basicWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-377f, -200f);
				rightWheel.transform.localPosition = new Vector3(463f, -200f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(1.05f, 1.05f);
				break;
			default:
				break;
			}
			break;
		case 2:
			switch (wheelIndex)
			{
			case 0:
				leftWheel = Instantiate(sportWheel) as GameObject;
				rightWheel = Instantiate (sportWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-414f, -180f);
				rightWheel.transform.localPosition = new Vector3(435f, -180f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(1f, 1f);
				break;
			case 1:
				leftWheel = Instantiate(luxuryWheel) as GameObject;
				rightWheel = Instantiate (luxuryWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-414f, -180f);
				rightWheel.transform.localPosition = new Vector3(435f, -180f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(1f, 1f);
				break;
			case 2:
				leftWheel = Instantiate(basicWheel) as GameObject;
				rightWheel = Instantiate (basicWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-414f, -180f);
				rightWheel.transform.localPosition = new Vector3(435f, -180f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(1f, 1f);
				break;
			default:
				break;
			}
			break;
		case 3:
			switch (wheelIndex)
			{
			case 0:
				leftWheel = Instantiate(sportWheel) as GameObject;
				rightWheel = Instantiate (sportWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-395f, -136.6f);
				rightWheel.transform.localPosition = new Vector3(451f, -136.6f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(1.05f, 1.05f);
				break;
			case 1:
				leftWheel = Instantiate(luxuryWheel) as GameObject;
				rightWheel = Instantiate (luxuryWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-395f, -136.6f);
				rightWheel.transform.localPosition = new Vector3(451f, -136.6f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(1.05f, 1.05f);
				break;
			case 2:
				leftWheel = Instantiate(basicWheel) as GameObject;
				rightWheel = Instantiate (basicWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-395f, -136.6f);
				rightWheel.transform.localPosition = new Vector3(451f, -136.6f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(1.05f, 1.05f);
				break;
			default:
				break;
			}
			break;
		case 4:
			switch (wheelIndex)
			{
			case 0:
				leftWheel = Instantiate(sportWheel) as GameObject;
				rightWheel = Instantiate (sportWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-321f, -128f);
				rightWheel.transform.localPosition = new Vector3(289f, -131f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(0.9f, 0.9f);
				break;
			case 1:
				leftWheel = Instantiate(luxuryWheel) as GameObject;
				rightWheel = Instantiate (luxuryWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-321f, -128f);
				rightWheel.transform.localPosition = new Vector3(289f, -131f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(0.9f, 0.9f);
				break;
			case 2:
				leftWheel = Instantiate(basicWheel) as GameObject;
				rightWheel = Instantiate (basicWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-321f, -128f);
				rightWheel.transform.localPosition = new Vector3(289f, -131f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(0.9f, 0.9f);
				break;
			default:
				break;
			}
			break;
		default:
			break;
		}
		
	}

	void colorChange()
	{
		switch(colorIndex)
		{
		case 0:
			car.GetComponent<Image>().color = redColor;
			break;
		case 1:
			car.GetComponent<Image>().color = greenColor;
			break;
		case 2:
			car.GetComponent<Image>().color = yellowColor;
			break;
		case 3:
			car.GetComponent<Image>().color = orangeColor;
			break;
		case 4:
			car.GetComponent<Image>().color = turquoiseColor;
			break;
		case 5:
			car.GetComponent<Image>().color = carrotColor;
			break;
		case 6:
			car.GetComponent<Image>().color = pinkColor;
			break;
		case 7:
			car.GetComponent<Image>().color = greyColor;
			break;
		case 8:
			car.GetComponent<Image>().color = limeColor;
			break;
		case 9:
			car.GetComponent<Image>().color = navyColor;
			break;
		case 10:
			car.GetComponent<Image>().color = glaucousColor;
			break;
		default:
			break;
		}
	}

	void decalChange()
	{

		Destroy (decal);
		Destroy (decal2);

		switch(carIndex)
		{
		case 0:
			switch(decalIndex)
			{
			case 0:
				decal = Instantiate(star) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(-245f, -65f);
				decal2 = Instantiate(star) as GameObject;
				decal2.transform.parent = decalContainer.transform;
				decal2.transform.localPosition = new Vector3(219f, -65f);
				break;
			case 1:
				decal = Instantiate(flame) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(222f, -118f);
				decal.transform.localScale = new Vector3(1f, 0.45f);
				break;
			case 2:
				decal = Instantiate(stripe) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(45f, -135f);
				break;
			default:
				break;
			}
			break;
		case 1:
			switch(decalIndex)
			{
			case 0:
				decal = Instantiate(star) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(-200f, -125f);
				decal2 = Instantiate(star) as GameObject;
				decal2.transform.parent = decalContainer.transform;
				decal2.transform.localPosition = new Vector3(250f, -125f);
				break;
			case 1:
				decal = Instantiate(flame) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(172f, -160f);
				break;
			case 2:
				decal = Instantiate(stripe) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(20f, -140f);
				break;
			default:
				break;
			}
			break;
		case 2:
			switch(decalIndex)
			{
			case 0:
				decal = Instantiate(star) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(-182f, -85f);
				decal2 = Instantiate(star) as GameObject;
				decal2.transform.parent = decalContainer.transform;
				decal2.transform.localPosition = new Vector3(300f, -85f);
				break;
			case 1:
				decal = Instantiate(flame) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(175f, -125f);
				break;
			case 2:
				decal = Instantiate(stripe) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(0f, -140f);
				break;
			default:
				break;
			}
			break;
		case 3:
			switch(decalIndex)
			{
			case 0:
				decal = Instantiate(star) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(-170f, -70f);
				decal2 = Instantiate(star) as GameObject;
				decal2.transform.parent = decalContainer.transform;
				decal2.transform.localPosition = new Vector3(280f, -70f);
				break;
			case 1:
				decal = Instantiate(flame) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(190f, -85f);
				break;
			case 2:
				decal = Instantiate(stripe) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(0f, -120f);
				break;
			default:
				break;
			}
			break;
		case 4:
			switch(decalIndex)
			{
			case 0:
				decal = Instantiate(star) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(-250f, -60f);
				decal2 = Instantiate(star) as GameObject;
				decal2.transform.parent = decalContainer.transform;
				decal2.transform.localPosition = new Vector3(150f, -60f);
				decal.transform.localScale = new Vector3(.9f,.9f);
				decal2.transform.localScale = new Vector3(.9f,.9f);
				break;
			case 1:
				decal = Instantiate(flame) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(33f, -85f);
				break;
			case 2:
				decal = Instantiate(stripe_compact) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(0f, -95f);
				break;
			default:
				break;
			}
			break;
		default:
			break;
		}

	}


	void resetSelections()
	{
		gasButton.GetComponent<Image>().sprite = gasButtonSprite;
		electricButton.GetComponent<Image>().sprite = electricButtonSprite;
		hybridButton.GetComponent<Image>().sprite = hybridButtonSprite;
		automaticButton.GetComponent<Image>().sprite = automaticButtonSprite;
		manualButton.GetComponent<Image>().sprite = manualButtonSprite;
		twoWheelDriveButton.GetComponent<Image>().sprite = twoWheelDriveButtonSprite;
		allWheelDriveButton.GetComponent<Image>().sprite = allWheelDriveButtonSprite;
		basicWheelButton.GetComponent<Image>().sprite = basicWheelSprite;
		luxuryWheelButton.GetComponent<Image>().sprite = luxuryWheelSprite;
		sportyWheelButton.GetComponent<Image>().sprite = sportyWheelSprite;
		starButton.GetComponent<Image>().sprite = starSprite;
		stripeButton.GetComponent<Image>().sprite = stripeSprite;
		flameButton.GetComponent<Image>().sprite = flameSprite;
		truckButton.GetComponent<Image>().sprite = truckSprite;
		suvButton.GetComponent<Image>().sprite = suvSprite;
		vanButton.GetComponent<Image>().sprite = vanSprite;
		coupeButton.GetComponent<Image>().sprite = coupeSprite;
		compactButton.GetComponent<Image>().sprite = compactSprite;
		truckButton.GetComponent<Image>().color = new Color32(51,51,51,255);
		suvButton.GetComponent<Image>().color = new Color32(51,51,51,255);
		vanButton.GetComponent<Image>().color = new Color32(51,51,51,255);
		coupeButton.GetComponent<Image>().color = new Color32(51,51,51,255);
		compactButton.GetComponent<Image>().color = new Color32(51,51,51,255);

		spoilerButton.GetComponent<Image> ().color = new Color32 (51, 51, 51, 255);
		noSpoilerButton.GetComponent<Image> ().sprite = noSpoilerActivebuttonSprite;

		noDecalButton.GetComponent<Image> ().sprite = noDecalButtonActiveSprite;

		Destroy (car);
		Destroy (spoiler);
		Destroy (leftWheel);
		Destroy (rightWheel);
		Destroy (decal);
		Destroy (decal2);
		/*
		if (car != null)
		{
			Destroy(car);
		}
		if (spoiler != null)
		{
			Destroy(spoiler);
		}
		if (leftWheel != null)
		{
			Destroy(leftWheel);
			Destroy(rightWheel);
		}
		if (decal != null)
		{
			Destroy(decal);
		}
		if (decal2 != null) {
			Destroy(decal2);
		}
		*/
	}
	void removeCar()
	{
		if (car != null)
		{
			Destroy(car);
		}
		truckButton.GetComponent<Image>().color = new Color32(51,51,51,255);
		suvButton.GetComponent<Image>().color = new Color32(51,51,51,255);
		vanButton.GetComponent<Image>().color = new Color32(51,51,51,255);
		coupeButton.GetComponent<Image>().color = new Color32(51,51,51,255);
		compactButton.GetComponent<Image>().color = new Color32(51,51,51,255);
	}
	void removeColor()
	{
		car.GetComponent<Image>().color = new Color32(51,51,51,255);
	}
	void removeWheels()
	{
		if (leftWheel != null)
		{
			Destroy(leftWheel);
			Destroy(rightWheel);
		}
		basicWheelButton.GetComponent<Image>().sprite = basicWheelButtonSprite;
		luxuryWheelButton.GetComponent<Image>().sprite = luxuryWheelButtonSprite;
		sportyWheelButton.GetComponent<Image>().sprite = sportyWheelButtonSprite;

	}
	void removeDecal()
	{
		if (decal != null)
		{
			Destroy(decal);
			if (decal2 != null)
			{
				Destroy(decal2);
			}
		}

		flameButton.GetComponent<Image>().sprite = flamesButtonSprite;
		starButton.GetComponent<Image>().sprite = starsButtonSprite;
		stripeButton.GetComponent<Image>().sprite = stripeButtonSprite;

	}

	void removeSpoiler()
	{
		if (spoiler != null)
		{
			Destroy(spoiler);
		}
	}
	//Enables Button after choice is made and switches the next button image
	void EnableNextButton ()
	{
		next_Button.GetComponent<Button>().interactable = true;
		next_Button.GetComponent<Image>().sprite = next_Button_Active;
	}

	void RemovePreviousCarPart()
	{
		Transition transition_Script = appSlider_ref.GetComponent<Transition> ();
		int localSceneIndex = transition_Script.scene_index;
		switch (localSceneIndex)
		{
		case 6:
			if (car != null)
			{
				Destroy (car);
			}
			break;
		case 7:
			if (spoiler != null)
			{
				Destroy (spoiler);
			}
			break;
		case 8:
			if (leftWheel != null)
			{
				Destroy(leftWheel);
				Destroy(rightWheel);
			}
			break;
		case 9:
			car.GetComponent<Image>().color = new Color32 (51, 51, 51, 255);
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = new Color32 (51,51,51,255);
			}
			break;
		case 10:
			if (decal != null)
			{
				Destroy(decal);
			}
			if (decal2 != null)
			{
				Destroy (decal2);
			}
			break;
		default:
			break;
		}
	}
}
